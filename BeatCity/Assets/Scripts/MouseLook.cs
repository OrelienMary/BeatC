using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseLook : MonoBehaviour
{
    //Permet de controller la caméra autour du joueur avec la souris

    #region Variables

    public Camera cam;

    public float mouseSensitivity;

    public float mouseX;
    public float mouseY;

    public float rotationX;
    public float rotationY;

    #endregion

    private void Start()
    {
        Cursor.visible = false;

        Cursor.lockState = CursorLockMode.Locked;

        rotationX = 0;
        rotationY = 0;


    }

    void Update()
    {
        mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime;

        rotationX += mouseX;
        rotationY -= mouseY;

        rotationY = Mathf.Clamp(rotationY, -40f, 80f);
        cam.transform.parent.localRotation = Quaternion.Euler(rotationY, rotationX, 0f);
        
        //transform.localRotation = Quaternion.Euler(0f, rotationX, 0f);
    }
}
