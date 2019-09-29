﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveOrb : MonoBehaviour
{

    public float horiVelocity = 0;
    //เก็บไว้ในเลน
    public int laneNum = 2;

    //ล็อคการควบคุม
    public string controlLocked = "n";
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(horiVelocity, 0, 1);

        if (SwipeManager.IsSwipingLeft() && laneNum > 1 && controlLocked == "n")
        {
            horiVelocity = -2;
            StartCoroutine(stopSlide());
            laneNum -= 1;
            controlLocked = "y";
        }
        if (SwipeManager.IsSwipingRight() && laneNum < 3 && controlLocked == "n")
        {
            horiVelocity = 2;
            StartCoroutine(stopSlide());
            laneNum += 1;
            controlLocked = "y";
        }
    }

    IEnumerator stopSlide()
    {
        yield return new WaitForSeconds(.5f);
        horiVelocity = 0;
        controlLocked = "n";
    }
}