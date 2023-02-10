using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed = 4.5f;
    public float JumpF = 5;
    private float horizInput;
    private float VerInput;
    private Rigidbody PlayerRB;
    void Start()
    {
        PlayerRB= GetComponent<Rigidbody>();
    }

  
    void Update()
    {
        // Player movement
        horizInput = Input.GetAxis("Horizontal");
        VerInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * Time.deltaTime * speed * VerInput);
        transform.Translate(Vector3.right * Time.deltaTime * speed * horizInput);

        // player jump
        if (Input.GetKeyDown(KeyCode.Space))
        {

            PlayerRB.AddForce(Vector3.up * JumpF, ForceMode.Impulse);
        }
    }
}
