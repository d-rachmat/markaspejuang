using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using thelab.mvc;

public class ModelTexture : Model<GameplayApps> {

    [SerializeField]
    private Texture _beach;
    public Texture beach
    {
        get
        {
            return _beach;
        }
    }

    [SerializeField]
    private Texture _garden;
    public Texture garden
    {
        get
        {
            return _garden;
        }
    }

    [SerializeField]
    private Texture _kidRoom;
    public Texture kidRoom
    {
        get
        {
            return _kidRoom;
        }
    }

    [SerializeField]
    private Texture _livingRoom;
    public Texture livingRoom
    {
        get
        {
            return _livingRoom;
        }
    }
}
