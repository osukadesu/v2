using System;
using UnityEngine;
public abstract class ChangeMainCameraBase : MonoBehaviour
{
    [SerializeField] protected Canvas canvas;
    [SerializeField] protected Camera myCamera;
    private void Awake()
    {
        canvas = GameObject.FindGameObjectWithTag("myCanvas").GetComponent<Canvas>();
    }
    void Update()
    {
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