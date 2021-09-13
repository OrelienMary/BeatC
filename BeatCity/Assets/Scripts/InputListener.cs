using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputListener : MonoBehaviour
{
    //Enregistrement des Inputs
    //Calcul également la direction du mouvement selon les inputs

    #region Variables

    public float xInputValue;
    public float zInputValue;

    public Vector3 inputVector;
    public Vector3 direction;

    public bool jumpInput;
    public bool runInput;

    #endregion

    void Update()
    {
        xInputValue = Input.GetAxis("Horizontal");
        zInputValue = Input.GetAxis("Vertical");

        inputVector = new Vector3(xInputValue, 0f, zInputValue);

        if(jumpInput == false)
            jumpInput = Input.GetButtonDown("Jump");

        if (runInput == false)
            runInput = Input.GetButtonDown("Run");

        direction = (PlayerMain.pm.ml.cam.transform.right.normalized * xInputValue + new Vector3(PlayerMain.pm.ml.cam.transform.forward.x, 0f, PlayerMain.pm.ml.cam.transform.forward.z).normalized * zInputValue).normalized;
    }
}
