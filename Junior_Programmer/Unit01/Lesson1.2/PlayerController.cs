using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private void Start()
    {
    
    }
    
    private void Update()
    {
        //move vehicle forward.
        transform.Translate(0,0,1);
    }
}
