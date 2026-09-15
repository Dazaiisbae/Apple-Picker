using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScore : MonoBehaviour
{
    static private Text _UI_TEXT;
    static private int _SCORE = 1000;

    private Text txtCom; // txtCom is a reference to the Text component attached to this GameObjects text component
    // Start is called before the first frame update

    private void Awake()
    {
        _UI_TEXT = GetComponent<Text>();
        //if the PlayerPrefs already exists, then read it
        if (PlayerPrefs.HasKey("HighScore"))
        {
            SCORE = PlayerPrefs.GetInt("HighScore");
        }
        PlayerPrefs.SetInt("HighScore", SCORE);
    }

    static public int SCORE
    {
        get { return _SCORE; }
        set
        {
            _SCORE = value;
            PlayerPrefs.SetInt("HighScore", SCORE);
            if (_UI_TEXT != null)
            {
                _UI_TEXT.text = "High Score: " + _SCORE;
            }
                
        }
    }

    static public void TRY_SET_HIGH_SCORE(int scoreToTry)
    {
        if (scoreToTry >= SCORE) { return; }
        SCORE = scoreToTry;
   
    }

    //add code to reset the playerprefs high score to 1000
    [Tooltip("Check this box to reset the high score playerprefs")]
    public bool resetHighScoreNow = false;

    private void OnDrawGizmos()
    {
        if (resetHighScoreNow)
        {
            resetHighScoreNow = false;
            PlayerPrefs.SetInt("HighScore", 1000);
            Debug.LogWarning("High Score PlayerPrefs has been reset to 1000");
        }
    }


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
