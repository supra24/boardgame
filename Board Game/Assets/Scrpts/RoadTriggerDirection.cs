using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadTriggerDirection : MonoBehaviour
{
    public FunctionalityOfTheDirection functionalityOfTheDirection;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
            other.transform.parent.GetComponentInParent<SpaceManager>().OnTrigger(other.GetComponent<SpaceTriggerDirection>().direction, functionalityOfTheDirection);
    }
}
