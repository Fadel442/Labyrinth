using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayManager : MonoBehaviour
{
    [SerializeField] GameObject finishedCanvas;
    [SerializeField] TMP_Text finishedText;
    [SerializeField] CustomEvent gameOverEvent;
    [SerializeField] CustomEvent playerWinEvent;
    [SerializeField] float timer = 100;
    [SerializeField] TMP_Text timerTxt;
    int coin = 100; //TODO
    float s;
    bool play = true;

    private void OnEnable() {
        gameOverEvent.OnInvoked.AddListener(GameOver);
        playerWinEvent.OnInvoked.AddListener(Win);
    }
    private void OnDisable() {
        gameOverEvent.OnInvoked.RemoveListener(GameOver);
        playerWinEvent.OnInvoked.RemoveListener(Win);
    }
    public void GameOver()
    {
        Time.timeScale = 0f;
        finishedText.text = "You Lose!";
        finishedCanvas.SetActive(true);
    }

    public void Win()
    {
        Time.timeScale = 0f;
        finishedText.text = "You Win!\nScore: " + GetScore();
        finishedCanvas.SetActive(true);
    }

    private int GetScore()
    {
        return coin * 10;
    }

    public void textTimer()
    {
        int Menit = Mathf.FloorToInt(timer / 60);
        int Detik = Mathf.FloorToInt(timer % 60);
        timerTxt.text = Menit.ToString("00") + ":" + Detik.ToString("00");

    }

    private void Update() {
        if (play)
        {
            s += Time.deltaTime;
            if (s >= 1)
            {
                timer--;
                s = 0;
            }
        }

        if (play && timer == 0)
        {
            GameOver();
            play = false;
            Time.timeScale = 0f;
        }

        textTimer();
    }
}
