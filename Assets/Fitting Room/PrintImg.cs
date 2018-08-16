using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class PrintImg : MonoBehaviour {

	private Texture2D texture;
	public GameObject iconSebelah, iconIni,iconCursor;
	private bool tunggu;
	private string alamat;
	public GameObject Resultimg,Logo;
    private float delay = 1.5f;


	public void CreatePhoto(){

        
		int resWidth = Screen.width;
		int resHeight = Screen.height;
		Texture2D snap = new Texture2D(Screen.width, Screen.height);

		snap.ReadPixels(new Rect(0, 0, resWidth, resHeight), 0, 0);
		snap.Apply();
		byte[] image = snap.EncodeToJPG();
		Destroy (snap);
		texture = snap;

		string sDir = Application.dataPath + "/Screenshots1";
		if (!Directory.Exists(sDir))
			Directory.CreateDirectory(sDir);


		string sFileName = sDir + "/" + string.Format("{0:F0}", Time.realtimeSinceStartup * 10f) + ".jpg";
		Debug.Log(sFileName);

		alamat = sFileName;


		File.WriteAllBytes(sFileName, image);
		Debug.Log ("Photo ini: " + sFileName);
        ////
		PrinterPlugin.print(texture,false,PrinterPlugin.PrintScaleMode.FILL_PAGE);

    }

	public IEnumerator OpenImage(){
		
		Resultimg.SetActive (true);
		WWW www = new WWW("file://" +alamat);
		yield return www;
		Resultimg.GetComponent<RawImage> ().texture = www.texture;
		yield return null;


	}
    public IEnumerator delayLogo() {

        yield return new WaitForSeconds(delay);
        Logo.SetActive(false);

    }
	public void PrintImage(){

        Logo.SetActive(true);
        StartCoroutine (CreatePhoto1 ());
        StartCoroutine(delayLogo());
		//StartCoroutine (OpenImage ());
	
	}

	public IEnumerator CreatePhoto1(){

		iconIni.SetActive (false);
		iconSebelah.SetActive (false);
		iconCursor.SetActive (false);
		yield return new WaitForEndOfFrame();
		CreatePhoto ();
		StartCoroutine (Aktifasi ());


	
	}

	public IEnumerator Aktifasi(){
	
		yield return new WaitForSeconds (2.0f);
		iconIni.SetActive (true);
		iconSebelah.SetActive (true);
		iconCursor.SetActive (true);
	}


}

//	public void NgePrint(){
//
//		WWW www = new WWW("file://" +alamat);
//		yield return www;
//	//	Resultimg.GetComponent<RawImage> ().texture = www.texture;
//	
//		PrinterPlugin.print(texture,true,PrinterPlugin.PrintScaleMode.FILL_PAGE);
//	}
//
//}
