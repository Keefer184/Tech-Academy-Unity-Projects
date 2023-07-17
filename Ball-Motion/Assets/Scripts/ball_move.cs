using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball_move : MonoBehaviour
{
    public float speed;
    private Rigidbody rigb;
    public Transform cam;

    // Start is called before the first frame update
    void Start()
    {
        rigb = GetComponent<Rigidbody>();    
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 camForward = cam.forward;
        Vector3 camRight = cam.right;

        camForward.y = 0;
        camRight.y = 0;

        float moveHoriz = Input.GetAxis("Horizontal");
        float moveVert = Input.GetAxis("Vertical");

        Vector3 forwardRelative = moveVert * camForward;
        Vector3 rigthRelative = moveHoriz * camRight;

        Vector3 moveDir = forwardRelative + rigthRelative;

        Vector3 movement = new Vector3(moveDir.x, 0.0f, moveDir.z);
        rigb.AddForce(movement * speed);
    }
}
