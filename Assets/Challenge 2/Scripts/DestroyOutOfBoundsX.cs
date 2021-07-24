using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float topLimit = 35;
    private float bottomLimit = -35;

    private float leftLimit = -40;
    private float rightLimit = 30;

    // Update is called once per frame
    void Update()
    {
        // Destroy dogs if x position less than left limit
        if (transform.position.z > topLimit || transform.position.z < bottomLimit)
        {
            Destroy(gameObject);
        }
        // Destroy balls if y position is less than bottomLimit
        if (transform.position.x < leftLimit || transform.position.x > rightLimit)
        {
            Destroy(gameObject);
        }
        if (transform.position.y < -2)
        {
            Destroy(gameObject);
        }

    }
}
