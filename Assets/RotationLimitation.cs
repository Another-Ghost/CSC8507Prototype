using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationLimitation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float y = transform.localEulerAngles.y;
        if (y > 180.0)
        {
            y = y - 360;
        }

        if (y < 0)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 0.0f, transform.localEulerAngles.z);
            //transform.Rotate(new Vector3(transform.localEulerAngles.x, 0.0f, transform.localEulerAngles.z), Space.Self);
            //Quaternion q = Quaternion.Euler(transform.localEulerAngles.x, 0.0f, transform.localEulerAngles.z);
            //Quaternion.RotateTowards(transform.rotation, q, turnSpeed * Time.deltaTime);
        }
        else if(y > 90)
        {
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, 90.0f, transform.localEulerAngles.z);
            //transform.Rotate(new Vector3(transform.localEulerAngles.x, 90.0f, transform.localEulerAngles.z), Space.Self);
            //Quaternion q = Quaternion.Euler(transform.localEulerAngles.x, 90.0f, transform.localEulerAngles.z);
            //Quaternion.RotateTowards(transform.rotation, q, turnSpeed * Time.deltaTime);

            GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
