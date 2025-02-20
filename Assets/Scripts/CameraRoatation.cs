using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRoatation : MonoBehaviour
{


    public float mouseSensivity = 300f;

    public Transform playerBody;

    public float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensivity * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -70f, 90f);

        //this is for vertical rotation
        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        //this is for horizontal rotation
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
