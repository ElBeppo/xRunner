using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloque : MonoBehaviour {

	private bool Colision= false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnCollisionEnter2D(Collision2D colision){
		if(!Colision && (colision.collider.gameObject.name=="PieIzquierdo" || colision.collider.gameObject.name=="PieDerecho")){
			Colision = true;
			NotificationCenter.DefaultCenter ().PostNotification (this, "IncrementarPuntos", 1);
			}

	}
}
