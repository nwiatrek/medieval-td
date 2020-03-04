using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveManager : MonoBehaviour
{
    public Wave[] Waves;
    private int WaveCount = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StartWave()
    {
        Instantiate(Waves[WaveCount]);
        WaveCount++;
    }

}
