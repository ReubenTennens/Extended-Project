using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public float clampY = -90f;
    public float clampZ = 90f;

    public Transform playerBody;

    float xRotation = 0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float mouseX = Input.GetAxis("RightStickVertical") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("RightStickHorizontal") * mouseSensitivity * Time.deltaTime;

        xRotation = -mouseY;
        xRotation = Mathf.Clamp(xRotation, clampY, clampZ);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
