using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceManager : MonoBehaviour
{

    public FunctionalityOfTheDirection north { get; set; }
    public FunctionalityOfTheDirection south { get; set; }
    public FunctionalityOfTheDirection east { get; set; }
    public FunctionalityOfTheDirection west { get; set; }

    public GameObject spaceNorth, spaceSouth, spaceEast, spaceWest;

    void Start()
    {
        north = FunctionalityOfTheDirection.NULL;
        south = FunctionalityOfTheDirection.NULL;
        east = FunctionalityOfTheDirection.NULL;
        west = FunctionalityOfTheDirection.NULL;
    }

    void Update()
    {

    }

    public void OnTriggerEnter(Direction direction, Collider other)
    {
        switch (direction)
        {
            case Direction.NORTH:
                spaceNorth = other.gameObject;
                break;
            case Direction.SOUTH:
                spaceSouth = other.gameObject;
                break;
            case Direction.EAST:
                spaceEast = other.gameObject;
                break;
            case Direction.WEST:
                spaceWest = other.gameObject;
                break;
        }
    }
}
