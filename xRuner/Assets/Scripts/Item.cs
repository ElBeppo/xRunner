﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    public int puntosGanados = 5;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D collision)
    {
        NotificationCenter.DefaultCenter().PostNotification(this, "IncrementarPuntos", puntosGanados);
        Destroy(gameObject);
    }
}
