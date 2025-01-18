using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float horizontal;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontal * Time.deltaTime * speed);

        if(transform.position.x < -7.5)
        {
            transform.position = new Vector3(-7.5f,transform.position.y,transform.position.z);
        }
        if(transform.position.x > 7.5)
        {
            transform.position = new Vector3(7.5f, transform.position.y, transform.position.z);

        }

    }
}
