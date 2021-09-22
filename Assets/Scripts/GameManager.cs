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

    void Start(){ 
        health = startingHealth;
        ChangeHealth();
        ChangeHealth(1);
    }

    public void ChangeHealth(int amount = -1) {
        health += amount;
        if(health <= 0) {
            // game is over!
            // go to end screen
            // show score and button to go to main menu.
            // this could be a panel, we could set Time.timeScale to 0;
        }
    }

    public void ChangeScore(int givenAmount = 1) {
        score += givenAmount;
    }
}
