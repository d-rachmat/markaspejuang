using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using thelab.mvc;
using UnityEngine.UI;

public class ControllerButton : Controller<GameplayApps>
{
    private void Start()
    {
    
    }
    public override void OnNotification(string p_event, Object p_target, params object[] p_data)
    {
        switch (p_event)
        {
            #region Button Main Menu
            case StringCollections.environment_clicked:
                EnvironmentClicked();
                break;
            case StringCollections.clothes_clicked:
                ClothesClicked();
                break;
            case StringCollections.gallery_clicked:
                app.controller.controllerGallery.GalleryClicked();
                break;
            case StringCollections.confirm_clicked:
                //ChangePlayerControl();
                break;
            #endregion

            #region Button Environment
            case StringCollections.beach_clicked:
                BeachClicked();
                break;
            case StringCollections.garden_clicked:
                GardenClicked();
                break;
            case StringCollections.kidroom_clicked:
                KidRoomClicked();
                break;
            case StringCollections.livingroom_clicked:
                LivingRoomClicked();
                break;
            #endregion

            #region Button Clothes
            case StringCollections.clothes1_clicked:
                ClothesItemClicked(StringCollections.clothes1_clicked);
                break;
            case StringCollections.clothes2_clicked:
                ClothesItemClicked(StringCollections.clothes2_clicked);
                break;
            case StringCollections.clothes3_clicked:
                ClothesItemClicked(StringCollections.clothes3_clicked);
                break;

            #region Homemade Clothes - Kids Room
            case StringCollections.captain_america_clicked:
                ClothesItemClicked(StringCollections.captain_america_clicked);
                break;
            case StringCollections.mr_incredible_clicked:
                ClothesItemClicked(StringCollections.mr_incredible_clicked);
                break;
            case StringCollections.wonder_girl_clicked:
                ClothesItemClicked(StringCollections.wonder_girl_clicked);
                break;
            case StringCollections.mrs_incredible_clicked:
                ClothesItemClicked(StringCollections.mrs_incredible_clicked);
                break;
            case StringCollections.incredible_boy_clicked:
                ClothesItemClicked(StringCollections.incredible_boy_clicked);
                break;
            case StringCollections.super_boy_clicked:
                ClothesItemClicked(StringCollections.super_boy_clicked);
                break;
            case StringCollections.incredible_girl_clicked:
                ClothesItemClicked(StringCollections.incredible_girl_clicked);
                break;
            case StringCollections.super_girl_clicked:
                ClothesItemClicked(StringCollections.super_girl_clicked);
                break;
            #endregion

            #region Homemade Clothes - Beach
            case StringCollections.father_wetsuit_1_clicked:
                ClothesItemClicked(StringCollections.father_wetsuit_1_clicked);
                break;
            case StringCollections.father_wetsuit_2_clicked:
                ClothesItemClicked(StringCollections.father_wetsuit_2_clicked);
                break;
            case StringCollections.mom_wetsuit_1_clicked:
                ClothesItemClicked(StringCollections.mom_wetsuit_1_clicked);
                break;
            case StringCollections.mom_wetsuit_2_clicked:
                ClothesItemClicked(StringCollections.mom_wetsuit_2_clicked);
                break;
            case StringCollections.son_wetsuit_1_clicked:
                ClothesItemClicked(StringCollections.son_wetsuit_1_clicked);
                break;
            case StringCollections.son_wetsuit_2_clicked:
                ClothesItemClicked(StringCollections.son_wetsuit_2_clicked);
                break;
            case StringCollections.daughter_wetsuit_1_clicked:
                ClothesItemClicked(StringCollections.daughter_wetsuit_1_clicked);
                break;
            case StringCollections.daughter_wetsuit_2_clicked:
                ClothesItemClicked(StringCollections.daughter_wetsuit_2_clicked);
                break;
            #endregion

            #region Homemade Clothes - Garden
            case StringCollections.father_shirt_1_clicked:
                ClothesItemClicked(StringCollections.father_shirt_1_clicked);
                break;
            case StringCollections.father_shirt_2_clicked:
                ClothesItemClicked(StringCollections.father_shirt_2_clicked);
                break;
            case StringCollections.mother_cloth_1_clicked:
                ClothesItemClicked(StringCollections.mother_cloth_1_clicked);
                break;
            case StringCollections.mother_cloth_2_clicked:
                ClothesItemClicked(StringCollections.mother_cloth_2_clicked);
                break;
            case StringCollections.Son_Shirt_1_clicked:
                ClothesItemClicked(StringCollections.Son_Shirt_1_clicked);
                break;
            case StringCollections.Son_Shirt_2_clicked:
                ClothesItemClicked(StringCollections.Son_Shirt_2_clicked);
                break;
            case StringCollections.daughter_dress_1_clicked:
                ClothesItemClicked(StringCollections.daughter_dress_1_clicked);
                break;
            case StringCollections.daughter_dress_2_clicked:
                ClothesItemClicked(StringCollections.daughter_dress_2_clicked);
                break;
            #endregion

            #region Homemade Clothes - Living Room
            case StringCollections.Father_Batik_1_clicked:
                ClothesItemClicked(StringCollections.Father_Batik_1_clicked);
                break;
            case StringCollections.Father_Batik_2_clicked:
                ClothesItemClicked(StringCollections.Father_Batik_2_clicked);
                break;
            case StringCollections.Mother_Batik_1_clicked:
                ClothesItemClicked(StringCollections.Mother_Batik_1_clicked);
                break;
            case StringCollections.Mother_Batik_2_clicked:
                ClothesItemClicked(StringCollections.Mother_Batik_2_clicked);
                break;
            case StringCollections.Son_Batik_1_clicked:
                ClothesItemClicked(StringCollections.Son_Batik_1_clicked);
                break;
            case StringCollections.Son_Batik_2_clicked:
                ClothesItemClicked(StringCollections.Son_Batik_2_clicked);
                break;
            case StringCollections.Daughter_Batik_1_clicked:
                ClothesItemClicked(StringCollections.Daughter_Batik_1_clicked);
                break;
            case StringCollections.Daughter_Batik_2_clicked:
                ClothesItemClicked(StringCollections.Daughter_Batik_2_clicked);
                break;
            #endregion

            case StringCollections.removeclothes_clicked:
                DestroySelectedModel();
                break;
            case StringCollections.plus_clicked:
                ResizeClicked(0.1f);
                break;
            case StringCollections.minus_clicked:
                ResizeClicked(-0.1f);
                break;
            #endregion

            #region Select Active Clothes
            case StringCollections.dadclothes_clicked:
                ChangeActiveClothesMenu((int)Family.dad);
                break;
            case StringCollections.momclothes_clicked:
                ChangeActiveClothesMenu((int)Family.mom);
                break;
            case StringCollections.sonclothes_clicked:
                ChangeActiveClothesMenu((int)Family.son);
                break;
            case StringCollections.daughterclothes_clicked:
                ChangeActiveClothesMenu((int)Family.daughter);
                break;
            #endregion

            #region Button General
            case StringCollections.changeuser_clicked:
                ChangeActiveUser();
                break;
            case StringCollections.removebackground_clicked:
                ResetBackground();
                break;
            case StringCollections.takephoto_clicked:
                TakePhoto();
                break;
            case StringCollections.restartphoto_clicked:
                SetInitialState();
                break;
                #endregion
        }
    }


