using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move1 : MonoBehaviour
{
    public float speed = 5f;    
    public float jumpForce = 10f;    
    private Rigidbody2D rb;
    public Vector2 moveVector;
    public Animator anim;
    public bool onGround = false;
    public Transform GroundCheck;
    public float checkRadius = 0.5f;
    public LayerMask Ground;

    public float climbSpeed = 3f;
    private bool isOnLadder = false;


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        CheckingGround();
        //CheckForLadder();
        //if (isOnLadder)
        //{
        //    float verticalInput = Input.GetAxis("Vertical");
        //    ClimbLadder(verticalInput);
        //}
        Move();
        Jump();
    }

    void Move()
    {
        moveVector.x = Input.GetAxis("Horizontal");
        anim.SetFloat("moveX", Mathf.Abs(moveVector.x));

        float horizontal = Input.GetAxis("Horizontal");
        Vector2 movement = new Vector2(horizontal, 0f);
        rb.velocity = new Vector2(movement.x * speed, rb.velocity.y);

        if (movement.x > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        else if (movement.x < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    void Jump()
    {
        if (Input.GetButtonDown("Jump") && onGround) 
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
        }
    }

    void CheckingGround()
    {
        onGround = Physics2D.OverlapCircle(GroundCheck.position, checkRadius, Ground);
        anim.SetBool("onGround", onGround);
    }

    void CheckForLadder()
    {   
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.up, 1, LayerMask.GetMask("Ladder"));
        isOnLadder = hit.collider != null;
    }

    void ClimbLadder(float input)
    {
        float climbY = input * climbSpeed * Time.deltaTime;
        rb.velocity = new Vector2(0, climbY);

        if (onGround && Input.GetButtonDown("Jump")) 
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            isOnLadder = false;
        }
    }
}
