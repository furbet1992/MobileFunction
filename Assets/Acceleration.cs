using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acceleration : MonoBehaviour
{

    public  Rigidbody rb;
    public bool isFlat = true;



    void Start()
    {
        rb.GetComponent<Rigidbody>(); 
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 tilt = Input.acceleration;

        if (isFlat)
        {
            tilt = Quaternion.Euler(90, 0, 0) * tilt; 
        }

        rb.AddForce(tilt);
    }
}
