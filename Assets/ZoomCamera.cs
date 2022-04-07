using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZoomCamera : MonoBehaviour
{
    // Start is called before the first frame update
    Camera cam;
    public float defaultView;
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        //float zoomInput = Input.GetAxis("ZoomView");
        if(Input.GetButton("ZoomView"))
        {
            cam.fieldOfView = 30f;
        }
        else
        {
            cam.fieldOfView = defaultView;
        }
        /*else if(zoomInput<0f)
        {
            cam.fieldOfView -= 1;
        }*/

    }
}
