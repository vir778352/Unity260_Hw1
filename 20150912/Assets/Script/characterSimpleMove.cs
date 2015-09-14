using UnityEngine;
using System.Collections;

public class characterSimpleMove : MonoBehaviour {
    CharacterController controller;
    public float speed;

    // Use this for initialization
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 speed = new Vector3(0, 0, 0);
        if (controller.isGrounded) {
            if (Input.GetKey(KeyCode.A))
            {
                speed.x = 5.0f;
            }

        }
    }
}