    #region Function Change Background
    private void ResetBackground()
    {
        SetCamera(true, false);
        app.model.modelData.enviSelected = false;
        app.model.modelData.panelTexture.texture = null;
        app.model.modelData.selectedEnvi = (int)Environment.empty;
    }
    private void BeachClicked()
    {
        if (app.model.modelData.selectedEnvi != 0)
            DestroyAllModel();

        SetCamera(false, true);
        app.model.modelData.enviSelected = true;
        app.model.modelData.panelTexture.texture = app.model.modelTexture.beach;
        app.model.modelData.selectedEnvi = (int)Environment.beach;
    }
    private void GardenClicked()
    {
        if (app.model.modelData.selectedEnvi != 0)
            DestroyAllModel();

        SetCamera(false, true);
        app.model.modelData.enviSelected = true;
        app.model.modelData.panelTexture.texture = app.model.modelTexture.garden;
        app.model.modelData.selectedEnvi = (int)Environment.garden;
    }
    private void KidRoomClicked()
    {
        if (app.model.modelData.selectedEnvi != 0)
            DestroyAllModel();

        SetCamera(false, true);
        app.model.modelData.enviSelected = true;
        app.model.modelData.panelTexture.texture = app.model.modelTexture.kidRoom;
        app.model.modelData.selectedEnvi = (int)Environment.kid_room;
    }
    public void LivingRoomClicked()
    {
        if (app.model.modelData.selectedEnvi != 0)
            DestroyAllModel();

        SetCamera(false, true);
        app.model.modelData.enviSelected = true;
        app.model.modelData.panelTexture.texture = app.model.modelTexture.livingRoom;
        app.model.modelData.selectedEnvi = (int)Environment.living_room;
    }
    /// <summary>
    /// Set camera, if you wanna show background, then you should false condition one and make condition two into true
    /// </summary>
    /// <param name="conditionOne"></param>
    /// <param name="conditionTwo"></param>
    private void SetCamera(bool conditionOne, bool conditionTwo)
    {
        app.model.modelData.userBodyBlender.enabled = conditionOne;
        app.model.modelUI.secondCamera.SetActive(conditionTwo);
    }
    #endregion

