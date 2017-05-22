using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivarGameOver : MonoBehaviour {

    public GameObject camaraGameOver;
    public AudioClip gameOverSound;

	// Use this for initialization
	void Start () {

        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");


    }

    void PersonajeHaMuerto(Notification notificacion)
    {
        GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().clip = gameOverSound;
        GetComponent<AudioSource>().loop = false;
        GetComponent<AudioSource>().Play();
        camaraGameOver.SetActive(true);
    }

    // Update is called once per frame
    void Update () {
		
	}
}
