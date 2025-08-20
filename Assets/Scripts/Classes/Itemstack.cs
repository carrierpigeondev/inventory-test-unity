using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class Itemstack
{
    public string Id;
    public int Count;
    public int Max;

    public Itemstack(string id, int count, int max)
    {
        if (count > max) {
            Debug.LogError($"Itemstack count of {count} exceeds max of {max}");
        }

        Id = id;
        Count = count;
        Max = max;
    }

    /// <summary>
    /// Adds n to the current itemstack's count if the new count is not over the max.<br></br>
    /// If the new count is over the max, this function will return false.<br></br>
    /// If the new count is successfully set, this function will return true.
    /// </summary>
    public bool AddCount(int n)
    {
        int newCount = Count + n;
        if (newCount > Max)
        {
            Debug.LogError($"New itemstack count of {newCount} exceeds max of {Max}");
            return false;
        }

        Count = newCount;
        return true;
    }

    /// <summary>
    /// Removes n from the current itemstack's count if the new count is not under 0.<br></br>
    /// If the new count is under 0, this function will return false.<br></br>
    /// If the new count is successfully set, this function will return true.
    /// </summary>
    public bool RemoveCount(int n) {
        int newCount = Count - n;
        if (newCount < 0)
        {
            Debug.LogError($"New itemstack count of {newCount} is below 0");
            return false;
        }
        
        Count = newCount;
        return false;
    }
}