    #region Function Menu
    private void EnvironmentClicked()
    {
        app.model.modelData.statusGame = (int)Status.environment_active;
        app.model.modelUI.clothMenu.SetActive(false);
        app.model.modelUI.panelCloth.SetActive(false);
        app.model.modelData.menuCondition = app.model.modelUI.environmentMenu.activeSelf;
        switch (app.model.modelData.menuCondition)
        {
            case true:
                app.model.modelUI.takePhoto.SetActive(true);
                app.model.modelUI.environmentMenu.SetActive(false);
                break;
            case false:
                app.model.modelUI.takePhoto.SetActive(false);
                app.model.modelUI.environmentMenu.SetActive(true);
                break;
        }


    }
    public void ClothesClicked()
    {
        app.model.modelData.statusGame = (int)Status.clothes_active;

        app.model.modelUI.environmentMenu.SetActive(false);
        app.model.modelUI.panelCloth.SetActive(true);
        app.model.modelData.menuCondition = app.model.modelUI.clothMenu.activeSelf;
        switch (app.model.modelData.menuCondition)
        {
            case true:
                app.model.modelUI.arrowDown.SetActive(false);
                app.model.modelUI.takePhoto.SetActive(true);
                app.model.modelUI.clothMenu.SetActive(false);
                break;
            case false:
                app.model.modelUI.arrowDown.SetActive(true);
                app.model.modelUI.takePhoto.SetActive(false);
                app.model.modelUI.clothMenu.SetActive(true);
                break;
        }

        switch (app.model.modelData.selectedEnvi)
        {
            case (int)Environment.beach:
                ChangeActiveSubMenu((int)Environment.beach);
                break;
            case (int)Environment.garden:
                ChangeActiveSubMenu((int)Environment.garden);
                break;
            case (int)Environment.kid_room:
                ChangeActiveSubMenu((int)Environment.kid_room);
                break;
            case (int)Environment.living_room:
                ChangeActiveSubMenu((int)Environment.living_room);
                break;
            default:
                break;
        }
    }
    #endregion

    #region General Function

