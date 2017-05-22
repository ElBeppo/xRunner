using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public int puntosGanados = 5;
    public AudioClip itemSound;
    public float itemSoundVolume=1f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.tag=="Player")
        {
            NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
            AudioSource.PlayClipAtPoint(itemSound, Camera.main.transform.position, itemSoundVolume);
        }
        
        Destroy(gameObject);
    }
}
