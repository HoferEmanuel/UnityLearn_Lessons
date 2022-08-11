using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float vehicleSpeed = 15;
    [SerializeField] float offset = 0;
  
    private void Start()
    {
    }
    
    private void Update()
    {
        transform.Translate(Vector3.forward * time.deltaTime * vehicleSpeed);
        transform.Translate(Vector3.right * time.deltaTime * offset);
    }
}
