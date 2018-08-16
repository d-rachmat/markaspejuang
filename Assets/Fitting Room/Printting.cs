using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Printting : MonoBehaviour {

    //public GameObject _reslut;
    public Texture2D _texture;

    public void print() {

      //  _result=GetComponentInChildren

        PrinterPlugin.print(_texture, false, PrinterPlugin.PrintScaleMode.FILL_PAGE);

    }
}
