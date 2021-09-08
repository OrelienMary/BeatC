using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceApplier : MonoBehaviour
{
    //Toutes les forces appliquées au joueur ce font dans ce script. Il s'occupe également des paramètres de la gravité (certains comme le poids se gère toujours dans le Component Rigibody)

    #region Variables

    public Rigidbody rb;

    public float gravityValue;

    public float moveSpeed;
    public float jumpForce;

    #endregion

    void FixedUpdate()
    {
        if(PlayerMain.pm.gc.isGrounded)
        {
            rb.velocity = PlayerMain.pm.il.direction * moveSpeed * Time.fixedDeltaTime;

            if (PlayerMain.pm.il.jumpInput)
                rb.AddForce(-Vector3.down * jumpForce, ForceMode.Impulse);
        }

        rb.AddForce(Vector3.down * gravityValue * Time.fixedDeltaTime, ForceMode.Acceleration);

        PlayerMain.pm.il.jumpInput = false;
    }
}
