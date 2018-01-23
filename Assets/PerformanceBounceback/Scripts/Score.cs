using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;

    public GameManager gameManager;

    // Update is called once per frame
    void Update()
    {

        text.text = "Score: " + gameManager.score.ToString();
    }
}
