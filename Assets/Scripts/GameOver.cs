using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameOver : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    // Start is called before the first frame update
    void Start()
    {
        int finalScore = PlayerPrefs.GetInt("score");
        scoreText.text = "Final Score: " + finalScore;
    }

    
}
