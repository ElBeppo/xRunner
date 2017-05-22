using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActualizarGameOver : MonoBehaviour {

    public TextMesh total;
    public TextMesh HighScore;
    public Puntuacion puntuacion;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnEnable()
    {
        total.text = puntuacion.puntuacion.ToString();
        if (EstadoJuego.estadoJuego != null)
        {
            HighScore.text = EstadoJuego.estadoJuego.puntuacionMaxima.ToString();
        }
    }
}