    /// <summary>
    /// Change background and text color family menu (dad, mom, children, daughter)
    /// </summary>
    /// <param name="index"></param>
    /// <param name="bgcolor"></param>
    /// <param name="txtcolor"></param>
    private void ChangeFamilyColor(int index, Color bgcolor, Color txtcolor)
    {
        app.model.modelUI.familymenu[index].GetComponent<Image>().color = bgcolor;
        app.model.modelUI.familymenu[index].transform.GetChild(0).GetComponent<Text>().color = txtcolor;
    }
    /// <summary>
    /// If still no environment selected, then clothes button cannot clicked. User must select envi first.
    /// </summary>
    private void ChangeClothesButton()
    {
        if (!app.model.modelData.enviSelected && app.model.modelButton.selectableClothes.interactable)
        {
            app.model.modelButton.selectableClothes.interactable = false;
            app.model.modelButton.viewClothes.enabled = false;
        }
        else if (app.model.modelData.enviSelected && !app.model.modelButton.selectableClothes.interactable)
        {
            app.model.modelButton.selectableClothes.interactable = true;
            app.model.modelButton.viewClothes.enabled = true;
        }
    }

    /// <summary>
    /// 
    /// </summary>
    private void ChangePlayerControl()
    {
        //print(app.model.modelData.kinectManager.GetUsersCount());
        if (app.model.modelData.kinectManager.GetUsersCount() == 0)
        {
            app.controller.interactionManager.playerIndex = 0;
            app.controller.interactionInputModule.playerIndex = 0;
            app.controller.controllerOverlay.playerIndex = 0;
        }
        else if (app.model.modelData.kinectManager.GetUsersCount() > 0)
        {
            if (app.model.modelData.kinectManager.isUserLostFromKinect)
            {
                for (int i = 0; i < app.model.modelData.allPlayer.Length; i++)
                {
                    if (app.model.modelData.allPlayer[i] != -1)
                    {
                        app.controller.interactionManager.playerIndex = app.model.modelData.allPlayer[i];
                        app.controller.interactionInputModule.playerIndex = app.model.modelData.allPlayer[i];
                        app.controller.controllerOverlay.playerIndex = app.model.modelData.allPlayer[i];
                        break;
                    }
                }
            }
        }
    }

    /// <summary>
    /// Change active submenu, if user select garden, then submenu clothes garden will activate
    /// </summary>
    /// <param name="condition">condition is used to check what environment is active right now</param>
    private void ChangeActiveSubMenu(int condition)
    {
        for (int i = 0; i < app.model.modelUI.submenus.Length; i++)
        {
            switch (i == condition)
            {
                case true:
                    //0 =  dad

                    app.model.modelUI.submenus[i].SetActive(true);
                    app.model.modelData.clothMenus.Clear();
                    for (int j = 0; j < app.model.modelUI.submenus[i].transform.childCount; j++)
                    {
                        app.model.modelData.clothMenus.Add(app.model.modelUI.submenus[i].transform.GetChild(j).gameObject);
                        print(app.model.modelData.clothMenus[j].name);
                    }
                    for (int j = 0; j < app.model.modelUI.familymenu.Length; j++)
                    {
                        switch (j == 0)
                        {
                            case true:
                                ChangeFamilyColor(j, Color.white, Color.white);
                                break;
                            default:
                                ChangeFamilyColor(j, Color.white, Color.white);
                                break;
                        }
                    }
                    break;
                case false:
                    app.model.modelUI.submenus[i].SetActive(false);
                    break;
            }
        }
    }
    #endregion

