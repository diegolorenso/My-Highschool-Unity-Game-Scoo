using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isAlive = true;
    public int health = 100;
    public string playerName;

    // Start is called before the first frame update
    void Start()
    {
        GameManager.instance.players.Add(this);
    }

    // Update is called once per frame
    void Update()
    {
        if (!isAlive)
        {
            //play sad music lol
        }
    }
}
