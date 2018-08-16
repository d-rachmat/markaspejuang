using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using thelab.mvc;

public class ModelPrefab : Model<GameplayApps> {

    [SerializeField]
    [Tooltip("Prefab Photo Image")]
    private GameObject _photoImage;
    public GameObject photoImage
    {
        get
        {
            return _photoImage;
        }
    }
}
