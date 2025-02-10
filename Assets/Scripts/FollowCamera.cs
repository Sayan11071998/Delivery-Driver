using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] public GameObject thingToFollow;

    private Vector3 offset = new Vector3(0, 0, -10);

    private void LateUpdate()
    {
        transform.position = thingToFollow.transform.position + offset;
    }
}