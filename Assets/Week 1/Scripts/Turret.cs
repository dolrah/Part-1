using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float speed = 15f;
    // Update is called once per frame
    void Update()
    {
        float direction = Input.GetAxis("Vertical");
        transform.Rotate(0,0, direction * speed * Time.deltaTime);
    }
}
