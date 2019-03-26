using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Collision : MonoBehaviour
{
    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
            }

    void FixedUpdate()
    {

    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("PickupC"))
        {
            other.gameObject.SetActive(false);
        }
        else if (other.gameObject.CompareTag("PickupB"))
        {
            other.gameObject.SetActive(false);
                    }
        else if (other.gameObject.CompareTag("PickupA"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
