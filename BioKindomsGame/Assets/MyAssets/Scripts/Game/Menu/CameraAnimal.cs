using UnityEngine;
public class CameraAnimal : ChangeMainCameraBase
{
    protected internal override void ChangeCamera()
    {
        myCamera = GameObject.FindGameObjectWithTag("animalCam").GetComponent<Camera>();
    }
}