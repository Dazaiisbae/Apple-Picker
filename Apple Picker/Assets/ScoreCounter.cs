using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreCounter : MonoBehaviour
{
    [Header("Dynamic")]
    public int score = 0; // The player's score
    private Text uiText; // Reference to the Text component

    // Start is called before the first frame update
    void Start()
    {
        uiText = GetComponent<Text>(); // Get the Text component attached to this GameObject
    }

    // Update is called once per frame
    void Update()
    {
        uiText.text = score.ToString("#,0"); // Update the UI text with the current score
        
    }
}
