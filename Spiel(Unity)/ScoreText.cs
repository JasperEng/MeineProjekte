using TMPro;
using UnityEngine;

public class ScoreText : MonoBehaviour
{
    public PlayerController player;

    TextMeshProUGUI text;

    
    void Start()
    {
        text = GetComponent<TextMeshProUGUI>(); 
    }

    void Update()
    {
        text.text = player.GetScore().ToString();
    }
}
