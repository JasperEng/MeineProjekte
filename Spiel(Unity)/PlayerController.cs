using UnityEngine;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;

public class PlayerController : MonoBehaviour
{
    public GameOvermenu gameOvermenu;

    public LevelGenerator levelGenerator;

    int score = 0;

    int coins = 0;

    bool alive = true;

    private void Start()
    {
        Time.timeScale = 1;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Coin")
        {
            coins++;
            Destroy(other.gameObject);
            
        }
    }

    void Update()
    {
        int newScore = Mathf.RoundToInt(transform.position.z);
        if (newScore > score)
        {
            score = newScore;
        }

        if (transform.position.y < levelGenerator.GetPlatformY() -30 && alive)
        {
            Destroy(GetComponent<FirstPersonController>());
            gameOvermenu.Show();
            Time.timeScale = 0;
            alive = false;
        }
    }

    public int GetScore()
    {
        return score;
    }

    public int GetCoins()
    {
        return coins;
    }
}
