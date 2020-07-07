using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float speed;
    private Vector2 movement;
    
    public Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        speed = 10f;
    }

    private void getInput(){
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    private void move(){
        rigidBody.velocity = new Vector2(movement.x * speed, movement.y * speed);
    }

    // Update is called once per frame
    void Update()
    {
        getInput();
        move();
    }
}
