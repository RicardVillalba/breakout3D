using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bloc : MonoBehaviour
{
public Score score;
void OnCollisionEnter(){
    Destroy(gameObject);
    score.SumScore();
}
}
