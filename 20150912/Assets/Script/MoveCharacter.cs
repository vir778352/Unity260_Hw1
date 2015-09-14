using UnityEngine;
using System.Collections;

public class MoveCharacter : MonoBehaviour {
    CharacterController controller;
    public float speed = 3.0f;

	// Use this for initialization
	void Start () {
        controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update () {
        //if (Input.GetKey(KeyCode.B)) {
            controller.Move(new Vector3(-speed * Time.deltaTime, 0, 0));
        //}
	}
}