    #region Take Photo
    private void TakePhoto()
    {
        StartCoroutine(CoCountdownAndMakePhoto());

    }
    private IEnumerator CoCountdownAndMakePhoto()
    {
        app.model.modelUI.arrowDown.SetActive(false);
        app.model.modelUI.environmentMenu.SetActive(false);
        app.model.modelUI.takePhoto.SetActive(false);
        app.model.modelUI.mainMenu.SetActive(false);
        app.model.modelUI.countDown.SetActive(true);
        app.model.modelUI.guiCursor.SetActive(false);
        app.model.modelUI.panelCloth.SetActive(false);
        app.model.modelUI.audios.Play();

        int timer = 5;
        while (timer > 0)
        {
            app.model.modelData.textCountDown.text = timer.ToString();
            Debug.Log(timer);
            timer--;
            yield return new WaitForSeconds(1.0f);
        }
        app.model.modelUI.countDown.SetActive(false);
        yield return new WaitForEndOfFrame();
        MakePhoto();
        StartCoroutine(FlashOn());
   
    }
    private IEnumerator FlashOn()
    {
        app.model.modelUI.flash.SetActive(true);
        Image flash = app.model.modelUI.flash.GetComponent<Image>();
        float a = 0;
        while (flash.color.a < 1)
        {
            a += 0.1f;
            flash.color = new Color(1, 1, 1, a);
            yield return null;
        }

       // StartCoroutine(SavePhotoToWebsite());
        StartCoroutine(OpenCapturedPhoto());

        while (flash.color.a > 0)
        {
            a -= 0.01f;
            flash.color = new Color(1, 1, 1, a);
            yield return null;
        }
        app.model.modelUI.guiCursor.SetActive(true);
        app.model.modelUI.flash.SetActive(false);
        app.model.modelUI.panelCloth.SetActive(false);
       // app.model.modelUI.mainMenu.SetActive(true);
        SetRestartMenu(true);

    }

    /// <summary>
    /// Open the result after user capture photo
    /// </summary>
    /// <returns></returns>
    private IEnumerator OpenCapturedPhoto()
    {
        app.model.modelUI.result.SetActive(true);
        WWW www = new WWW("file://" + app.model.modelData.photoPath);
        yield return www;
        app.model.modelUI.result.GetComponent<RawImage>().texture = www.texture;
    }

    /// <summary>
    /// Upload photo to local website
    /// </summary>
    /// <returns></returns>
    private IEnumerator SavePhotoToWebsite()
    {
        string url = "http://localhost/Synthesis%20Gallery/logic/doUploadImage.php";
        WWW photo = new WWW("file://" + app.model.modelData.photoPath);
        yield return photo;

        WWWForm form = new WWWForm();
        form.AddField("photostatus", 1);
        form.AddBinaryData("photo", photo.bytes, app.model.modelData.fileName, "text/plain");

        WWW upload = new WWW(url, form);
        yield return upload;
        if (upload.error == null)
        {
            Debug.Log("upload done :" + upload.text);
        }
        else
        {
            Debug.Log("Error during upload: " + upload.error);
        }
    }

