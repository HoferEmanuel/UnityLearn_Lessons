using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float vehicleSpeed = 15;
    [SerializeField] float turnSpeed = 0;
    [SerializeField] float horizontalMovement = 0, verticalInput = 0;

    private void Update()
    {
        //playerInput
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
    
        //move vehicle back and forth
        transform.Translate(Vector3.forward * time.deltaTime * vehicleSpeed * verticalInput);
        //turn vehicle
        transform.Rotate(Vector3.up, time.deltaTime * turnSpeed * horizontalMovement);
    }
}
