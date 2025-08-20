using System;
using UnityEngine;

public class Inventory
{
    public Itemstack[] Itemstacks;

    public Inventory(int size)
    {
        Itemstacks = new Itemstack[size];
    }
    
    public bool AddItemstack(Itemstack itemstack)
    {
        try
        {
            Itemstacks[Itemstacks.Length] = itemstack;
        } catch (Exception e)
        {
            Debug.LogError(e.ToString());
            return false;
        }
        
        return true;
    }
}
