using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewGame : MonoBehaviour
{
    void Update()
    {
         if (Input.GetButtonDown("Fire1")){
             SceneManager.LoadScene("Level1");
        }
    }
}
