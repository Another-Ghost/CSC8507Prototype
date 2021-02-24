using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationalCylinder : MonoBehaviour
{
    [SerializeField] float speed = 10000f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Rotate(Vector3.up * Time.deltaTime * speed);
        GetComponent<Rigidbody>().AddTorque(new Vector3(1, 1, 1) * Time.deltaTime * speed);
    }
}
