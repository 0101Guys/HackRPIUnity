using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PropertyObject : MonoBehaviour 
{
    public List<string> tags;


    public virtual void AddTag(string tag)
    {
        tags.Add(tag);
    }
    public virtual void RemoveTag(string tag)
    {
        tags.Remove(tag);
    }
	
}
