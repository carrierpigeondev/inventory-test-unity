using UnityEngine;

public class RotateToPlayer : MonoBehaviour
{
    public Canvas C;
    public Transform target;
    public float RotationSpeed;
    void Update()
    {
        // Solution from: https://www.reddit.com/r/Unity3D/comments/cj7niq/comment/evbnl0k/        
        Vector3 playerLookDir = C.transform.position - target.position;
        float degrees = Mathf.Atan2(playerLookDir.x, playerLookDir.z) * Mathf.Rad2Deg;

        float moveAmount = Mathf.Min(RotationSpeed * Time.deltaTime, 1);
        Quaternion newRot = Quaternion.Euler(0, degrees, 0);
        C.transform.rotation = Quaternion.Slerp(C.transform.rotation, newRot, moveAmount);
    }
}
