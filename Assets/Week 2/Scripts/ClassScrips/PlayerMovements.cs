using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    //good for topdown (stores both up and down values at once
    Vector2 direction;
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
        //gets the info for each direction
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }

    private void FixedUpdate()
    {
        rigidbody.AddForce(direction * force * Time.deltaTime);
    }
}
