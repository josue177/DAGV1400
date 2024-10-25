using UnityEngine;

public class CharacterAnimationController : MonoBehaviour
{
    private Animator animator;  // Reference to the Animator component
    private static readonly int IsRunningHash = Animator.StringToHash("RunTrigger");
    private static readonly int JumpHash = Animator.StringToHash("JumpTrigger");
    private static readonly int WallJumpHash = Animator.StringToHash("WallJumpTrigger");
    private static readonly int HitHash = Animator.StringToHash("HitTrigger");
    
    // Use Start method to initialize animator
    private void Start()
    {
        animator = GetComponent<Animator>();  // Proper initialization
    }

    private void Update()
    {
        HandleAnimations();
    }

    private void HandleAnimations()
    {
        // Check if moving horizontally
        bool currentlyMoving = Input.GetAxis("Horizontal") != 0;

        // Update the running state
        animator.SetBool(IsRunningHash, currentlyMoving); // Set running animation based on movement state

        // Trigger "Jump" animation on jump button press
        if (Input.GetButtonDown("Jump"))
        {
            animator.SetTrigger(JumpHash);
        }

        // Trigger "WallJump" animation on specific key press
        if (Input.GetKeyDown(KeyCode.W)) // Verify if this is intended for WallJump
        {
            animator.SetTrigger(WallJumpHash);
        }

        // Trigger "Hit" animation on specific key press
        if (Input.GetKeyDown(KeyCode.F))
        {
            animator.SetTrigger(HitHash);
        }
    }
}
