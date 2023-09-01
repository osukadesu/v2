using UnityEngine;
using UnityEngine.UI;
public class ViewMenu : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Animator animTabView;
    [SerializeField] bool active;
    [SerializeField] Button btnClose;
    private void Update()
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
        }
    }
    public void CloseTabView()
    {
        animTabView.SetBool("tabview", false);
    }
}