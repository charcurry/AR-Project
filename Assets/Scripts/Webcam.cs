using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class Webcam : MonoBehaviour
{
    WebCamTexture webcamTexture;
    new Renderer renderer;

    // Start is called before the first frame update
    void Start()
    {
        webcamTexture = new WebCamTexture();
        renderer = GetComponent<Renderer>();
        renderer.material.mainTexture = webcamTexture;
        webcamTexture.Play();
    }

    // Update is called once per frame
    void Update()
    {

    }
}
