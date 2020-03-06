using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wave : MonoBehaviour
{
    public KnightScript[] Knights;
    public float TimeBetweenSpawn;
    private float timer = 0.0f;
    public int KnightsRemaining = 1;
    private int KnightCount = 0;

    // Start is called before the first frame update
    void Start()
    {
        KnightsRemaining = Knights.Length;
        Debug.Log($"Knights Remaining: {KnightsRemaining}");
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= TimeBetweenSpawn && KnightCount < Knights.Length)
        {
            timer = 0.0f;
            SpawnKnight();
        }
    }

    void SpawnKnight()
    {
        Instantiate(Knights[KnightCount]);
        KnightCount++;
    }

    public void DespawnKnight()
    {
        KnightsRemaining--;
    }
}