using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightScript : MonoBehaviour
{
    public int Health;
    public int Speed;
    public int Damage;

    public int CoinsGained;
    private GameManagerBehavior GameManagerBehavior;

    // Start is called before the first frame update
    void Start()
    {
        GameManagerBehavior = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Health < 1)
        {
            OnDeath();
        }
    }

    void OnDeath()
    {
        GameManagerBehavior.IncreaseCoin(CoinsGained);
        RemoveKnight();
    }

    public void ReachedEnd()
    {
        GameManagerBehavior.DecreaseHealth(Damage);
        RemoveKnight();
    }

    private void RemoveKnight()
    {
        Destroy(gameObject);
    }
}