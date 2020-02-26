using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightScript : MonoBehaviour
{
    public GameObject[] PathNode;
    public int Health;
    public int Speed;
    public int Damage;

    public int CoinsGained;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        if(Health < 1)
        {
            OnDeath();
        }
        
            transform.position += transform.right * Time.deltaTime * Speed;
        
    }

    void OnDeath()
    {

    }
}