    private void SetRestartMenu(bool condition)
    {
        app.model.modelUI.restartPhoto.SetActive(condition);
    }
    private void MakePhoto()
    {
        app.model.modelData.photoPath = MakePhoto(true);
    }
	public string MakePhoto(bool openIt)
    {
        int resWidth = Screen.width;
        int resHeight = Screen.height;
        Texture2D snap = new Texture2D(Screen.width, Screen.height);

        #region Cara Lama
        //Texture2D screenShot = new Texture2D(resWidth, resHeight, TextureFormat.RGB24, false); //Create new texture
        //RenderTexture rt = new RenderTexture(resWidth, resHeight, 24);

        //// render background and foreground cameras
        //if (app.model.modelData.backgroundCamera && app.model.modelData.backgroundCamera.enabled)
        //{
        //    app.model.modelData.backgroundCamera.targetTexture = rt;
        //    app.model.modelData.backgroundCamera.Render();
        //    app.model.modelData.backgroundCamera.targetTexture = null;
        //}

        //if (app.model.modelData.foregroundCamera && app.model.modelData.foregroundCamera.enabled)
        //{

        //    app.model.modelData.foregroundCamera.targetTexture = rt;
        //    print(app.model.modelData.foregroundCamera.targetTexture);
        //    app.model.modelData.foregroundCamera.Render();
        //    app.model.modelData.foregroundCamera.targetTexture = null;
        //}

        //// get the screenshot
        //RenderTexture prevActiveTex = RenderTexture.active;
        //RenderTexture.active = rt;

        //screenShot.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);

        //// clean-up
        //RenderTexture.active = prevActiveTex;
        //Destroy(rt);

        //byte[] btScreenShot = screenShot.EncodeToJPG();
        //Destroy(screenShot);
        #endregion

        #region Cara Baru
        snap.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
        snap.Apply();
        byte[] btScreenShot = snap.EncodeToJPG();
        Destroy(snap);

	
        //SetInitialState();
        #endregion

#if !UNITY_WSA
        // save the screenshot as jpeg file
        string sDir = Application.dataPath + "/Screenshots";
        if (!Directory.Exists(sDir))
            Directory.CreateDirectory(sDir);


        string sFileName = sDir + "/" + string.Format("{0:F0}", Time.realtimeSinceStartup * 10f) + ".jpg";
        Debug.Log(sFileName);
        File.WriteAllBytes(sFileName, btScreenShot);
        app.model.modelData.fileName = sFileName;
        Debug.Log("Photo saved to: " + sFileName);
        // open file

        //if (openIt)
        //{
        //    System.Diagnostics.Process.Start(sFileName);
        //}

        return sFileName;
#elif NETFX_CORE
        System.Threading.Tasks.Task<string> task = null;

        string sFileName = string.Format("{0:F0}", Time.realtimeSinceStartup * 10f) + ".jpg";
        string sFileUrl = string.Empty; // "ms-appdata:///local/" + sFileName;

//						UnityEngine.WSA.Application.InvokeOnUIThread(() =>
//						{
        task = SaveImageFileAsync(sFileName, btScreenShot, openIt);
//						}, true);

        while (task != null && !task.IsCompleted && !task.IsFaulted)
        {
            task.Wait(100);
        }

        if (task != null)
        {
            if (task == null)
                throw new Exception("Could not create task for SaveImageFileAsync()");
            else if (task.IsFaulted)
                throw task.Exception;

            sFileUrl = task.Result;
            Debug.Log(sFileUrl);
        }

        return sFileUrl;
#else
		return string.Empty;
#endif
    }

#if NETFX_CORE
    private async System.Threading.Tasks.Task<string> SaveImageFileAsync(string imageFileName, byte[] btImageContent, bool openIt)
    {
        Windows.Storage.StorageFolder storageFolder = Windows.Storage.ApplicationData.Current.LocalFolder;
        Windows.Storage.StorageFile imageFile = await storageFolder.CreateFileAsync(imageFileName,
            Windows.Storage.CreationCollisionOption.ReplaceExisting);

        await Windows.Storage.FileIO.WriteBytesAsync(imageFile, btImageContent);

        if(openIt)
        {
            await Windows.System.Launcher.LaunchFileAsync(imageFile);
        }

        return imageFile.Path;
    }
#endif

    /// <summary>
    /// After you take photo, icon will reappear again, cheers.
    /// </summary>
    private void SetInitialState()
    {
        app.model.modelUI.result.SetActive(false);
        app.model.modelUI.restartPhoto.SetActive(false);
        app.model.modelUI.mainMenu.SetActive(true);

        app.model.modelUI.arrowDown.SetActive(true);
        app.model.modelUI.environmentMenu.SetActive(true);
        app.model.modelUI.takePhoto.SetActive(true);
        app.model.modelUI.Logo.SetActive(false);
        
    }
    #endregion

    #region Resize Clothes
    private void ResizeClicked(float increment)
    {
        if (app.model.modelClothes.listClothes[app.model.modelData.playerIndex] != null)
        {
            AvatarScaler scaler = app.model.modelClothes.listClothes[app.model.modelData.playerIndex].GetComponent<AvatarScaler>();
            if (scaler != null)
            {
                scaler.bodyScaleFactor += increment;
                scaler.bodyWidthFactor += increment;
                scaler.armScaleFactor += increment;
                scaler.legScaleFactor += increment;
            }
        }
    }
    #endregion

    #region Select Clothes
    /// <summary>
    /// If user is alone (lel, pls bring your gf or bf), then you call this function
    /// </summary>
    /// <param name="notify"></param>
    public void ClothesItemClicked(string notify)
    {
        print("asdsadas");
        string cutText = notify.Substring(0, notify.LastIndexOf('@'));
        //int index = int.Parse(cutText);
        LoadClothes(cutText);
    }

