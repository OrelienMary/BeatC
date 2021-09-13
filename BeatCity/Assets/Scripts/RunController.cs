using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunController : MonoBehaviour
{
    float baseMovementXMultiplier;

    public float movementXMultiplier;
    public float runYForce;


    void Start()
    {
        baseMovementXMultiplier = movementXMultiplier;
    }

    void Update()
    {
        PlayerMain.pm.gc.VerifyIfGrounded();

        if (PlayerMain.pm.gc.isGroundedSince >= 0.1f)
        {
            movementXMultiplier = 1;
        }

        if (PlayerMain.pm.il.runInput == true)
        {
            movementXMultiplier = baseMovementXMultiplier;

            PlayerMain.pm.fa.rb.velocity = PlayerMain.pm.il.direction * PlayerMain.pm.fa.moveSpeed * movementXMultiplier * Time.fixedDeltaTime;

            PlayerMain.pm.fa.rb.AddForce(new Vector3(0f, runYForce, 0f), ForceMode.Impulse);

            PlayerMain.pm.gc.isGroundedSince = 0f;
        }

        PlayerMain.pm.il.runInput = false;
    }
}
