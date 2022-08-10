using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Vector3 camOffset = new Vector3(0, 1, 1);

    private void LateUpdate() => transform.position = player.position + camOffset;
}
