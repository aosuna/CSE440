using UnityEngine;
using System.Collections;

public class SpriteController : MonoBehaviour {

    public float moveSpeed;
    private Vector3 moveDirection;
    public float turnSpeed;
    private Transform spawnPoint;
	// Use this for initialization
	void Start () {
        //spawnPoint = GameObject.Find("SpawnPoint").transform;
	
	}

   /* void OnBecomInvisible()
    {
        if (Camera.main == null)
        {
            return;
        }
        float yMax = Camera.main.orthographicSize - 0.5f;
        transform.position = new Vector3(spawnPoint.position.x, Random.Range(-yMax, yMax), transform.position.z);

    }*/
	
	// Update is called once per frame
	void Update () {
        //Vector3 currentPosition = transform.position;

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += new Vector3(moveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.position -= new Vector3(moveSpeed * Time.deltaTime, 0.0f, 0.0f);
        }

        EnforceBounds();
	
	}

    private void EnforceBounds()
    {
        Vector3 newPosition = transform.position;
        Camera mainCamera = Camera.main;
        Vector3 cameraPosition = mainCamera.transform.position;

        float xDist = mainCamera.aspect * mainCamera.orthographicSize;
        float xMax = cameraPosition.x + xDist;
        float xMin = cameraPosition.x - xDist;

        if (newPosition.x < xMin || newPosition.x > xMax)
        {
            newPosition.x = Mathf.Clamp(newPosition.x, xMin, xMax);
            moveDirection.x = -moveDirection.x;

            transform.position = newPosition;
        }
    }
}
