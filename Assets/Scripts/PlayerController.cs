using UnityEngine;

public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f; // Movement speed of the character
    public float jumpForce = 10f; // Force applied when jumping
    private Rigidbody2D rb; // Reference to the Rigidbody2D component
    private bool isGrounded; // Flag to check if the character is grounded
    public float groundCheckDistance = 0.1f; // Distance from the character's feet to check for ground

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>(); // Get the Rigidbody2D component attached to the GameObject
    }

    private void Update()
    {
        // Check if the character is grounded
        isGrounded = Physics2D.OverlapCircle(new Vector2(transform.position.x, transform.position.y - groundCheckDistance), 0.2f, LayerMask.GetMask("Ground"));

        // Jump input
        if (isGrounded && Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    private void FixedUpdate()
    {
        // Get input for horizontal movement
        float moveHorizontal = Input.GetAxis("Horizontal");

        // Apply horizontal movement to the Rigidbody2D
        rb.velocity = new Vector2(moveHorizontal * moveSpeed, rb.velocity.y);
    }

    private void Jump()
    {
        // Apply jump force to the Rigidbody2D
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawSphere(new Vector2(transform.position.x, transform.position.y - groundCheckDistance), 0.2f);
    }
}
