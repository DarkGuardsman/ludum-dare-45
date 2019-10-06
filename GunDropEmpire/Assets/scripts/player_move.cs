using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_move : MonoBehaviour {

	public float speed;

    private Rigidbody2D rb2d;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D> ();
    }

    void FixedUpdate()
    {
        //Get input from user
        float moveHorizontal = Input.GetAxis ("Horizontal");
        float moveVertical = Input.GetAxis ("Vertical");
        
        //Calc move
        Vector2 movement = new Vector2 (moveHorizontal, moveVertical);
        
        //Apply move force
        rb2d.AddForce (movement * speed);
    }
}
