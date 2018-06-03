using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpaceManager : MonoBehaviour
{

    public FunctionalityOfTheDirection north = FunctionalityOfTheDirection.NULL;
    public FunctionalityOfTheDirection south = FunctionalityOfTheDirection.NULL;
    public FunctionalityOfTheDirection east = FunctionalityOfTheDirection.NULL;
    public FunctionalityOfTheDirection west = FunctionalityOfTheDirection.NULL;

    public GameObject spaceNorth, spaceSouth, spaceEast, spaceWest;

    void Start()
    {
    }

    void Update()
    {

    }

    public void OnTrigger(Direction direction, GameObject other)
    {
        switch (direction)
        {
            case Direction.NORTH:
                spaceNorth = other;
                break;
            case Direction.SOUTH:
                spaceSouth = other;
                break;
            case Direction.EAST:
                spaceEast = other;
                break;
            case Direction.WEST:
                spaceWest = other;
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
