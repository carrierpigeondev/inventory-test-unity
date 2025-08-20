using UnityEngine;

public class RotateToPlayer : MonoBehaviour
{
    public Canvas C;
    public float RotationsPerSecond;

    private Transform t;
    private float rotationSpeed;

    private void Start()
    {
        t = C.transform;
    }

    void Update()
    {
        rotationSpeed = 360 * RotationsPerSecond;
        t.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
