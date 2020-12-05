using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    public Vector2 speed = new Vector2(5, 0);
    private Vector2 movement;
    public Vector2 direction = new Vector2(-1, 0);
 
    // Update is called once per frame
    void Update()
    {
        movement = new Vector2(speed.x * direction.x, 0);
    }

     void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = movement;   
    }
}
