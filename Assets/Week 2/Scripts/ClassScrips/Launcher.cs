using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Launcher : MonoBehaviour
{

    public GameObject missilePrefab;
    public Transform Spawnpoint;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Instantiate(missilePrefab, Spawnpoint.position, Spawnpoint.rotation);
    }
}
