using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using thelab.mvc;

public class ModelButton : Model<GameplayApps> {

    private Selectable _selectableClothes;
    public Selectable selectableClothes
    {
        set; get;
    }

    private ButtonView _viewClothes;
    public ButtonView viewClothes
    {
        set; get;
    }
}
