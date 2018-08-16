using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using thelab.mvc;
using UnityEngine.UI;
using System.IO;
using System.Linq;

public class ControllerGallery : Controller<GameplayApps> {

    public void GalleryClicked()
    {
        switch (app.model.modelUI.galleryMenu.activeSelf)
        {
            case false:
                app.model.modelUI.galleryMenu.SetActive(true);
                StartCoroutine(LoadImageFromSceenShoots());
                break;
            case true:
               
                app.model.modelUI.galleryMenu.SetActive(false);
                break;
        }
        
    }
    private IEnumerator LoadImageFromSceenShoots()
    {
        #region Declaration
        DestroyAllPhoto();
        string sDirName = Application.dataPath + "/Screenshots";

        GameObject photoImage = null;
        WWW www = null;
        DirectoryInfo directoryInfo = new DirectoryInfo(sDirName);
        FileInfo[] fileInfo = directoryInfo.GetFiles();

        int totalPhoto = directoryInfo.GetFiles().Count(p => p.Extension != ".meta");
        #endregion

        #region Logic
        for (int i = 0; i < fileInfo.Length; i++)
        {
            if (!fileInfo[i].ToString().Contains(".meta"))
            {
                photoImage = (GameObject)Instantiate(app.model.modelPrefab.photoImage);
                photoImage.transform.SetParent(app.model.modelUI.gridImage.transform, false);
                
                www = new WWW("file://" + fileInfo[i].ToString());
                yield return www;
                photoImage.GetComponent<RawImage>().texture = www.texture;
                app.model.modelData.photoImages.Add(photoImage);
            }
        }
        #endregion
    }

    private void DestroyAllPhoto()
    {
        for (int i = 0; i < app.model.modelData.photoImages.Count; i++)
        {
            Destroy(app.model.modelData.photoImages[i]);
        }
        app.model.modelData.photoImages.Clear();
    }

    private void DestroySelectedPhoto(int i)
    {
        Destroy(app.model.modelData.photoImages[i]);
        app.model.modelData.photoImages.RemoveAt(i);
    }
    // Update is called once per frame
}
