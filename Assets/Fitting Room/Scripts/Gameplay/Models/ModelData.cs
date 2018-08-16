using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using thelab.mvc;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ModelData : Model<GameplayApps>
{

    private List<GameObject> _photoImages;
    public List<GameObject> photoImages
    {
        set; get;
    }

    private Text _textCountDown;
    public Text textCountDown
    {
        set; get;
    }

    private GUITexture _panelTexture;
    public GUITexture panelTexture
    {
        set; get;
    }

    private Camera _backgroundCamera;
    public Camera backgroundCamera
    {
        set; get;
    }
    private Camera _foregroundCamera;
    public Camera foregroundCamera
    {
        set; get;
    }

    #region Kinect Class
    private KinectManager _kinectManager;
    public KinectManager kinectManager
    {
        set; get;
    }

    private UserBodyBlender _userBodyBlender;
    public UserBodyBlender userBodyBlender
    {
        set; get;
    }
    #endregion
    //Data variable
    private int _statusGame;
    public int statusGame
    {
        set; get;
    }

    private string _fileName;
    public string fileName
    {
        set; get;
    }

    private bool _menuCondition;
    public bool menuCondition
    {
        set; get;
    }

    private bool _enviSelected;
    public bool enviSelected
    {
        set; get;
    }

    private int _selectedEnvi;
    public int selectedEnvi
    {
        set; get;
    }


    /// <summary>
    /// Currently active player index if player is more than one, if only one then playerIndex will set to 0
    /// </summary>
    private int _playerIndex;
    public int playerIndex
    {
        set; get;
    }

    private int[] _allPlayer;
    public int[] allPlayer
    {
        set; get;
    }

    private List<GameObject> _clothMenus;
    public List<GameObject> clothMenus
    {
        set; get;
    }

    private string _photoPath;
    public string photoPath
    {
        set; get;
    }

    private EventSystem _eventSystem;
    public EventSystem eventSystem
    {
        set; get;
    }

    private bool _isFadeDone;
    public bool isFadeDone
    {
        set; get;
    }

}
