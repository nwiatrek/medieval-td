﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapManager : MonoBehaviour
{
    public Transform[] Waypoints;
    public WaveManager WaveManager;
    // Start is called before the first frame update
    void Start()
    {
        WaveManager.StartWave();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



}
