using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    #region Variables

    public bool isGrounded;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundMask;

    #endregion

    void FixedUpdate()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundCheckRadius, groundMask);
    }
}
