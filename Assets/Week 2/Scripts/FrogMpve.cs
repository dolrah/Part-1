using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMpve : MonoBehaviour
{
    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
    }
        float speed = 3f;
    // Update is called once per frame
    void Update()
    {
        animator.SetFloat("Speed", 0);
        float sides = Input.GetAxis("Horizontal");
        float height = Input.GetAxis("Vertical");

        if (sides != 0 || height != 0)
        {
            animator.SetFloat("Speed", 1);
            transform.Translate(0, height * speed * Time.deltaTime, 0);
            transform.Translate(sides * speed * Time.deltaTime, 0, 0);
        }

    }
}
