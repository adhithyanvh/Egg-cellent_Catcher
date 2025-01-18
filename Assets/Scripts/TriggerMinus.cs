using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class TriggerMinus : MonoBehaviour
{
    AudioManager manager;


    public GameObject[] lifes;
    public static int life = -1;

    private void Awake()
    {
        manager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();

    }
    private void Start()
    {
        life = -1;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //int scoreHere = CollisionDetect.score;

        if (collision.CompareTag("GoodEgg"))
        {
            manager.PlaySfx(manager.miss);

            life++;
            lifes[life].gameObject.SetActive(false);
            CollisionDetect.score = CollisionDetect.score - 2;
            if(CollisionDetect.score <= 0)
            {
                CollisionDetect.score = 0;
            }
            Debug.Log("worked");
            Destroy(collision.gameObject);

            if(life >= 2)
            {
                SceneManager.LoadScene(2);
            }
        }

        if(life == -1)
        {
            lifes[0].gameObject.SetActive(true);
            lifes[1].gameObject.SetActive(true);
            lifes[2].gameObject.SetActive(true);

        }
    }
}
