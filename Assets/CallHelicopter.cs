using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CallHelicopter : MonoBehaviour
{
    // Start is called before the first frame update
    //AudioClip audioClip;
    public AudioSource audioSource;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Help"))
        {
            Debug.Log("Calling Helicopter");
            audioSource.Play();
        }
       
    }
}
