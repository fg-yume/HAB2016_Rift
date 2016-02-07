using UnityEngine;
using System.Collections;

public class LookAtMe : MonoBehaviour {
	public GameObject target;
	// Use this for initialization
	void Start () {
		gameObject.SetActive (true);
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt (target.transform);
	}
	}

