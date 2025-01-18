using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class UiThings : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public GameObject gameManual;
    public Button pausebtn, resumebtn;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
        pausebtn.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score : " + CollisionDetect.score.ToString();
    }

    public void Pause()
    {
        Time.timeScale = 0;
        pausebtn.gameObject.SetActive(false);
        resumebtn.gameObject.SetActive(true);
        gameManual.SetActive(true);
    }

    public void Resume()
    {
        Time.timeScale = 1;
        pausebtn.gameObject.SetActive(true);
        resumebtn.gameObject.SetActive(false);
        gameManual.SetActive(false);

    }
}
