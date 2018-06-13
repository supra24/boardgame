using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour {

    public SpaceManager[] spaces;

	// Use this for initialization
	void Start () {

        spaces = transform.GetComponentsInChildren<SpaceManager>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
