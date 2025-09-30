using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public AudioClip bounceSound;
    public float speed = 36.0f;
    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        transform.eulerAngles = new Vector3(0, 90, 0);
        rb = GetComponent<Rigidbody>();

        //create a random angle
        float angle = Random.value * 44 - 22; // -22 to 22 
                                              // (low - high) + low
        
        //Decide if it's going right or left
        if (Random.value > .5f)
        {
            angle += 180 ;
        }

        // Old Initial angle+direction
        // rb.velocity = new Vector3(-31.0f, 0f, -7.0f);

        //sets the ball's angle to randGen angle
        transform.eulerAngles += new Vector3(0, angle, 0);

        //gives the ball forward speed
        rb.velocity = transform.forward * speed;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.transform.CompareTag("Floor")) 
        {
            AudioSource.PlayClipAtPoint(bounceSound, transform.position, 1.0f);
        }
        
    }
}
