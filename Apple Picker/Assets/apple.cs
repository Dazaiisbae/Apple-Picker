using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class apple : MonoBehaviour
{
    public static float bottomY = -20f; // The y position at which the apple will be destroyed
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < bottomY)
        {
            Destroy(gameObject); // Destroy the apple if it falls below bottomY
            {
                Destroy(this.gameObject); // Destroy the apple if it falls below bottomY
            }
        }
    }
}
