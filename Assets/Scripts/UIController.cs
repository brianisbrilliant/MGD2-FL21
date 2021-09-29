using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIController : MonoBehaviour
{
    public TextMeshProUGUI scoreText, healthText;

    // make the score show what it currently is.
    public void UpdateScoreUI(int currentScore) {
        scoreText.text = "Score: " + currentScore;
    }

    // make the health show what it currently is.
    public void UpdateHealthUI(int currentHealth) {
        healthText.text = "Health: " + currentHealth;
    }
}
