using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    public Rigidbody rigid;
    public float initialVelocity = 600f;
    Vector3 initialPosition;
    bool inGame;
    public Transform bar;
    
   
    void Start()
    {
        initialPosition = transform.position;
    }

    public void Reset (){
        transform.position = initialPosition;
        transform.SetParent(bar);
        inGame = false;
        StopMovement();
    }

    public void StopMovement(){
        rigid.isKinematic = true;
        rigid.velocity = Vector3.zero;
    }

    
    void Update()
    {
        if(!inGame && Input.GetButtonDown("Fire1")){
            inGame = true;
            transform.SetParent(null);
            rigid.isKinematic = false;
            rigid.AddForce(new Vector3(initialVelocity, initialVelocity, 0));
        }
    }
}
