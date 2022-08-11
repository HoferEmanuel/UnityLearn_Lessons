using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float vehicleSpeed = 15;
    [SerializeField] float turnSpeed = 0;
    [SerializeField] float horizontalMovement = 0, verticalInput = 0;
  
    private void Start()
    {
    }
    
    private void Update()
    {
        horizontalMovement = Input.GetAxis("Horizontal");
        verticalMovement = Input.GetAxis("Vertical");
    
        transform.Translate(Vector3.forward * time.deltaTime * vehicleSpeed * verticalInput);
        transform.Translate(Vector3.right * time.deltaTime * turnSpeed * horizontalMovment);
    }
}
