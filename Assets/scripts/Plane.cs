using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plane : MonoBehaviour
{
    public Lives lives;
  void OnTriggerEnter(){
      lives.Die();
  }
}
