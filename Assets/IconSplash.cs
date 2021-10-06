// displays icons or text or whatever
// for player feedback

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum imageTypes {Hurt, HitBadButton, HitGoodButton, Miss};

public class IconSplash : MonoBehaviour
{
    public GameObject[] icons;      // put your icons in here!
    public Transform canvas;

    // parameters: What icon to show, and where on the screen to show it
    public void ShowIcon(imageTypes type, Vector3 location) {
        Debug.Log("showing a sprite at " + location);
        GameObject icon = Instantiate(icons[(int)type], location, Quaternion.identity);
        Debug.LogError("Showing Icon! Go find it.", icon);
        icon.transform.SetParent(canvas);
        icon.transform.localScale += Vector3.one * Random.Range(10f,20f);
        icon.transform.Rotate(0,0,Random.Range(-15f,15f));
        Destroy(icon, 0.5f);
    }
}
