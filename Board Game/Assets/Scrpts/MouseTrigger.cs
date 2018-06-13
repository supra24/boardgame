using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTrigger : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnMouseUpAsButton()
    {
       Debug.Log("On Mouse Up As Button: " + transform.parent.name);
        transform.GetComponentInParent<SpaceManager>().OnMouseUpAsButtonParent();
    }
   
}
