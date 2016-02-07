using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {
    private int TARGET_FRAME_RATE = 90;

    void Awake()
    {
        Debug.Log(" hello! ");
        Application.targetFrameRate = TARGET_FRAME_RATE;
    }

	// Use this for initialization
	void Start () {
        Debug.Log("test");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
