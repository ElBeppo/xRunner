using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destructor : MonoBehaviour {


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D colision){
		if (colision.tag == "Player") {
            NotificationCenter.DefaultCenter().PostNotification(this, "PersonajeHaMuerto");
            GameObject Personaje = GameObject.Find("Jugador");
            Personaje.SetActive(false);
        } else {	
			Destroy (colision.gameObject);
		}
	}
}
