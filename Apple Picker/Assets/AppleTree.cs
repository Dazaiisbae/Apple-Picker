using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleTree : MonoBehaviour
{
    [Header("Inscribed")]
    public GameObject applePrefab;
    //Speed at which the AppleTree moves left and right
    public float speed = 1f;

    //Distance where AppleTree turns around
    public float leftAndRightEdge = 10f;

    //Chance that AppleTree will change directions
    public float changeDirChance = 0.01f;

    //Seconds between Apple Instantiations
    public float appleDropDelay = 1f;
    // Start is called before the first frame update
    void Start()
    {
        //Start dropping apples
    }

    // Update is called once per frame
    void Update()
    {
        //Basic movement logic
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;
        transform.position = pos;

        //Changing direction
    }
}
