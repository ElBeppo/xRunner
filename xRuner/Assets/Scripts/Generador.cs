using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour {

	public GameObject[] obj;
    public Transform[] position;


    public float[] pos= new float[3] {-3.39f,-0.46f,2f};
	private int zein;
	public float tiempoMin = 0.5f;
	public float tiempoMax = 1.5f;
    private bool fin = false;
	//public Vector3 cosas;




	// Use this for initialization
	void Start () {
		//Generar ();
		NotificationCenter.DefaultCenter().AddObserver(this,"PersonajeEmpiezaACorrer");
        NotificationCenter.DefaultCenter().AddObserver(this, "PersonajeHaMuerto");

    }

    void PersonajeHaMuerto()
    {
        fin = true;
    }
    void PersonajeEmpiezaACorrer(Notification notificacion){
		Generar ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Generar(){


        zein = Random.Range (0, 3);
        //cosas.y = pos[zein];
        if (!fin)
        {
            Vector3 positionaltura = new Vector3(transform.position.x, pos[zein], 0);
            Instantiate(obj[Random.Range(0, obj.Length)], positionaltura, Quaternion.identity);
            Invoke("Generar", Random.Range(tiempoMin, tiempoMax));
        }

	}
}
