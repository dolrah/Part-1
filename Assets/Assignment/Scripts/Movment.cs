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

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal");
       movement.y= Input.GetAxis("Vertical");
          
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(movement * force * Time.deltaTime);
    }
}
