using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class Scenes : MonoBehaviour
{

   
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void HomeToGame()
    {
        SceneManager.LoadScene(1);
    }

    public void HomeButton()
    {
        SceneManager.LoadScene(0);
       
    }

    public void Restart()
    {
        SceneManager.LoadScene(1);
       
    }
}
