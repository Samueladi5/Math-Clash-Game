using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 14f;
    public AnimationClip jumpStartClip;
    public AnimationClip slashingClip;
    public KeyCode interactionKey = KeyCode.Return;
    public float interactionRange = 2f;

    private Rigidbody2D rb;
    private Animator animator;
    private bool isWalking = false;
    private bool isJumping = false;
    private bool isAttacking = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
    }

    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");

        if (moveHorizontal < 0)
        {
            transform.localScale = new Vector3(-1, 1, 1);
            isWalking = true;
        }
        else if (moveHorizontal > 0)
        {
            transform.localScale = new Vector3(1, 1, 1);
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }

        Vector2 movement = new Vector2(moveHorizontal, 0);
        rb.velocity = movement * speed;

        // Check if the player is on the ground and the jump key is pressed
        if (Input.GetKeyDown(KeyCode.Space) && !isJumping)
        {
            isJumping = true;

            // Play the "Jump Start" animation clip
            animator.Play(jumpStartClip.name);

            // Add force to the rigidbody to make the player jump
            rb.AddForce(new Vector2(0, jumpForce), ForceMode2D.Impulse);
        }

        // Check if the attack key is pressed
        if (Input.GetKeyDown(interactionKey))
        {
            isAttacking = true;

            // Play the "Slashing" animation clip
            animator.Play(slashingClip.name);

            // Raycast forward from the player's position
            RaycastHit2D hit = Physics2D.Raycast(transform.position, transform.right, interactionRange);

            // Check if the raycast hits an enemy object
            if (hit.collider != null && hit.collider.CompareTag("Enemy"))
            {
                // Destroy the enemy GameObject
                Destroy(hit.collider.gameObject);
            }
        }

        // Check if the attack key is released
        if (Input.GetKeyUp(interactionKey))
        {
            isAttacking = false;
        }

        animator.SetBool("IsWalking", isWalking);
        animator.SetBool("IsAttacking", isAttacking);
    }

    // Check if the player has landed on the ground
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }
}
