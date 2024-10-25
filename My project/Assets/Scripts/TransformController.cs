using UnityEngine;

public class TransoformController : MonoBehaviour
{
    private void Update()
    {
        //move target GameObject
        var x = Mathf.PingPong(Time.time, 3);
        var y = Mathf.PingPong(Time.time, 3);
        var z = Mathf.PingPong(Time.time, 3);
        var p = new Vector3(x, y, z);
        transform.position = p;

        //rotate
        transform.Rotate(new Vector3(0, 30, 0) * Time.deltaTime);
    }
}