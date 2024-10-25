using UnityEngine;

public class StaminaManager : MonoBehaviour
{
    public SimpleFloatData staminaData; // Reference to your stamina data
    public SimpleImageBehaviour staminaBar; // Reference to the stamina bar script
    public float staminaCost = 0.1f; // Amount of stamina to consume with each hit

    private void Update()
    {
        // Check if the player presses the "F" key to hit
        if (Input.GetKeyDown(KeyCode.F))
        {
            UseStamina();
        }
    }

    private void UseStamina()
    {
        // Reduce stamina
        staminaData.UpdateValue(-staminaCost);
        
        // Update stamina bar
        if (staminaBar != null)
        {
            staminaBar.UpdateWithFloatData(); // Call the update function to refresh the UI
        }
    }
}
