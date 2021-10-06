using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour
{
    public bool buttonIsBad = true;
    public bool original = false;

    private GameManager manager;
    private PlayAudio audioManager;
    private IconSplash iconManager;


    void Start(){
        manager = GameObject.Find("GameManager").GetComponent<GameManager>();
        audioManager = manager.gameObject.GetComponent<PlayAudio>();
        iconManager = manager.gameObject.GetComponent<IconSplash>();

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
            audioManager.PlayClip(soundType.Hurt);
            iconManager.ShowIcon(imageTypes.Hurt, this.transform.position);
        }
        else {
            // play good guy escaping sound
        }
        Destroy(this.gameObject);
    }

    public void Pressed() {
        if(buttonIsBad) {
            Debug.Log("We've destroyed a bad button.");
            audioManager.PlayClip(soundType.HitBadButton);
            iconManager.ShowIcon(imageTypes.HitBadButton, this.transform.position);
        } else {
            Debug.Log("Oh No! We've destroyed a good button.");
            audioManager.PlayClip(soundType.HitGoodButton);
            iconManager.ShowIcon(imageTypes.HitGoodButton, this.transform.position);
        }
        Destroy(this.gameObject);
    }

    
}
