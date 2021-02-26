using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceWall : MonoBehaviour
{
    public float distance = 5f; //Distance that moves the object
    public float speed = 3f;
    private bool isForward = true; //If the movement is out
    public float forceMagnitude;
    private Vector3 startPos;
    private Rigidbody rb; //ref of Rigidbody

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
		if (isForward)
        {
            if (transform.position.x < startPos.x + distance)
            {
                //transform.position += Vector3.right * Time.deltaTime * speed;
                //rb.AddForce(Vector3.right*forceMagnitude*, ForceMode.Force);
                Vector3 force = new Vector3((startPos.x + distance), startPos.y, startPos.z) - transform.position;
                force = (force.magnitude > rb.drag) ? force : force.normalized * rb.drag;
                //rb.AddForce(forceMagnitude * (new Vector3((startPos.x + distance), startPos.y, startPos.z) - transform.position), ForceMode.Force);
                rb.AddForce(forceMagnitude * force, ForceMode.Force);
            }
            else
                isForward = false;
        }
        else
        {
            if (transform.position.x > startPos.x)
            {
                //rb.AddForce(-Vector3.right * forceMagnitude, ForceMode.Impulse);
                Vector3 force = startPos - transform.position;
                force = (force.magnitude > rb.drag) ? force : force.normalized * rb.drag;
                rb.AddForce(forceMagnitude * force, ForceMode.Force);
            }
            else
                isForward = true;
        }
    }
}
