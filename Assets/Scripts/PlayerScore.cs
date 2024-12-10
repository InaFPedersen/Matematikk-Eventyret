using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using TMPro;

public class PlayerScore : MonoBehaviour
{
    
    //Variables
    public TextMeshProUGUI scoreText;

    
    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = "" + ScoreTracker.currentScore;
    }

   public void AddPointsLett()
    {
        ScoreTracker.currentScore += 2;
        scoreText.text = "" + ScoreTracker.currentScore;
    }

    public void AddPointsMedium()
    {
        ScoreTracker.currentScore += 5;
        scoreText.text = "" + ScoreTracker.currentScore;
    }

    public void AddPointsHard()
    {
        ScoreTracker.currentScore += 10;
        scoreText.text = "" + ScoreTracker.currentScore;
    }

    
}


