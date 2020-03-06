using System.Collections;
using System.Collections.Generic;
using System.Data.Common;
using UnityEngine;
using UnityEngine.UI;

public class GameManagerBehavior : MonoBehaviour
{
    public Text HealthLabel;
    private int HealthAmount = 10;
    public Text CoinLabel;
    private int CoinAmount = 100;
    public Text WaveLabel;

    private WaveManager WaveManager;
    // Start is called before the first frame update
    void Start()
    {
        WaveManager = GameObject.Find("WaveManager").GetComponent<WaveManager>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthLabel.GetComponent<Text>().text = $"Health: {HealthAmount}";
        CoinLabel.GetComponent<Text>().text = $"Coin: {CoinAmount}";
        WaveLabel.GetComponent<Text>().text = $"Wave: {WaveManager.WaveCount}/{WaveManager.Waves.Length}";
    }

    public void DecreaseHealth(int damage)
    {
        HealthAmount -= damage;
    }

    public void IncreaseCoin(int coinGain)
    {
        CoinAmount += coinGain;
    }
}