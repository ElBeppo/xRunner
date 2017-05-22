using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puntuacion : MonoBehaviour {

	public int puntuacion = 	0;
    public TextMesh marcador;

	// Use this for initialization
	void Start () {
		NotificationCenter.DefaultCenter ().AddObserver (this, "IncrementarPuntos");
		NotificationCenter.DefaultCenter ().AddObserver (this, "PersonajeHaMuerto");

        ActualizarMarcador();
    }
	void PersonajeHaMuerto(Notification notificacion){
		if (puntuacion > EstadoJuego.estadoJuego.puntuacionMaxima) {
			EstadoJuego.estadoJuego.puntuacionMaxima = puntuacion;
			Debug.Log ("Puntuacion max. Superada! Nueva: " + EstadoJuego.estadoJuego.puntuacionMaxima);
			EstadoJuego.estadoJuego.Guardar ();
		} else {
			Debug.Log ("Puntuacion max. NO SUPERADA!! Maxima: " + EstadoJuego.estadoJuego.puntuacionMaxima);

		}
	}

	void IncrementarPuntos(Notification notificacion){
		int puntosAIncrementar = (int)notificacion.data;
		puntuacion += puntosAIncrementar;
        ActualizarMarcador();
	}

    void ActualizarMarcador()
    {
        marcador.text = puntuacion.ToString();
    }
	// Update is called once per frame
	void Update () {
		
	}
}
