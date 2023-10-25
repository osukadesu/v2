using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class ViewMenu : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Animator animTabView;
    [SerializeField] bool active;
    [SerializeField] Button btnClose;
    void Update()
    {
        _canvasManager.TabViewMenu();
    }
    void Awake()
    {
        btnClose.onClick.AddListener(() => _canvasManager.ButtonCloseTab());
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void TabVieW()
    {
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            active = !active;
            animTabView.SetBool("tabview", active);
            if (active == false)
            {
                _canvasManager.CloseTabViewv2();
            }
            else
            {
                _canvasManager.ButtonGoAnimalV2();
            }
        }
    }
    public void CloseTabView()
    {
        animTabView.SetBool("tabview", false);
    }
}