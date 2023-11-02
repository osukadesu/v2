using UnityEngine;
public class CameraTutorial : ChangeMainCameraBase
{
    protected internal override void ChangeCamera()
    {
        myCamera = GameObject.FindGameObjectWithTag("tutorialCam").GetComponent<Camera>();
    }
}