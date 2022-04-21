using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        Vector3 newrotation = transform.localEulerAngles;
        newrotation.x -= Input.GetAxis("Mouse Y");
        transform.localEulerAngles = newrotation;
    }
}
