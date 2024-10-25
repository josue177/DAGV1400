using UnityEngine;

[CreateAssetMenu(menuName = "Single Variables/SimpleFloatData")]
public class SimpleFloatData : ScriptableObject
{
    public float value;
    public void UpdateValue(float amount)
    {
       value += amount;
    }

    // Update is called once per frame
    public void SetValue(float amount)
    {
        value = amount;
    }
}
