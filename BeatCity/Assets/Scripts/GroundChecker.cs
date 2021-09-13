using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    #region Variables

    public bool isGrounded;

    public float isGroundedSince;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundMask;

    #endregion

    public void VerifyIfGrounded()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundMask);

        PlayerMain.pm.ai.animator.SetBool("IsGrounded", isGrounded);
    }

    private void Update()
    {
        if(isGrounded)
        {
            isGroundedSince += Time.deltaTime;
        }
        else
        {
            isGroundedSince = 0f;
        }
    }
}
