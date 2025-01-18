using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Fail : MonoBehaviour
{
    public TextMeshProUGUI scoreTxt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = CollisionDetect.score.ToString();
    }
}
