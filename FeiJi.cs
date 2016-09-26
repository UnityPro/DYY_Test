using UnityEngine;
using System.Collections;

public class FeiJi : MonoBehaviour {
	private GameObject Rotor;
	public float height;
	// Use this for initialization
	void Start () {
		Rotor = GameObject.FindGameObjectWithTag ("MyTag");
	}
	
	// Update is called once per frame
	void Update () {
	
		//this.transform.Translate (0,1*Time.deltaTime,0);
		//Rotor.GetComponent<Transform> ().Rotate (0,0,5);
		height= this.transform.position.y;
		Rotor.GetComponent<Transform> ().Rotate (0,0,10);
		if(height<5){
			this.transform.Translate (0,1*Time.deltaTime,0);

		}else if(height>=5){

			this.transform.Translate (1*Time.deltaTime,0,-3*Time.deltaTime);
		}


	}
}
