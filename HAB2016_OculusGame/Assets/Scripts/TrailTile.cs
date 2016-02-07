using UnityEngine;
using System.Collections;

public class TrailTile : MonoBehaviour {
    private int type;

	// Use this fint or initialization
	void Start () {
        type = 0;

        // Invis
        //GetComponent<MeshRenderer>().enabled = false;

        // Non interactable
        GetComponent<BoxCollider>().isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public bool IsActive()
    {
        return type != 0;
    }

    public void InitType(int value)
    {
        type = value;

        if( type != 0 )
        {
            // Make visible
            GetComponent<MeshRenderer>().enabled = true;

            // Make interactable
            GetComponent<BoxCollider>().isTrigger = false;

            // TODO: Change material (custom material per player)
        }
    }
}
