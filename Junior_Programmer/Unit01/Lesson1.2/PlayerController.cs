using UnityEngine;

public class PlayerController : MonoBehaviour
{    
    private void Update()
    {
        //move vehicle forward.
        transform.Translate(Vector3.forward * Time.deltaTime * vehicleSpeed);
    }
}
