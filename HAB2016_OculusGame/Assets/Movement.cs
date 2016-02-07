using UnityEngine;
using System.Collections;

public class Movement : MonoBehaviour {
	public float moveSpeed = 10f;
	public float turnSpeed = 50f;
	private Vector3 bikedir;
	// Use this for initialization

	void Start () {
		gameObject.SetActive (true);
		bikedir = Vector3.right;
	}

	// Update is called once per frame
	void Update () {
<<<<<<< Updated upstream
		if (Input.GetKey (KeyCode.UpArrow)) {
			bikedir = Vector3.;
		}
		//if(Input.GetKey(KeyCode.DownArrow)){
		//	bikedir = Vector3.down;
		//}
=======
>>>>>>> Stashed changes
		if (Input.GetKey (KeyCode.LeftArrow)) {
			bikedir = new Vector3(0,0,-1);
		}
		if (Input.GetKey (KeyCode.RightArrow)) {
			bikedir = new Vector3(0,0,1);
		}
		transform.Translate (bikedir * moveSpeed * Time.deltaTime);
	}
}

