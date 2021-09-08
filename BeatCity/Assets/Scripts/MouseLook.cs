using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    #region Variables

    public Camera cam;

    public float mouseSensitivity;

    public float mouseX;
    public float mouseY;

    public float rotationX;
    public float rotationY;

    #endregion

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        rotationX += mouseX;
        rotationY -= mouseY;

        rotationY = Mathf.Clamp(rotationY, -80f, 80f);
        cam.transform.parent.localRotation = Quaternion.Euler(rotationY, rotationX, 0f);
        
        //transform.localRotation = Quaternion.Euler(0f, rotationX, 0f);
    }
}
