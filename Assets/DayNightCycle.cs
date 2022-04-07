using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightCycle : MonoBehaviour
{
    // Start is called before the first frame update
    float minPerSeconds = 60f;
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        // transform.Rotate(10f*Time.deltaTime, 0f, 0f);
        float angleTheFrame = (Time.deltaTime / 4) * minPerSeconds;
        transform.RotateAround(transform.position,Vector3.forward,angleTheFrame);
    }
}
