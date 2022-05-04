using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class telep : MonoBehaviour
{

    private Vector3 targetPos1;
    private Vector3 targetPos2;


    // Start is called before the first frame update
    void Start()
    {

        transform.position = new Vector3(0.0f, 1.3f, 2.5f);
        targetPos1 = new Vector3(5.77f, 1.33f, -0.51f + 1);
        targetPos2 = new Vector3(2.0f, 1.33f, -4.0f + 1);


    }

    void Update()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
        print ("trigger");

        if (other.CompareTag("target1"))
        {
            print("yep");

            transform.position = targetPos1;
        }

        if (other.CompareTag("target2"))
        {
            print("yep2");

            transform.position = targetPos2;
        }
    }

}
