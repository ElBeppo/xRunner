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
			Debug.Break ();

		} else {	
			Destroy (colision.gameObject);
		}
	}
}
