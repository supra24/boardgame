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

    private bool choice = false;

    public bool isUsed = false;

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
            case Direction.NULL:
                break;
        }
    }

    public void OnTrigger(Direction direction, FunctionalityOfTheDirection functionalityOfTheDirection)
    {
        isUsed = true;

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
            case Direction.NULL:
                break;
        }
    }

    //    public void SetChoiceOfDirection(bool isChoice)
    //  {
    //    GameObject gameObject = transform.GetChild(3).gameObject;
    //  gameObject.SetActive(isChoice);
    //  choice = isChoice;
    //CameraController.RunToMainPosition();
    //}

    public void OnMouseUpAsButtonParent()
    {
        switch (SharedData.actions)
        {
            case Actions.NULL:
                break;
            case Actions.START:
                isChoiceStart();
                break;
        }
    }

    private void isChoiceStart()
    {
        SpaceManager[] spaces = transform.parent.GetComponentsInChildren<SpaceManager>();

        foreach (SpaceManager space in spaces)
        {
            space.gameObject.transform.GetChild(3).gameObject.SetActive(false);
        }

        GameObject spacecraft = Resources.Load("Prefabs/Spacecraft") as GameObject;
        GameObject instantiate = Instantiate(spacecraft, new Vector3(transform.position.x, 0, transform.position.z), Quaternion.identity);
        instantiate.transform.parent = GameObject.Find("Road").gameObject.transform;

        CameraController.RunToMainPosition();

    }
}
