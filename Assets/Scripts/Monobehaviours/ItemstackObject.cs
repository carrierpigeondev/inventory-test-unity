using UnityEngine;

public class ItemstackObject : MonoBehaviour
{
    public Itemstack item;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        item = new Itemstack("bit", 8, 256);
    }

    // Update is called once per frame
    void Update()
    {
       if (!item.AddCount(1))
        {
            Debug.LogError("Cannot add anymore!");
        }
    }
}
