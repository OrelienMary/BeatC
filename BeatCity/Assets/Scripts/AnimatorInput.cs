using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorInput : MonoBehaviour
{
    //S'occupe de toute la partie visuelle du squelette du personnage

    #region Variables

    public Animator animator;

    public float rotationSpeed;

    #endregion

    void Update()
    {
        if (PlayerMain.pm.il.direction != Vector3.zero)
        {
            animator.SetBool("Moving", true);

            animator.transform.forward = Vector3.RotateTowards(animator.transform.forward, PlayerMain.pm.il.direction, rotationSpeed * Time.deltaTime, 1f);
        }
        else
        {
            animator.SetBool("Moving", false);
        }
    }
}
