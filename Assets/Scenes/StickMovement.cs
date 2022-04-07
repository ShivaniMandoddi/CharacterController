using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StickMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody rb;
    float sensitivity = 300.0f;
    public Transform pointposition;

    [Header("Axis (Use One)")]
    public bool x;
    public bool y;
    public bool z;

    private Vector3 lastPos;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Vector3 dir = pointposition.position;
            //dir.Normalize();
            //rb.AddForce(Vector3.right * 40f);
            rb.AddRelativeForce(Vector3.right*800f);
            //rb.AddForce(Vector3.right*10f,ForceMode.Impulse);
        }
        
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.M))
        {
            // rb.AddTorque(transform.up * 20f);\
            transform.Rotate(0f, 2f, 0f);
        }
    }
    void OnMouseDown()
    {
        lastPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);
    }
    void OnMouseDrag()
    {
        /* Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition);


         if (y)
         {
             transform.Rotate(0, (pos.y - lastPos.y) *200f, 0);
         }

         lastPos = pos;*/
        //rb.AddTorque(Vector3.up * 40f);
       // rb.AddTorque(transform.up * 4f);
       

    }
    private void OnMouseUp()
    {
       // rb.AddForce(Vector3.right * 20f);
    }
    
}
