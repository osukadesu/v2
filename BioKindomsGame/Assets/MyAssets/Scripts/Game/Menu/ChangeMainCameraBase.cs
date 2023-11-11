using System;
using UnityEngine;
public abstract class ChangeMainCameraBase : MonoBehaviour
{
    [SerializeField] protected Canvas canvas;
    [SerializeField] protected Camera myCamera;
    void Update()
    {
        canvas = GameObject.FindGameObjectWithTag("myCanvas").GetComponent<Canvas>();
        ChangeCamera();
        CanvasSet();
    }
    void CanvasSet()
    {
        canvas.renderMode = RenderMode.ScreenSpaceCamera;
        canvas.worldCamera = myCamera;
    }
    protected internal abstract void ChangeCamera();
}