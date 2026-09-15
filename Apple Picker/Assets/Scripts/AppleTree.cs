using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject applePrefab;
    //Speed at which the AppleTree moves left and right
    public float speed = 5f;

    //Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    //Chance that AppleTree will change directions
    public float changeDirChance = 0.002f;

    //Seconds between Apple Instantiations
    public float appleDropDelay = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //Start dropping apples
        Invoke("DropApple", 2f); // Call DropApple after a delay of 2 seconds
    }
    void DropApple()
    {
        GameObject apple = Instantiate<GameObject>(applePrefab);
        apple.transform.position = transform.position;
        Invoke("DropApple", 2f); // Call DropApple again after a delay 
    }
    // Update is called once per frame
    void Update()
    {
        //Basic movement logic
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //Changing direction
        if ( pos.x < -leftAndRightEdge)
        { 
            speed = Mathf.Abs(speed); // Move right
        }
        else if (pos.x > leftAndRightEdge)
        {
            speed = -Mathf.Abs(speed); // Move left 
        }
    }
    void fixedUpdate()
    {
        float chance = Random.value;
        if (chance < changeDirChance)
        {
            speed *= -1; // Change direction randomly
        }
    }
}
