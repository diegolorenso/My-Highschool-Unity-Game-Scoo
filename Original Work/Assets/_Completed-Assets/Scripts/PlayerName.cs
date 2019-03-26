using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerName : MonoBehaviour
{
    public Player player = null;
    public Vector3 offset = new Vector3();
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.position = player.transform.position + offset;    }
}
