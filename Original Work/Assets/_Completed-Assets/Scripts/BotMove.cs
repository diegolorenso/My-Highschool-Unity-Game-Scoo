using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotMove : MonoBehaviour
{ 
public GameObject player;
    public float moveSpeed = 0.004f;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Vector2.Lerp(transform.position, player.transform.position, moveSpeed);

        Vector3 difference = player.transform.position - transform.position;
        difference.Normalize();
        float rotation_z = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg + 90;
        transform.rotation = Quaternion.Euler(0f, 0.0f, rotation_z);
    }
}
//transform.position = Vector2.Lerp(transform.position, player.transform.position, moveSpeed);

//        Vector3 difference = player.transform.position - transform.position;
//difference.Normalize();

        //if((Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg + 90)>0){
        //    transform.Rotate(Vector2.left* turnSpeed * Time.deltaTime);
        //} else{
            //transform.Rotate(Vector2.right* turnSpeed * Time.deltaTime);