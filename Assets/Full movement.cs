using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;           //Constant forward speed
    public float jumpForce = 10f;          //Jump force
    public Transform groundCheckPoint;     //A point to check if the player is grounded
    public float checkRadius = 0.2f;       //Radius of the overlap circle for ground detection
    public LayerMask groundLayer;          //Layer of the ground objects

    public AudioClip jump;
    AudioSource playerSFX;

    private Rigidbody2D rb;                //Reference to RigidBody component
    private bool isGrounded;               //Ground checker

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); //Get rigidbody attached to player
        playerSFX = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        //Constant forward movement
        rb.velocity = new Vector2(moveSpeed, rb.velocity.y);

        //Check if player is grounded
        isGrounded = Physics2D.OverlapCircle(groundCheckPoint.position, checkRadius, groundLayer);

        //Jumping logic
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void Jump()
    {
        playerSFX.PlayOneShot(jump);
        //Add an upward force for jumping
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnDrawGizmosSelected()
    {
        //Draw a circle to visualise the ground check point in the editor
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(groundCheckPoint.position, checkRadius);
    }

}
