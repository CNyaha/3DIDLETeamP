using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemData : ScriptableObject
{
    public int ID;
    public string Name;
    public string Description;


    public bool IsStack;
    public int MaxStack;
}
