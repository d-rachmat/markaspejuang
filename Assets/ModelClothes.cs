using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using thelab.mvc;

public class ModelClothes : Model<GameplayApps> {

    //Variable class
    private GameObject[] _listClothes;
    public GameObject[] listClothes
    {
        set; get;
    }

    private List<GameObject> _selModels;
    public List<GameObject> selModels
    {
        set; get;
    }

    private GameObject _selModel;
    public GameObject selModel
    {
        set; get;
    }

    //Variable general
    private float _verticalOffset;
    public float verticalOffset
    {
        set; get;
    }

    private float _forwardOffset;
    public float forwardOffset
    {
        set; get;
    }

    private string _modelCategory;
    public string modelCategory
    {
        set; get;
    }

    private int _playerIndex;
    public int playerIndex
    {
        set; get;
    }
}
