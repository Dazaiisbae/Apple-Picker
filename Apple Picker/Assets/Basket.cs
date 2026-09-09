using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Basket : MonoBehaviour
{
    public ScoreCounter scoreCounter; // Reference to the ScoreCounter script
    // Start is called before the first frame update
    void Start()
    {
        GameObject scoreGO = GameObject.Find("ScoreCounter"); // Find the ScoreCounter GameObject in the scene
        scoreCounter = scoreGO.GetComponent<ScoreCounter>(); // Get the ScoreCounter component from the GameObject
    }

    // Update is called once per frame
    void Update()
    {
        // get the current screen position of the mouse from Input
        Vector3 mousePos2D = Input.mousePosition;
        mousePos2D.z = -Camera.main.transform.position.z;
        Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
        Vector3 pos = this.transform.position;
        pos.x = mousePos3D.x;
        this.transform.position = pos;
    }

    void OnCollisionEnter(Collision collision)
    {
        //Find out what hit this basket
        GameObject collidedWith = collision.gameObject;
        if (collidedWith.tag == "Apple")
        {
            Destroy(collidedWith);  // Destroy the apple
            scoreCounter.score += 100;  
        }
    }
}
