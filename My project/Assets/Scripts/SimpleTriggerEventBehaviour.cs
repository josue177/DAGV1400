using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class SimpleTriggerEventBehaviour : MonoBehaviour
{
    public UnityEvent triggerEvent;

    // Reference to your stamina data
    public SimpleFloatData StaminaData; // Make sure to assign this in the Inspector
    public float staminaDecreaseAmount = 0.1f; // Amount to decrease stamina
    public float staminaRegenerateAmount = 0.05f; // Amount to regenerate stamina
    public float regenerateDelay = 2.0f; // Time before stamina starts regenerating

    private bool isRegenerating = false; // Flag to check if stamina is regenerating

    private void OnTriggerEnter(Collider other)
    {
        triggerEvent.Invoke();
    }
}