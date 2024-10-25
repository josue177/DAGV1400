using UnityEngine;

public class BouncyBall : MonoBehaviour
{
    public float bounceForce = 3f;        // Initial bounce force
    public float bounceDampening = 0.8f;  // Reduction factor (less than 1)
    public float minBounceForce = 0.1f;   // Minimum bounce force before the ball stops

    private void OnCollisionEnter(Collision collision)
    {
        // Apply bounce force
        if (bounceForce > minBounceForce)
        {
            GetComponent<Rigidbody>().AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
            
            // Reduce bounce force for next collision
            bounceForce *= bounceDampening;
        }
    }
}
