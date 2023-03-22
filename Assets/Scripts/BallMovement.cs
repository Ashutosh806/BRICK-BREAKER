using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    Rigidbody2D rb;
    [SerializeField] float speed = 100f;


    void Awake() 
    {
      rb = GetComponent<Rigidbody2D>();    
    }

    void Start() 
    {
      ResetBall();                
    }

    public void ResetBall()
    {
       rb.velocity = Vector2.zero;
       transform.position = Vector3.zero;
       Invoke(nameof(SetTrajectory),1f);
    }

    void SetTrajectory()
    {
        Vector2 force = new Vector2();
        force.x = Random.Range(-0.5f,0.5f);
        force.y = -1f;
        rb.AddForce(force.normalized*speed);
    }

    void FixedUpdate() 
    {
      rb.velocity = rb.velocity.normalized * speed;    
    }    
}
