using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	public float movespeed;
	//public float turnspeed = 50f;
	private Vector3 Cube;

	void Start () { 
		gameObject.SetActive(true);
		Cube = Vector3.forward;
	}


	void Update () {
		if (Input.GetKey (KeyCode.UpArrow)) {
			movespeed = 10;
			transform.Translate (new Vector3 (0, 0, movespeed) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.DownArrow)) {
			movespeed = -10;
			transform.Translate (new Vector3 (0, 0, movespeed) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
			movespeed = -10;
			transform.Translate (new Vector3 (movespeed ,0, 0 ) * Time.deltaTime);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			movespeed = 10;
			transform.Translate (new Vector3 (movespeed ,0, 0 ) * Time.deltaTime);
	
		}
		//transform.Translate (Cube * movespeed * Time.deltaTime);
	}

}