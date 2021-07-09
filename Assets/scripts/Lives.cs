using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Lives : MonoBehaviour
{
    public static int lives = 5;
    public Text livesText;

    public Sphere sphere;
    public Bar bar;
    void Start()
    {
        RefreshLivesCounter();
    }
    void RefreshLivesCounter(){
        livesText.text = "Lives: " + Lives.lives;
    }

    public void Die(){
        Lives.lives--;
        RefreshLivesCounter();
        bar.Reset();
        sphere.Reset();
    }
    
}
