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

    void Update()
    {
        Vector2 moveDirection = GetComponent<Rigidbody2D>().velocity;
        if (moveDirection != Vector2.zero)
        {
            float angle = Mathf.Atan2(0, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }
    }

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
