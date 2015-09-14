using UnityEngine;
using System.Collections;

public class DoorTrigger : MonoBehaviour {

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Door");
        transform.Rotate(0,90,0,Space.World);
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
