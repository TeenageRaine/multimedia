using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update

    private float speed = 6.0f;
    public GameObject character;
    private Rigidbody rb;

    public LayerMask groundLayers;

    public float jumpForce = 7;
    float distToGround;
    public BoxCollider col;

    private AudioSource source;


    void Start()
    {
        source = GetComponent<AudioSource>();
        rb = GetComponent<Rigidbody>();
        col = GetComponent<BoxCollider>();

        distToGround = GetComponent<Collider>().bounds.extents.y;

    }

    // Update is called once per frame
    void Update()
    {
        		if (Input.GetKey(KeyCode.D)){
			transform.position += Vector3.right * speed * Time.deltaTime;
           
		}
		if (Input.GetKey(KeyCode.A)){
			transform.position += Vector3.left* speed * Time.deltaTime;
            
		}
		if (Input.GetKey(KeyCode.W)){
			transform.position += Vector3.forward * speed * Time.deltaTime;
            
		}
		if (Input.GetKey(KeyCode.S)){
			transform.position += Vector3.back* speed * Time.deltaTime;
            
		}
        if (Input.GetKeyDown(KeyCode.Space)   &&   isGrounded() )
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            source.Play();
        }
        
    }

    private bool isGrounded()
    {
       return Physics.Raycast(transform.position, -Vector3.up, distToGround + 0.1f);
        
    }
}
