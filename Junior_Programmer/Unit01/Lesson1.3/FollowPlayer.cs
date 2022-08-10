using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    Transform player;

    private void Update() => transform.position = player.position;
}
