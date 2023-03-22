using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleMovement : MonoBehaviour
{
    Rigidbody2D rb;
    float horizontal;
    [SerializeField] float movement = 20f;
    Vector3 startposition;
    
    void Awake() 
    {
      rb = GetComponent<Rigidbody2D>(); 
      startposition = transform.position; 
    }

    void Update() 
    {
      horizontal = Input.GetAxis("Horizontal");   
    }
    void FixedUpdate() 
    {
      rb.velocity = new Vector2(horizontal*movement*Time.deltaTime,0);    
    }

    public void ResetPaddle()
    {
      transform.position = startposition;
    }
    
}
