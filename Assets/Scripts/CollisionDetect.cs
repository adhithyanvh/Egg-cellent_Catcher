using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CollisionDetect : MonoBehaviour
{
    public static int score;
    AudioManager manager;

    private void Awake()
    {
        manager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    private void Start()
    {
        score = 0;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.CompareTag("GoodEgg") )
        {
            manager.PlaySfx(manager.collect);
            score = score + 2;
            Debug.Log(score);
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("BadEgg") )
        {
            manager.PlaySfx(manager.wrongEgg);
            score = score - 2;
            if (score <= 0)
            {
                score = 0;
            }
        }

       
    }
}
