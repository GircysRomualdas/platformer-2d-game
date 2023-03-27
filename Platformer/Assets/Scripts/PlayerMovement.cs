using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rigidbody2d;
    private Animator animator;
    private float dirX = 0f;
    private SpriteRenderer spriteRenderer;
    [SerializeField] private float moveSpeed = 7f;
    [SerializeField] private float jumpForce = 14f;

    // Start is called before the first frame update
    private void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    private void Update()
    {
        dirX = Input.GetAxisRaw("Horizontal");

        rigidbody2d.velocity = new Vector2(dirX * moveSpeed, rigidbody2d.velocity.y);

        if (Input.GetButtonDown("Jump"))
        {
            rigidbody2d.velocity = new Vector2(rigidbody2d.velocity.x, jumpForce);
        }

        UpdateAnimationState();
    }

    private void UpdateAnimationState()
    {
        if (dirX > 0f)
        {
            animator.SetBool("running", true);
            spriteRenderer.flipX = false;
        }
        else if (dirX < 0f)
        {
            animator.SetBool("running", true);
            spriteRenderer.flipX = true;
        }
        else
        {
            animator.SetBool("running", false);
        }
    }
}
