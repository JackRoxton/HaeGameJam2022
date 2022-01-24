using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private Rigidbody2D rb;

    [SerializeField]
    float speed = 400;

    [SerializeField,Range(0,1000)]
    float jumpHeight = 400;
    //int lives?;

    void Start()
    {
        
    }

    void Update()
    {
        //Vector2 dir = Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        if(Input.GetKeyDown(KeyCode.D))
            rb.AddForce(Vector2.right * speed);

        if (Input.GetKeyDown(KeyCode.Q))
            rb.AddForce(Vector2.left * speed);

        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(Vector2.up * jumpHeight);

        
    }
}
