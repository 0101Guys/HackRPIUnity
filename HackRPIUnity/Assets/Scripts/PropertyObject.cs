using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PropertyObject : MonoBehaviour 
{
    public List<string> possible_tags;
    public List<MonoBehaviour> behaviours;
    public List<string> tags;


    public virtual void AddTag(string tag)
    {
        tags.Add(tag);
        int i = possible_tags.IndexOf(tag);
        MonoBehaviour component = behaviours[i];

        component.enabled = true;
    }
    public virtual void RemoveTag(string tag)
    {
        tags.Remove(tag);
        int i = possible_tags.IndexOf(tag);
        MonoBehaviour component = behaviours[i];

        component.enabled = false;
    }
	
}
