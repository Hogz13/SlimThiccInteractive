using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed;
    public Rigidbody2D rb;
    private Vector2 moveDirection;

    // Update is called once per frame 
    // Based on framerate
    void Update()
    {
        // Processing Inputs
        ProcessInputs();
    }

    // Gets called a set amount of times per update loop whcih amkes it very consistant
    void FixedUpdate()
    {
        // Physics Calculations
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Horizontal"); // Raw makes it so the input is either a 1 or 0 it can't be in between
        float moveY = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector2(moveX, moveY).normalized; // Normalized makes it so the 2 vectors can never be more than one so you can't vector (moving faster when diagonailly moving)
    }

    void Move()
    {
        // Calculates velocity
        rb.velocity = new Vector2(moveDirection.x * moveSpeed, moveDirection.y * moveSpeed);
    }

}
