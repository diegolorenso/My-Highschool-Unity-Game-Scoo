using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class BotScore : MonoBehaviour
{
    private int score;

    void Start()
    {
        score = 0;
    }

    void FixedUpdate()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickupC"))
        {
            other.gameObject.SetActive(false);
            score++;
        }
        else if (other.gameObject.CompareTag("PickupB"))
        {
            other.gameObject.SetActive(false);
            score += 5;
        }
        else if (other.gameObject.CompareTag("PickupA"))
        {
            other.gameObject.SetActive(false);
            score += 25;
        }

    }
}