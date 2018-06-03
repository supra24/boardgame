using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceTriggerDirection : MonoBehaviour
{

    public Direction direction;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.parent.parent.name.Contains("Space"))
            transform.parent.GetComponentInParent<SpaceManager>().OnTrigger(direction, other.transform.parent.parent.gameObject);
    }
}
