// Keeps track of score and health.
// ends game if you die.

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public int health = 0;
    public int startingHealth = 3;

    public UIController ui;

    void Start(){ 
        health = startingHealth;
        ChangeHealth();
        ChangeHealth(1);
    }

    public void ChangeHealth(int amount = -1) {
        health += amount;
        ui.UpdateHealthUI(health);

        if(health <= 0) {
            // save the current score
            PlayerPrefs.SetInt("score", score);
            // load the "gameover" scene
            UnityEngine.SceneManagement.SceneManager.LoadScene("gameover");

            // game is over!
            // go to end screen
            // show score and button to go to main menu.
            // this could be a panel, we could set Time.timeScale to 0;
        }
    }

    public bool specialScoreIsActive = false;

    public void ChangeScore(int givenAmount = 1) {
        if(specialScoreIsActive) {
            score += givenAmount * 10;
        } else {
            score += givenAmount;
        }
        ui.UpdateScoreUI(score);
    }

    public void StartSpecial() {
        StartCoroutine(SpecialTimer());
    }

    // can we get the button to call this function?
    public IEnumerator SpecialTimer() {
        specialScoreIsActive = true;
        yield return new WaitForSeconds(5);
        specialScoreIsActive = false;
    }
}
