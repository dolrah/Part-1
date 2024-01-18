using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMpve : MonoBehaviour
{
    public Animator animator;
    public Rigidbody2D rigidbody;
    public float speed = 3f;
    public float JumpHeight = 5f;
    float direction;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //this allows my game to know when to change to the idle animitation
        animator.SetFloat("Speed", 0);
        direction = Input.GetAxis("Horizontal");
     
    }

    private void FixedUpdate()
    {
        if (direction != 0)
        {
            //changes the animation to the walking animation
            animator.SetFloat("Speed", 1);

            //makes the game walk / move
            transform.Translate(direction * speed * Time.deltaTime, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            animator.SetBool("Jump", true);
            transform.Translate(0, JumpHeight * Time.deltaTime, 0);
        }
    }
}
