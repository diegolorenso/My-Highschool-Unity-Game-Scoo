using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class WASD : MonoBehaviour
{


    public float currentSpeed = 0f;
    public float impulse;
    public float turnSpeed;
    public float maxSpeed;
    public float speedDecayRate;
    public bool gameStarted = false;

    public Vector2 currentSpot = new Vector2();

    public Scene scene;

    public Rigidbody2D rb2d;

    private bool w, a, s, d;

    public void Start()
    {
        rb2d.drag = speedDecayRate;
    }

    private void LateUpdate()
    {
        if (!gameStarted)
        {
            return;
        }
        WPressed();
        APressed();
        SPressed();
        DPressed();
        Move();
        DecaySpeed();


    }


    private void WPressed()
    {
        if (Input.GetKeyDown(KeyCode.W))
            w = true;
        if (Input.GetKeyUp(KeyCode.W))
            w = false;
    }
    private void SPressed()
    {
        if (Input.GetKeyDown(KeyCode.S))
            s = true;
        if (Input.GetKeyUp(KeyCode.S))
            s = false;
    }
    private void APressed()
    {
        if (Input.GetKeyDown(KeyCode.A))
            a = true;
        if (Input.GetKeyUp(KeyCode.A))
            a = false;
    }
    private void DPressed()
    {
        if (Input.GetKeyDown(KeyCode.D))
            d = true;
        if (Input.GetKeyUp(KeyCode.D))
            d = false;
    }
    private void Move()
    {
        if (currentSpeed < maxSpeed)
        {
            Vector2 up = new Vector2(0, 1);
            Vector2 right = new Vector2(1, 0);
            Vector2 delta = new Vector2(0, 0);

            if (w)
                delta += (up * impulse);
            if (s)
                delta += (up * impulse * -1);
            if (a)
                delta += (right * impulse * -1);
            if (d)
                delta += (right * impulse);
            rb2d.AddForce(delta);
        }
        turn();
       
    }
    private void turn()
    {
       
        transform.right = Vector2.Lerp(transform.right,rb2d.velocity,turnSpeed);

    }

    private void DecaySpeed()
    {
        if (currentSpeed > 0.05)
        {
            currentSpeed = rb2d.velocity.magnitude;
        }
        else currentSpeed = 0;
    }
    public void GameStarted()
    {
        gameStarted = true;
    }
}