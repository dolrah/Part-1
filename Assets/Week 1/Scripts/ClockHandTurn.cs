using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockHandTurn : MonoBehaviour
{

    // add an f to make c# know that you want a float (useful when using decimiles) 
    //putting public makes it accesable from the unity screen, good for reusing scripts
    public float Speed = 360f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, -Speed * Time.deltaTime);
    }
}
