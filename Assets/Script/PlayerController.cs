using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;

    public GameObject projectilePerfab;

    // Start is called before the first frame update
    void Start()
    {

    }
    void Update()
    {
        MoveRightOrLeft();
        MoveForwardOrBack();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePerfab, new Vector3(transform.position.x,
                2.5f, transform.position.z), projectilePerfab.transform.rotation);
        }
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
    void MoveRightOrLeft()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        if (transform.position.x <= -20 && horizontalInput > 0) //到达左边界只能向右移动
        {
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        }
        if (transform.position.x >= 20 && horizontalInput < 0)  //到达右边界只能向左移动
        {
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        }
        //horizontalInput = Input.GetAxis("Horizontal");
        if (transform.position.x < 20 && transform.position.x > -20)
        {
            transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        }       
    }
    void MoveForwardOrBack()
    {
        verticalInput = Input.GetAxis("Vertical");
        if (transform.position.z <= -7.4 && verticalInput > 0) //到达下边界只能向前移动
        {
            transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        }
        if (transform.position.z >= 20 && verticalInput < 0)  //到达上边界只能向后移动
        {
            transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        }
        //horizontalInput = Input.GetAxis("verticalInput");
        if (transform.position.z < 20 && transform.position.z > -7.4f)
        {
            transform.Translate(Vector3.forward * verticalInput * Time.deltaTime * speed);
        }
    }
}
