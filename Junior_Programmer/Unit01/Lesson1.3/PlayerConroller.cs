using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float vehicleSpeed = 15;
  
    private void Start()
    {
    }
    
    private void Update()
    {
        transform.Translate(Vector3.forward * time.deltaTime * vehicleSpeed);
    }
}
