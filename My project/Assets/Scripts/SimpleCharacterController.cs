using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class SimpleCharacterController : MonoBehaviour
{
    public float moveSpeed = 5f;         // Speed of the character
    public float jumpForce = 8f;         // Force of the jump
    public float gravity = -9.81f;       // Gravity value
    private CharacterController controller; // CharacterController component
    private Vector3 velocity;              // Velocity vector
    private bool isGrounded;               // To track if the character is grounded
    public float groundCheckDistance = 0.2f; // Distance for ground check

    private void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        CheckGroundStatus(); // Check ground status
        MoveCharacter();
        ApplyGravity();
    }

    private void CheckGroundStatus()
    {
        // Cast a ray downwards to check if the character is grounded
        Vector3 rayStart = transform.position + Vector3.down * 0.1f; // Start slightly above the feet
        Ray ray = new Ray(rayStart, Vector3.down);
        RaycastHit hit;

        // Check if the ray hits the ground
        isGrounded = Physics.Raycast(ray, out hit, groundCheckDistance);
        
        // Debugging: Log whether the character is grounded
        if (isGrounded)
        {
            Debug.Log("Character is grounded at: " + hit.point);
        }
        else
        {
            Debug.Log("Character is NOT grounded");
        }
    }

    private void MoveCharacter()
    {
        // Get input for horizontal movement
        float moveInput = Input.GetAxis("Horizontal");
        Vector3 move = new Vector3(moveInput * moveSpeed, 0f, 0f); // Only move on X-axis
        controller.Move(move * Time.deltaTime);

        // Jump logic
        if (isGrounded && Input.GetButtonDown("Jump"))
        {
            Debug.Log("Jump pressed");
            velocity.y = Mathf.Sqrt(jumpForce * -2f * gravity); // Calculate jump velocity
            Debug.Log("Jump velocity: " + velocity.y);
        }
    }

    private void ApplyGravity()
    {
        if (!isGrounded)
        {
            velocity.y += gravity * Time.deltaTime; // Apply gravity when not grounded
            Debug.Log("Applying gravity. Current vertical velocity: " + velocity.y);
        }
        else
        {
            velocity.y = 0f; // Reset vertical velocity when grounded
        }

        // Move the character vertically (gravity and jump)
        controller.Move(velocity * Time.deltaTime);
    }
}
