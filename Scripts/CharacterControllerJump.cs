using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterControllerJump : MonoBehaviour
{
    Rigidbody2D rb2D;
    SpriteRenderer spriteRenderer;
    Animator animator;
    public float speed = 5f;
    public float jumpForce = 2f;
    bool isOnGround;

    // Start is called before the first frame update
    void Start()
    {
        rb2D = this.GetComponent<Rigidbody2D>();
        spriteRenderer = this.GetComponent<SpriteRenderer>();
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float horizontalInput = Input.GetAxis("Horizontal");

        Vector2 direction = new Vector2 (rb2D.position.x + horizontalInput * speed * Time.fixedDeltaTime, rb2D.position.y);
        
        rb2D.MovePosition(direction); 

        if (horizontalInput < 0)
        {
            animator.SetBool("isWalking", true);
            spriteRenderer.flipX = true;
        }
        else if (horizontalInput > 0)
        {
            animator.SetBool("isWalking", true);
            spriteRenderer.flipX = false;
        }
        else if (horizontalInput == 0)
        {
            animator.SetBool("isWalking", false);
        }
        
        if (Input.GetKey(KeyCode.Space) && isOnGround == true)
        {
            Debug.Log("up");
            rb2D.AddForce(Vector2.up * jumpForce);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isOnGround = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Floor")
        {
            isOnGround = false;
        }
    }
}
