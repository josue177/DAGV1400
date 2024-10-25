using UnityEngine;

public class ColorChange : MonoBehaviour
{
    public Color newColor = Color.red;  // Correctly using Color instead of ColorChange

    void OnCollisionEnter(Collision collision)
    {
        // Change the material color of the object on collision
        GetComponent<Renderer>().material.color = newColor;
    }
}
