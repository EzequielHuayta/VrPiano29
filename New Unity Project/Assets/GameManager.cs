using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public int currentScore;

public int scorePerNote = 100;

public int miss = 0;
public int actualmiss = 1;
public static GameManager instance;
public Text scoreText;
public Text missText;
    // Start is called before the first frame update

    void Start()
    {
        instance=this;
    }
    public void NoteHit()
    {
        currentScore += scorePerNote;
        scoreText.text = "Score " + currentScore;
    }


    // Update is called once per frame
    public void NoteMissed()
    {
        miss += actualmiss;
        missText.text = "Miss " + miss;
    }
}
