﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveCam : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}