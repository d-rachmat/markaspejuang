using UnityEngine;
using thelab.mvc;
using UnityEngine.UI;

public class ModelUI : Model<GameplayApps>
{

    [Header("Drag and drop object here")]
    [Tooltip("Drag panel start here")]
    [SerializeField]
    private GameObject _panelStart;
    public GameObject panelStart
    {
        get
        {
            return _panelStart;
        }
    }
    [Header("Drag and drop object here")]
    [Tooltip("Drag panel start here")]
    [SerializeField]
    private AudioSource _audios;
    public AudioSource audios
    {
        get
        {
            return _audios;
        }
    }

    [Tooltip("Drag background to change the background")]
    [SerializeField]
    private GameObject _panelBackground;
    public GameObject panelBackground
    {
        get
        {
            return _panelBackground;
        }
    }

    [Tooltip("Drag take photo icon here")]
    [SerializeField]
    private GameObject _takePhoto;
    public GameObject takePhoto
    {
        get
        {
            return _takePhoto;
        }
    }

    [Tooltip("Drag count down text here")]
    [SerializeField]
    private GameObject _countDown;
    public GameObject countDown
    {
        get
        {
            return _countDown;
        }
    }

    [Tooltip("Drag cursor here")]
    [SerializeField]
    private GameObject _guiCursor;
    public GameObject guiCursor
    {
        get
        {
            return _guiCursor;
        }
    }

    [Tooltip("Drag cursor here")]
    [SerializeField]
    private GameObject _gridImage;
    public GameObject gridImage
    {
        get
        {
            return _gridImage;
        }
    }

    [Space(10)]
    [Tooltip("Drag arrow down here")]
    [SerializeField]
    private GameObject _arrowDown;
    public GameObject arrowDown
    {
        get
        {
            return _arrowDown;
        }
    }

    [Tooltip("Drag cursor here")]
    [SerializeField]
    private GameObject _flash;
    public GameObject flash
    {
        get
        {
            return _flash;
        }
    }

    [Tooltip("Drag cursor here")]
    [SerializeField]
    private GameObject _result;
    public GameObject result
    {
        get
        {
            return _result;
        }
    }

    [Tooltip("Drag cursor here")]
    [SerializeField]
    private GameObject _restartPhoto;
    public GameObject restartPhoto
    {
        get
        {
            return _restartPhoto;
        }
    }

    [Header("All camera goes here")]
    [Tooltip("Camera that you want to hide for background")]
    [SerializeField]
    private GameObject _mainCamera;
    public GameObject mainCamera
    {
        get
        {
            return _mainCamera;
        }
    }

    [Tooltip("Camera that want to show for background")]
    [SerializeField]
    private GameObject _secondCamera;
    public GameObject secondCamera
    {
        get
        {
            return _secondCamera;
        }
    }

    [Header("All menu goes here")]

    [Tooltip("Drag main menu here")]
    [SerializeField]
    private GameObject _mainMenu;
    public GameObject mainMenu
    {
        get
        {
            return _mainMenu;
        }
    }

    [Tooltip("Drag PanelCloth here")]
    [SerializeField]
    private GameObject _panelCloth;
    public GameObject panelCloth
    {
        get
        {
            return _panelCloth;
        }
    }

    [Tooltip("Drag Logohere")]
    [SerializeField]
    private GameObject _Logo;
    public GameObject Logo
    {

        get {

            return _Logo;
        }
    }

    [Tooltip("Drag environment menu here")]
    [SerializeField]
    private GameObject _environmentMenu;
    public GameObject environmentMenu
    {
        get
        {
            return _environmentMenu;
        }
    }

    [Tooltip("Drag cloth menu here")]
    [SerializeField]
    private GameObject _clothMenu;
    public GameObject clothMenu
    {
        get
        {
            return _clothMenu;
        }
    }

    [Tooltip("Drag gallery menu here")]
    [SerializeField]
    private GameObject _galleryMenu;
    public GameObject galleryMenu
    {
        get
        {
            return _galleryMenu;
        }
    }

    [Tooltip("Drag premenu here")]
    [SerializeField]
    private GameObject _preMenu;
    public GameObject preMenu
    {
        get
        {
            return _preMenu;
        }
    }
    [Header("All sub menu goes here")]
    [SerializeField]
    private GameObject[] _submenus;
    public GameObject[] submenus
    {
        get
        {
            return _submenus;
        }
    }


    [Header("All menu for example dad, mom, son and daughter goes here")]
    [SerializeField]
    private GameObject[] _familymenu;
    public GameObject[] familymenu
    {
        get
        {
            return _familymenu;
        }
    }

    [Header("Drag and drop menu here")]

    [Tooltip("Drag cloth button here")]
    [SerializeField]
    private GameObject _clothButton;
    public GameObject clothButton
    {
        get
        {
            return _clothButton;
        }
    }



}
