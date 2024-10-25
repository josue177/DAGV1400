using UnityEngine.UI;
using UnityEngine;

[RequireComponent(typeof(Image))]
public class SimpleImageBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    private Image imageObj;
    public SimpleFloatData dataObj;
    private void Start()
    {
       imageObj = GetComponent<Image>(); 
    }

    // Update is called once per frame
    public void UpdateWithFloatData()
    {
        if(dataObj == null)
        {
            Debug.LogError("dataobj is not assigned im image");
            return;
        }
        Debug.Log("Current Health: " + dataObj.value);
        imageObj.fillAmount = dataObj.value;
    }
}
