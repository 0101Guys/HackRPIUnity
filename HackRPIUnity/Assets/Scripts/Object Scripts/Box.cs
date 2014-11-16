using UnityEngine;
using System.Collections;

public class Box : PropertyObject 
{
    public MonoBehaviour fly_movement;
    public TextMesh property1_text;


    public override void SetProperty(string tag)
    {
        if (tag == "Fly")
        {
            fly_movement.enabled = true;
            property1_text.text = "FLY";
            property1_text.gameObject.SetActive(true);
        }
    }
    public override void RemoveProperty()
    {
        if (property == "Fly")
        {
            fly_movement.enabled = false;
            property1_text.gameObject.SetActive(false);
        }
    }
	
}
