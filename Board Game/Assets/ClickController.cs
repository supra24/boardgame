using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickController : MonoBehaviour {

    public GameObject canvas;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetMouseButtonUp(0))
        {
            canvas.transform.Find("Text").GetComponent<Text>().text = "";
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                GameObject hitGameObject = hit.transform.gameObject;
                Debug.Log("Hit name gameobject: " + hitGameObject.name);

                if (hitGameObject.name.Contains("Space"))
                {
                    if (hitGameObject.GetComponent<SpaceManager>().isUsed)
                    {
                        canvas.transform.Find("Text").GetComponent<Text>().text =
                            "Soldiers - " + hitGameObject.GetComponent<SpaceManager>().numberOfSoldiers + "\n" +
                            "Villagers - " + hitGameObject.GetComponent<SpaceManager>().numberOfVillagers + "\n" +
                            "Technicians - " + hitGameObject.GetComponent<SpaceManager>().numberOfTechnicians;

                    }
                }
            }
        }
	}
}
