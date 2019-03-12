using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{


    public Text scoreText;

    private int score;
    private Rigidbody2D rb2d;

    void Start()
    {
        score = 0;
        rb2d = GetComponent<Rigidbody2D>();
        SetScoreText();
    }

    void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVertical = Input.GetAxis("Vertical");
        //Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        //rb2d.AddForce(speed * movement);
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
        SetScoreText();
    }
    private void SetScoreText()
    {
        scoreText.text = "Score: " + score.ToString();
    }
}
