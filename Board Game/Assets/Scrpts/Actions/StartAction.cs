using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartAction : Action {

    public override void RunAction()
    {
        CameraController.RunToSpacePosition();

        foreach (SpaceManager space in spaces)
        {
            if (!space.isUsed)
                space.gameObject.transform.GetChild(3).gameObject.SetActive(true);
        }
        SharedData.actions = Actions.START;

    }
}
