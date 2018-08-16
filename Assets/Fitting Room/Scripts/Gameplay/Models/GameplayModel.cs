using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using thelab.mvc;

public class GameplayModel : Model<GameplayApps> {

    
    private ModelData _modelData;
    public ModelData modelData
    {
        get
        {
            return _modelData = Assert<ModelData>(_modelData);
        }
    }

    private ModelUI _modelUI;
    public ModelUI modelUI
    {
        get
        {
            return _modelUI = Assert<ModelUI>(_modelUI);
        }
    }

    private ModelTexture _modelTexture;
    public ModelTexture modelTexture
    {
        get
        {
            return _modelTexture = Assert<ModelTexture>(_modelTexture);
        }
    }

    private ModelClothes _modelClothes;
    public ModelClothes modelClothes
    {
        get {
            return _modelClothes = Assert<ModelClothes>(_modelClothes);
        }
    }

    private ModelButton _modelButton;
    public ModelButton modelButton
    {
        get
        {
            return _modelButton = Assert<ModelButton>(_modelButton);
        }
    }

    private ModelPrefab _modelPrefab;
    public ModelPrefab modelPrefab
    {
        get
        {
            return _modelPrefab = Assert<ModelPrefab>(_modelPrefab);
        }
    }
}
