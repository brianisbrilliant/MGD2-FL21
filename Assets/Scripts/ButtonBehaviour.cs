using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public bool buttonIsBad = true;
    public bool original = false;

    private GameManager manager;

    void Start(){
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        // delete after 2-3 seconds
        if(original == false) StartCoroutine(EndOfLife());
        
    }

    void Update() {
        // get larger
        this.transform.localScale += Vector3.one * Time.deltaTime;
    }

    IEnumerator EndOfLife() {
        yield return new WaitForSeconds(Random.Range(2f, 3f));
        // lose health if bad.
        if(buttonIsBad) {
            manager.ChangeHealth();
        }
        Destroy(this.gameObject);
    }

    public void Pressed() {
        if(buttonIsBad) {
            Debug.Log("We've destroyed a bad button.");
        } else {
            Debug.Log("Oh No! We've destroyed a good button.");
        }
        Destroy(this.gameObject);
    }

    
}
