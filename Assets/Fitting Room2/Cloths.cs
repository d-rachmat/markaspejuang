using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloths : MonoBehaviour {

    public GameObject baju1, baju2, baju3, baju4;
    public bool player1, player2, player3, player4;


    public void cloth1() {

        baju1.SetActive(true);
        baju2.SetActive(false);
        baju3.SetActive(false);
        baju4.SetActive(false);

    }

    public void cloth2() {

        baju1.SetActive(false);
        baju2.SetActive(true);
        baju3.SetActive(false);
        baju4.SetActive(false);

    }


    public void cloth3() {

        baju1.SetActive(false);
        baju2.SetActive(false);
        baju3.SetActive(true);
        baju4.SetActive(false);
    }

    public void cloth4() {

        baju1.SetActive(false);
        baju2.SetActive(false);
        baju3.SetActive(false);
        baju4.SetActive(true);
    }
}
