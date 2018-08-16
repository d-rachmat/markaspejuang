using thelab.mvc;
using UnityEngine.EventSystems;

public class GameplayController : Controller<GameplayApps> {

    private ControllerAll _controllerAll;
    public ControllerAll controllerAll
    {
        get
        {
            return _controllerAll = Assert<ControllerAll>(_controllerAll);
        }   
    }

    private ControllerButton _controllerButton;
    public ControllerButton controllerButton
    {
        get
        {
            return _controllerButton = Assert<ControllerButton>(_controllerButton);
        }
    }

    private ControllerCamera _controllerCamera;
    public ControllerCamera controllerCamera
    {
        get
        {
            return _controllerCamera = Assert<ControllerCamera>(_controllerCamera);
        }
    }

    private ControllerGallery _controllerGallery;
    public ControllerGallery controllerGallery
    {
        get
        {
            return _controllerGallery = Assert<ControllerGallery>(_controllerGallery);
        }
    }

    private InteractionManager _interactionManager;
    public InteractionManager interactionManager
    {
        get
        {
            return _interactionManager = Assert<InteractionManager>(_interactionManager);
        }
    }

    private InteractionInputModule _interactionInputModule;
    public InteractionInputModule interactionInputModule
    {
        get
        {
            return _interactionInputModule = Assert<InteractionInputModule>(_interactionInputModule);
        }
    }

    private ControllerOverlay _controllerOverlay;
    public ControllerOverlay controllerOverlay
    {
        get
        {
            return _controllerOverlay = Assert<ControllerOverlay>(_controllerOverlay);
        }
    }

}
