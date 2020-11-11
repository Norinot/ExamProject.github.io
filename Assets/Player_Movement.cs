using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{
    // Start is called before the first frame update



    public float moveSpeed = 5f;
    public Rigidbody2D rb;

    Vector2 Movement;
    // Update is called once per frame
    void Update()
    {
        //Input
        Movement.x = Input.GetAxisRaw("Horizontal");
        Movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + Movement * moveSpeed * Time.fixedDeltaTime);
        //Physic here
        //Movement
    }
}
