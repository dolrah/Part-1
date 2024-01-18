using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrogMpve : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
        float speed = 3f;
    // Update is called once per frame
    void Update()
    {
        float sides = Input.GetAxis("Horizontal");
        float height = Input.GetAxis("Vertical");
        transform.Translate(0,height * speed * Time.deltaTime, 0);
        transform.Translate(sides * speed * Time.deltaTime, 0, 0);
    }
}
