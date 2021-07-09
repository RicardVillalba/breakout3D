using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
   public static int score = 0;
   public Text scoreText;

 
    void Start()
    {
        RefreshScoreCounter();
    }

    void RefreshScoreCounter(){
        scoreText.text = "Score: " + Score.score;
    }
    
    public void SumScore(){
        Score.score++;
        RefreshScoreCounter();
    }
}
