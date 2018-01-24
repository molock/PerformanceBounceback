using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public int score;

    private List<Score> scoreBoardList = new List<Score>();

    public void AddScore(int addScore)
    {
        score += addScore;
        UpdateScoreBoard();
    }

    public void AddScoreBoard(Score newScoreBoard)
    {
        scoreBoardList.Add(newScoreBoard);
    }

    private void UpdateScoreBoard()
    {
        foreach (var scoreBoard in scoreBoardList)
        {
            scoreBoard.ChangeScore(score);
        }

    }
}
