using System;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOvermenu : MonoBehaviour
{
    public PlayerController player;

    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI totalCoinsText;

    void Start()
    {
        gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Respawn();
        }
    }

    public void Show()
    {
        gameObject.gameObject.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;

        SetHighscoreText();
        SetTotalCointext();
    }

    private void SetTotalCointext()
    {
        int totalCoins = PlayerPrefs.GetInt("coins", 0);
        totalCoins += player.GetCoins();
        PlayerPrefs.SetInt("coins", totalCoins);
        PlayerPrefs.Save();

        totalCoinsText.text = "Total Coins: " + totalCoins;
    }

    private void SetHighscoreText()
    {
        int score = player.GetScore();
        int highscore = PlayerPrefs.GetInt("highscore");
        bool newHighscore = false;

        if (score > highscore)
        {
            highscore = score;
            PlayerPrefs.SetInt("highscore", highscore);
            PlayerPrefs.Save();
            newHighscore = true;
        }
        string message = "Highscore: " + highscore;

        if (newHighscore)
        {
            message += " NEW BEST!";
        }
        highScoreText.text = message;
    }

    public void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
