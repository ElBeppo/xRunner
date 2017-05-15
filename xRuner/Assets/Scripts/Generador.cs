using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generador : MonoBehaviour {

	public GameObject[] obj;


	//public float[] pos= new float[3] {-3.39f,-0.46f,1.755685f};
	private int zein;
	public float tiempoMin = 1f;
	public float tiempoMax = 2f;
	//public Vector3 cosas;




	// Use this for initialization
	void Start () {
		Generar ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void Generar(){
		
		//zein = Random.Range (0, 3);
		//cosas.y = pos[zein];
		Instantiate (obj [Random.Range (0, obj.Length)], transform.position , Quaternion.identity);
		Invoke ("Generar", Random.Range (tiempoMin, tiempoMax));

	}
}
