using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayManager : MonoBehaviour
{
    [SerializeField] GameObject finishedCanvas;
    [SerializeField] TMP_Text finishedText;
    int coin = 100; //TODO
    public void GameOver()
    {
        finishedText.text = "You Lose!";
        finishedCanvas.SetActive(true);
    }

    public void Win()
    {
        finishedText.text = "You Win!\nScore: " + GetScore();
        finishedCanvas.SetActive(true);
    }

    private int GetScore()
    {
        return coin * 10;
    }
}
