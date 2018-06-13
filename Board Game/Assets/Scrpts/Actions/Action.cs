using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Action : MonoBehaviour {

    protected GameObject Map;
    protected SpaceManager[] spaces;

	// Use this for initialization
	protected void Start () {
        Map = GameObject.Find("Map");
        spaces = Map.transform.GetComponentsInChildren<SpaceManager>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public abstract void RunAction();
}