    private string ChangeSubPath()
    {
        switch (app.model.modelData.selectedEnvi)
        {
            case (int)Environment.beach:
                return "Beach";

            case (int)Environment.garden:
                return "Garden";

            case (int)Environment.kid_room:
                return "Kids Room";

            case (int)Environment.living_room:
                return "Living Room";
            default:
                return string.Empty;
        }
    }

    private void LoadClothes(string clothesName)
    {
        app.model.modelClothes.verticalOffset = 0;
        app.model.modelClothes.forwardOffset = 0;
        app.model.modelClothes.modelCategory = "Clothing";
        string subPath = ChangeSubPath();
        int playerIndex = app.model.modelData.playerIndex;
        string modelPath = app.model.modelClothes.modelCategory + "/" + subPath + "/" + clothesName;
        print(modelPath);
        UnityEngine.Object modelPrefab = Resources.Load(modelPath, typeof(GameObject));
        if (modelPrefab == null)
            return;
        print(clothesName);
        Debug.Log("Model: " + modelPath);

        if (app.model.modelClothes.listClothes.Length >= app.model.modelData.kinectManager.GetUsersCount())
        {
            if (app.model.modelClothes.listClothes[app.model.modelData.playerIndex])
            {
                GameObject.Destroy(app.model.modelClothes.listClothes[app.model.modelData.playerIndex]);
                //app.model.modelClothes.selModels.RemoveAt(app.model.modelData.playerIndex);
            }
        }

        app.model.modelClothes.listClothes[app.model.modelData.playerIndex] = (GameObject)GameObject.Instantiate(modelPrefab, Vector3.zero, Quaternion.Euler(0, 180f, 0));
        app.model.modelClothes.listClothes[app.model.modelData.playerIndex].name = "Model000" + playerIndex;

        //app.model.modelClothes.selModels.Add(app.model.modelClothes.selModel);
        //app.model.modelClothes.selModels[playerIndex] = (GameObject)GameObject.Instantiate(modelPrefab, Vector3.zero, Quaternion.Euler(0, 180f, 0));
        //app.model.modelClothes.selModels[playerIndex].name = "Model000" + playerIndex;

        //app.model.modelClothes.selModel = (GameObject)GameObject.Instantiate(modelPrefab, Vector3.zero, Quaternion.Euler(0, 180f, 0));
        ////app.model.modelClothes.selModel.name = "Model" + "0000";

        AvatarController ac = app.model.modelClothes.listClothes[playerIndex].GetComponent<AvatarController>();
        if (ac == null)
        {
            ac = app.model.modelClothes.listClothes[playerIndex].AddComponent<AvatarController>();
            ac.playerIndex = playerIndex;

            ac.mirroredMovement = true;
            ac.verticalMovement = true;

            ac.verticalOffset = app.model.modelClothes.verticalOffset;
            ac.forwardOffset = app.model.modelClothes.forwardOffset;
            ac.smoothFactor = 0f;
        }

        ac.posRelativeToCamera = app.model.modelData.backgroundCamera;
        ac.posRelOverlayColor = (app.model.modelData.foregroundCamera != null);

        KinectManager km = KinectManager.Instance;
        //ac.Awake();

        if (km && km.IsInitialized())
        {
            long userId = km.GetUserIdByIndex(playerIndex);
            if (userId != 0)
            {
                ac.SuccessfulCalibration(userId, false);
            }

            // locate the available avatar controllers
            MonoBehaviour[] monoScripts = FindObjectsOfType(typeof(MonoBehaviour)) as MonoBehaviour[];
            km.avatarControllers.Clear();

            foreach (MonoBehaviour monoScript in monoScripts)
            {
                if ((monoScript is AvatarController) && monoScript.enabled)
                {
                    AvatarController avatar = (AvatarController)monoScript;
                    km.avatarControllers.Add(avatar);
                }
            }
        }

        AvatarScaler scaler = app.model.modelClothes.listClothes[app.model.modelData.playerIndex].GetComponent<AvatarScaler>();
        if (scaler == null)
        {
            scaler = app.model.modelClothes.listClothes[app.model.modelData.playerIndex].AddComponent<AvatarScaler>();
            scaler.playerIndex = playerIndex;
            scaler.mirroredAvatar = true;

            scaler.continuousScaling = true;
            scaler.bodyScaleFactor = 1.1f;
            scaler.bodyWidthFactor = 1.1f;
            scaler.armScaleFactor = 1.1f;
            scaler.legScaleFactor = 1.1f;
        }

        scaler.foregroundCamera = app.model.modelData.foregroundCamera;

    }
    #endregion

