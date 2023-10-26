using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        // Destroy the current game object (this)
        Destroy(gameObject);
        // Destroy the other game object that triggered the collision
        Destroy(other.gameObject);
    }
}
