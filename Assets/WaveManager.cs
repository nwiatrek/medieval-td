using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public Wave[] Waves;

    public int WaveCount { get; private set; } = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // nathan said we need to do this cause electrons sell you essential oils 
        // and junk and you gotta be worried about it
        if(Waves[WaveCount].KnightsRemaining < 1)
        {
            Debug.Log($"Wave {WaveCount} - Knights Remaining {Waves[WaveCount].KnightsRemaining}");
            WaveCount++;
            StartWave();
        }
    }

    public void StartWave()
    {
        Debug.Log($"Starting wave {WaveCount}");
        Instantiate(Waves[WaveCount]);
    }
}