using TMPro;
using UnityEngine;

public class CoinText : MonoBehaviour
{
    public PlayerController player;

    TextMeshProUGUI text;


    void Start()
    {
        text = GetComponent<TextMeshProUGUI>();
    }

    void Update()
    {
        text.text = "Coins: " + player.GetCoins().ToString();
    }
}
