using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movment : MonoBehaviour
{
    //holds the movement values
    Vector2 movement;

    //needed to use rigidbody
    public Rigidbody2D rigidbody;

    //this is what makes the body actually move
    public float force = 149f;



    // Update is called once per frame
    void Update()
    {
        //gets the x and y values of the player
        movement.x = Input.GetAxis("Horizontal");
       movement.y= Input.GetAxis("Vertical");
          
    }

    private void FixedUpdate()
    {
        //moves the duck based on the players input
        rigidbody.AddForce(movement * force * Time.deltaTime);
    }
}