    #region Change Clothes
    private void ChangeActiveClothesMenu(int condition)
    {
        for (int i = 0; i < app.model.modelData.clothMenus.Count; i++)
        {
            switch (condition == i)
            {
                case true:
                   // ChangeFamilyColor(i, Color.white, Color.white);
                    app.model.modelData.clothMenus[i].SetActive(true);
                    break;
                case false:
                    //ChangeFamilyColor(i, Color.white, Color.white);
                    app.model.modelData.clothMenus[i].SetActive(false);
                    break;
            }
        }
    }
    #endregion

    #region Change Active User
    private void ChangeActiveUser()
    {
        int totalPlayer = app.model.modelData.kinectManager.GetUsersCount();
        print(app.model.modelData.playerIndex);
        if (totalPlayer - 1 > app.model.modelData.playerIndex)
        {
            app.model.modelData.playerIndex++;
        }
        else
        {
            app.model.modelData.playerIndex = 0;
        }
    }
    #endregion

    void Update()
    {
        ChangeClothesButton();
        ChangePlayerControl();
        DeleteClothes();
    }
    #region Delete Clothes
    private void DeleteClothes()
    {
        if (app.model.modelData.kinectManager.isUserLostFromKinect)
        {
            app.model.modelData.kinectManager.isUserLostFromKinect = false;
            if (app.model.modelClothes.listClothes.Length > 0)
            {
                DestroySelectedModel(app.model.modelData.kinectManager.idUserLost);
                print(app.model.modelData.kinectManager.idUserLost);

                for (int i = 0; i < app.model.modelData.allPlayer.Length; i++)
                {
                    if (app.model.modelData.allPlayer[i] != -1)
                    {
                        app.model.modelData.playerIndex = app.model.modelData.allPlayer[i];
                        break;
                    }
                }
            }
        }

        if (!app.model.modelData.enviSelected)
        {
            DestroyAllModel();
        }
    }

    private void DestroyAllModel()
    {
        for (int i = 0; i < app.model.modelClothes.listClothes.Length; i++)
        {
            DestroySelectedModel(i);
        }
    }
    /// <summary>
    /// Destroy clothes model based on given index
    /// </summary>
    /// <param name="index"></param>
    private void DestroySelectedModel(int index)
    {
        if (app.model.modelClothes.listClothes[index])
        {
            AvatarController ac = app.model.modelClothes.listClothes[index].GetComponent<AvatarController>();
            KinectManager km = KinectManager.Instance;
            ac.verticalOffset = 0.015f;

            if (ac != null && km != null)
            {
                km.avatarControllers.Remove(ac);
            }


            if (app.model.modelClothes.listClothes[index])
            {
                GameObject.Destroy(app.model.modelClothes.listClothes[index]);
            }
            //app.model.modelClothes.selModels.RemoveAt(index);
        }
    }

    /// <summary>
    /// Destroy clothes model based on player index
    /// </summary>
    private void DestroySelectedModel()
    {
        if (app.model.modelClothes.listClothes[app.model.modelData.playerIndex])
        {
            AvatarController ac = app.model.modelClothes.listClothes[app.model.modelData.playerIndex].GetComponent<AvatarController>();
            KinectManager km = KinectManager.Instance;

            if (ac != null && km != null)
            {
                km.avatarControllers.Remove(ac);
            }

            GameObject.Destroy(app.model.modelClothes.listClothes[app.model.modelData.playerIndex]);
            //app.model.modelClothes.selModel = null;
            //prevSelected = -1;
        }
    }

    #endregion
}