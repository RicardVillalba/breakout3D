using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quit : MonoBehaviour
{
    public bool quit;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape)){
            if(quit)
            {
                Debug.Log("quit");
                Application.Quit();
            } else
            {
                SceneManager.LoadScene("Portada");
            }
            
        }
    }
}
