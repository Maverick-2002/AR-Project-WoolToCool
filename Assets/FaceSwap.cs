using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;

public class FaceSwap : MonoBehaviour
{
    private ARFaceManager faceManager;
    public List<Material> facematerial = new List<Material>();
    private int facematerialindex;
    public AudioSource sheep;

    // Start is called before the first frame update
    void Start()
    {
        faceManager = GetComponent<ARFaceManager>();
    }

    public void SwitchFcae()
    {
        foreach (ARFace face in faceManager.trackables)
        {
            face.GetComponent<Renderer>().material = facematerial[facematerialindex];
        }
        facematerialindex++;
        sheep.Play();

        if (facematerialindex == facematerial.Count)
        {
            facematerialindex = 0;
        }

    }
    public void CaptureImage()
    {
        ScreenCapture.CaptureScreenshot("MyPic.png");
        Debug.Log("Capture");
    }

}
