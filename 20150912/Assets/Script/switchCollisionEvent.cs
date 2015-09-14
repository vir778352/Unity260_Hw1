using UnityEngine;
using System.Collections;

public class switchCollisionEvent : MonoBehaviour {
    public MoveCharacter charactor;
    bool switchEnable = true;

    void OnCollisionEnter(Collision collision) {
        Debug.Log("Cube_collision");
        if (switchEnable) {
            charactor.enabled = true;
            switchEnable = false;
        }
    }
    
    // Use this for initialization
	void Start () {
        //charactor = new MoveCharacter();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
