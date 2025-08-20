using UnityEngine;
using static UnityEditor.Progress;

public class StorageDevice : MonoBehaviour
{
    [SerializeField] public Inventory inv;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        inv = new Inventory(10);
    }
}
