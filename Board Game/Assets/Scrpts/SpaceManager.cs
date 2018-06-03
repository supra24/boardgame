using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceManager : MonoBehaviour
{

    public FunctionalityOfTheDirection north;
    public FunctionalityOfTheDirection south;
    public FunctionalityOfTheDirection east;
    public FunctionalityOfTheDirection west;

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

    public void OnTrigger(Direction direction, Collider other)
    {
        switch (direction)
        {
            case Direction.NORTH:
                spaceNorth = other.transform.parent.parent.gameObject;
                break;
            case Direction.SOUTH:
                spaceSouth = other.transform.parent.parent.gameObject;
                break;
            case Direction.EAST:
                spaceEast = other.transform.parent.parent.gameObject;
                break;
            case Direction.WEST:
                spaceWest = other.transform.parent.parent.gameObject;
                break;
        }
    }

    public void OnTrigger(Direction direction, FunctionalityOfTheDirection functionalityOfTheDirection)
    {
        switch (direction)
        {
            case Direction.NORTH:
                north = functionalityOfTheDirection;
                break;
            case Direction.SOUTH:
                south = functionalityOfTheDirection;
                break;
            case Direction.EAST:
                east = functionalityOfTheDirection;
                break;
            case Direction.WEST:
                west = functionalityOfTheDirection;
                break;
        }
    }
}
