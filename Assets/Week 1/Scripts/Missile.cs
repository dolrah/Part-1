using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float speed = 5f;
    void Update()
    {
        transform.Translate(1 * speed * Time.deltaTime, 0, 0);
    }
    
}
