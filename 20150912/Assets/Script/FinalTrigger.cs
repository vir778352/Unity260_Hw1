using UnityEngine;
using System.Collections;

public class FinalTrigger : MonoBehaviour {
    public MoveCharacter charactor;
    //public GameObject GUIText;

    void OnTriggerEnter(Collider other) {
        Debug.Log("FinalTrigger");
        charactor.enabled = false;
    }

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
