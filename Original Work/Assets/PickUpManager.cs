using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpManager : MonoBehaviour
{
    public GameObject a;
    public GameObject b;
    public GameObject c;

    public Vector2 center;
    public Vector2 size;

    public int maxA;
    public int maxB;
    public int maxC;

    // public GameObject[] pickups = new GameObject[50];

    // Start is called before the first frame update

    void Start()
    {
        for (int x = 0; x < maxA; x++)
        {
            createPickup(a);
        }

        for (int x = 0; x < maxB; x++)
        {
            createPickup(b);

        }
        for (int x = 0; x < maxC; x++)
        {
            createPickup(c);
        }

    }

    // Update is called once per frame
    void Update()
    {
    }

    void createPickup(GameObject pickupType)
    {
        Vector2 pos = center + new Vector2(Random.Range(-size.x / 2, size.x / 2), Random.Range(-size.y / 2, size.y / 2));
        Instantiate(pickupType, pos, transform.rotation);
    }
}
