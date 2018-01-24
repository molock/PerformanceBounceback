using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text text;

    public GameManager gameManager;

    void Start()
    {
        gameManager.AddScoreBoard(this);
    }

    public void ChangeScore(int newScore)
    {
        text.text = "Score: " + newScore.ToString();
    }

}
