using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonJugar : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	

    void OnMouseDown()
    {
        Camera.main.GetComponent<AudioSource>().Stop();
        GetComponent<AudioSource>().Play();
        Invoke("CargarNivelJuego", GetComponent<AudioSource>().clip.length);
    }
    void CargarNivelJuego()
    {
        SceneManager.LoadScene("GameScene");
    }

}
