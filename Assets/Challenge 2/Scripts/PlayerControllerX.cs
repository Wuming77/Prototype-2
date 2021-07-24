using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject[] dogPerfab;

    //public GameObject cube;

    // Update is called once per frame
    void Start()
    {
        //Instantiate(cube, new Vector3(-5.03f, -10.1f, -0.21f), transform.rotation);
    }
    void Update()
    {
        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space))
        {
            int dogIndex = Random.Range(0, dogPerfab.Length);
            Instantiate(dogPerfab[dogIndex], transform.position, transform.rotation);
        }
    }
}
