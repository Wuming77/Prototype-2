using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddForceToBall : MonoBehaviour
{
    public float forceZ;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(0, 0, forceZ);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
