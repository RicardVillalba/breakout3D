using System.Collections;
using UnityEngine;

public class Bar : MonoBehaviour
{
    public float velocity = 10f;
    Vector3 initialPosition;
  
    void Start()
    {
        initialPosition = transform.position;
    }

    public void Reset (){
        transform.position = initialPosition;
    }
    
    void Update()
    {
        float horizontalKeyboard = Input.GetAxis("Horizontal");
        float posX = transform.position.x+(horizontalKeyboard*velocity*Time.deltaTime);
        transform.position = new Vector3(Mathf.Clamp(posX, -8, 8), transform.position.y, transform.position.z);
    }
}
