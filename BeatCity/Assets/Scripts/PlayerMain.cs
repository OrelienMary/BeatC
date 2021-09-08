using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMain : MonoBehaviour
{
    // Regroupe tous les Component du joueur
    // Appeler ce script si on veut accèder à un script du joueur

    #region Variables

    public static PlayerMain pm;

    public ForceApplier fa;
    public InputListener il;
    public MouseLook ml;
    public GroundChecker gc;

    #endregion
    
    void Awake()
    {
        pm = this;
    }
}
