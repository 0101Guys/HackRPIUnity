using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PropertyObject : MonoBehaviour 
{
    public string property;


    public virtual void SetProperty(string property)
    {
        this.property = property;
    }
    public virtual void RemoveProperty()
    {
        this.property = "";
    }
    public virtual void GrabObject()
    {
        RemoveProperty();
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SetProperty("Fly");
        }
    }
	
}
