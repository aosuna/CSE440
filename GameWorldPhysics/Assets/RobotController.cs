using UnityEngine;
using System.Collections;

public class RobotController : MonoBehaviour {

    public float moveSpeed;

    public float jumpHeight;
    public bool jumping = false;

    // Use this for initialization
    void Start () {
	
	}


    // Update is called once per frame
    void FixedUpdate () {

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0.0f, 0.0f);

        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (jumping == false)
            { 
                GetComponent<Rigidbody2D>().AddForce(Vector3.up * jumpHeight);
                jumping = true;
            }
        }
    }
    void OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.gameObject.tag == "Ground" )
        {
            jumping = false;
        }
    }
}
