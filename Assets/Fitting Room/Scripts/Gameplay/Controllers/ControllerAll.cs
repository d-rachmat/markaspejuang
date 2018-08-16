using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using thelab.mvc;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ControllerAll : Controller<GameplayApps> {
    public int totalPeople = 0;
    public ControllerButton cbcb;

    void Start()
    {
        //SetAllObjects(false);
        InitAllComponent();
        InitClothesComponent();
        SetInitialState();
    }

    void Update()
    {
        //ShowMenu();
        MagicButton();
 //       CheckGestureComplete();
    }
    
    private void InitClothesComponent()
    {
        app.model.modelClothes.selModel = null;
        app.model.modelClothes.listClothes = new GameObject[app.model.modelData.kinectManager.maxTrackedUsers];
        app.model.modelClothes.selModels = new List<GameObject>();
       
    }
    private void InitAllComponent()
    {
        #region Init Kinect Component
        app.model.modelData.kinectManager = KinectManager.Instance;
        app.model.modelData.userBodyBlender = app.model.modelUI.mainCamera.GetComponent<UserBodyBlender>();
        app.model.modelData.eventSystem = app.controller.interactionInputModule.GetComponent<EventSystem>();
        #endregion

        #region Init Camera
        app.model.modelData.backgroundCamera = app.model.modelUI.secondCamera.GetComponent<Camera>();
        app.model.modelData.foregroundCamera = app.model.modelUI.mainCamera.GetComponent<Camera>();
        
        app.model.modelData.backgroundCamera.aspect = 1920f / 1080f;
        app.model.modelData.foregroundCamera.aspect = 1920f / 1080f;
        #endregion

        #region Init General Component

        app.model.modelData.allPlayer = new int[app.model.modelData.kinectManager.maxTrackedUsers];
        app.model.modelData.textCountDown = app.model.modelUI.countDown.GetComponent<Text>();
        app.model.modelData.panelTexture = app.model.modelUI.panelBackground.GetComponent<GUITexture>();
        app.model.modelData.photoImages = new List<GameObject>();
        app.model.modelData.clothMenus = new List<GameObject>();
        #endregion

        #region Init Button
        app.model.modelButton.selectableClothes = app.model.modelUI.clothButton.GetComponent<Selectable>();
        app.model.modelButton.viewClothes = app.model.modelUI.clothButton.GetComponent<ButtonView>();
        #endregion
    }

    /// <summary>
    /// Set all initial state when starting the game. Just show what you want to show at first
    /// </summary>
    private void SetInitialState()
    {
        app.model.modelUI.flash.SetActive(false);
        app.model.modelUI.result.SetActive(false);
        app.model.modelUI.preMenu.SetActive(false);
        app.model.modelUI.galleryMenu.SetActive(false);
        app.model.modelUI.countDown.SetActive(false);
        app.model.modelUI.clothMenu.SetActive(true);
        app.model.modelUI.environmentMenu.SetActive(true);
        app.model.modelUI.arrowDown.SetActive(true);
        SetCamera(false, true);
        app.model.modelUI.panelCloth.SetActive(true);
        app.model.modelUI.mainMenu.SetActive(false);
        cbcb.LivingRoomClicked();
        cbcb.ClothesClicked();
        app.model.modelUI.clothMenu.SetActive(true);

        app.model.modelUI.panelCloth.SetActive(false);
    }

    private void SetAllObjects(bool condition)
    {
        app.model.modelUI.mainMenu.SetActive(condition);
        app.model.modelUI.takePhoto.SetActive(condition);
    }

    /// <summary>
    /// Show menu called in update where user is in kinect range, if not then the menu will dissappear and so on
    /// </summary>
    private void ShowMenu()
    {
        if (app.model.modelData.kinectManager.IsUserDetected() == true && !app.model.modelUI.mainMenu.activeSelf)
        {
            SetAllObjects(true);
        }
        else if(!app.model.modelData.kinectManager.IsUserDetected() && app.model.modelUI.mainMenu.activeSelf)
        {
            SetAllObjects(false);
        }
    }

    private void CheckGestureComplete()
    {
        if (!app.model.modelData.isFadeDone)
        {
            if (app.model.modelData.kinectManager.isGestureComplete && app.model.modelUI.panelStart.activeSelf == true)
            {
                StartCoroutine(Transition(app.model.modelUI.panelStart));
                app.model.modelData.kinectManager.isGestureComplete = false;
            }

            if (app.model.modelData.kinectManager.GetUsersCount() == 0 && app.model.modelUI.panelStart.activeSelf == false)
            {
                StartCoroutine(RestartState());
            }
        }
    }

    /// <summary>
    /// When people walk away from kinect range, it will restart to its initial state
    /// </summary>
    /// <returns></returns>
    private IEnumerator RestartState()
    {
        yield return StartCoroutine(Transition(app.model.modelUI.panelStart, true));

        app.model.modelUI.result.SetActive(false);
        app.model.modelUI.restartPhoto.SetActive(false);
        app.model.modelUI.mainMenu.SetActive(false);

        app.model.modelUI.arrowDown.SetActive(true);
        app.model.modelUI.environmentMenu.SetActive(true);
        app.model.modelUI.takePhoto.SetActive(true);

        ResetBackground();
    }

    private void ResetBackground()
    {
        SetCamera(false, true);
        app.model.modelData.enviSelected = false;
        app.model.modelData.panelTexture.texture = null;
        app.model.modelData.selectedEnvi = (int)Environment.empty;
    }

    private void SetCamera(bool conditionOne, bool conditionTwo)
    {
        app.model.modelData.userBodyBlender.enabled = conditionOne;
        app.model.modelUI.secondCamera.SetActive(conditionTwo);
    }

    private IEnumerator Transition(GameObject obj, bool isReverse = false)
    {
        app.model.modelData.isFadeDone = true;
        CanvasGroup cg = obj.GetComponent<CanvasGroup>();
        print(cg.alpha);
        switch (isReverse)
        {
            case false:
                while (cg.alpha > 0)
                {
                    cg.alpha -= 0.05f;
                    yield return null;
                }
                obj.SetActive(false);
                break;
            case true:
                obj.SetActive(true);
                while (cg.alpha < 1)
                {
                    cg.alpha += 0.05f;
                    yield return null;
                }
                break;
        }
        app.model.modelData.isFadeDone = false;
    }

    private void MagicButton()
    {
        if (!app.model.modelData.isFadeDone)
        {
            if (Input.GetKeyUp(KeyCode.S))
            {
                StartCoroutine(Transition(app.model.modelUI.panelStart, false));
            }
            if (Input.GetKeyUp(KeyCode.Escape))
            {
                StartCoroutine(Transition(app.model.modelUI.panelStart, true));
            }
        }
    }
    
}
