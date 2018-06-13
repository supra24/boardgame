using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAction : Action {

    private void Start()
    {
        SharedData.actions = Actions.START;
        base.Start();
    }

    public override void RunAction()
    {
        CameraController.RunToSpacePosition();

        foreach (SpaceManager space in spaces)
        {
            space.gameObject.transform.GetChild(3).gameObject.SetActive(true);
        }
    }
}
