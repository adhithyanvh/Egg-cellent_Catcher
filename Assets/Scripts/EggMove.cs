using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggMove: MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(10, 15);

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * Time.deltaTime * speed);
    }
}
