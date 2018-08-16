using UnityEngine;
using System.Collections;
using System;
using thelab.mvc;
//using Windows.Kinect;


public class ControllerOverlay : Controller<GameplayApps>
{
    [Tooltip("GUI-texture used to display the color camera feed on the scene background.")]
    public GUITexture backgroundImage;

    [Tooltip("Camera that will be used to overlay the 3D-objects over the background.")]
    public Camera foregroundCamera;

    [Tooltip("Index of the player, tracked by this component. 0 means the 1st player, 1 - the 2nd one, 2 - the 3rd one, etc.")]
    public int playerIndex = 0;

    [Tooltip("Kinect joint that is going to be overlayed.")]
    public KinectInterop.JointType trackedJoint = KinectInterop.JointType.HandRight;

    [Tooltip("Game object used to overlay the joint.")]
    public Transform overlayObject;

    [Tooltip("Smoothing factor used for joint rotation.")]
    public float smoothFactor = 10f;

    //public GUIText debugText;

    [NonSerialized]
    public Quaternion initialRotation = Quaternion.identity;
    private bool objFlipped = false;

    float newY = 0f;

    public void Start()
    {
        if (!foregroundCamera)
        {
            // by default - the main camera
            foregroundCamera = Camera.main;
        }

        if (overlayObject)
        {
            // always mirrored
            initialRotation = overlayObject.rotation; // Quaternion.Euler(new Vector3(0f, 180f, 0f));

            Vector3 vForward = foregroundCamera ? foregroundCamera.transform.forward : Vector3.forward;
            objFlipped = (Vector3.Dot(overlayObject.forward, vForward) < 0);

            overlayObject.rotation = Quaternion.identity;
        }
    }

    void Update()
    {
        KinectManager manager = KinectManager.Instance;

        if (manager && manager.IsInitialized() && foregroundCamera)
        {
            //backgroundImage.renderer.material.mainTexture = manager.GetUsersClrTex();
            if (backgroundImage && (backgroundImage.texture == null))
            {
                backgroundImage.texture = manager.GetUsersClrTex();
            }

            // get the background rectangle (use the portrait background, if available)
            Rect backgroundRect = foregroundCamera.pixelRect;
            PortraitBackground portraitBack = PortraitBackground.Instance;

            if (portraitBack && portraitBack.enabled)
            {
                backgroundRect = portraitBack.GetBackgroundRect();
            }

            // overlay the joint
            long userId = manager.GetUserIdByIndex(app.model.modelData.playerIndex);

            int iJointIndex = (int)trackedJoint;
            if (manager.IsJointTracked(userId, iJointIndex))
            {
                Vector3 posJoint = manager.GetJointPosColorOverlay(userId, iJointIndex, foregroundCamera, backgroundRect);

                if (posJoint != Vector3.zero)
                {
                    if (overlayObject)
                    {
                        newY = posJoint.y + 0.4f;
                        overlayObject.position = new Vector3(posJoint.x, newY, posJoint.z);

                        //Quaternion rotJoint = manager.GetJointOrientation(userId, iJointIndex, !objFlipped);
                        //rotJoint = initialRotation * rotJoint;

                        //overlayObject.rotation = Quaternion.Slerp(overlayObject.rotation, rotJoint, smoothFactor * Time.deltaTime);
                    }
                }
            }
            else
            {
                // make the overlay object invisible
                if (overlayObject && overlayObject.position.z > 0f)
                {
                    Vector3 posJoint = overlayObject.position;
                    posJoint.z = -10f;
                    overlayObject.position = posJoint;
                }
            }

        }
    }
}

