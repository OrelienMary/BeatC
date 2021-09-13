using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BeatManager : MonoBehaviour
{
    //Controle le Beat générale du jeu 

    #region Variables

    public static BeatManager bm;

    public float beatInterval;

    public float timeMargin;

    public bool inBeat;

    public float beatTimer;

    public GameObject beatDisplay;

    #endregion

    // Start is called before the first frame update
    void Awake()
    {
        bm = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(beatTimer < beatInterval)
        {
            beatTimer += Time.deltaTime;
        }
        else
        {
            beatTimer = 0;
        }

        if (beatInterval - timeMargin <= Time.time % beatInterval || Time.time <= timeMargin)
        {
            inBeat = true;
        }
        else
        {
            inBeat = false;
        }

        beatDisplay.SetActive(inBeat);
    }
}
