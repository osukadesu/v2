using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class ViewMenu : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Animator animTabView;
    [SerializeField] bool active;
    [SerializeField] Button btnClose;
    [SerializeField] protected Text messageText;
    void Awake()
    {
        messageText = GameObject.FindGameObjectWithTag("txtGral").GetComponent<Text>();
        animTabView = GameObject.FindGameObjectWithTag("cardMenuAnim").GetComponent<Animator>();
        btnClose = GameObject.FindGameObjectWithTag("btnClose").GetComponent<Button>();
        btnClose.onClick.AddListener(() => _canvasManager.ButtonCloseTab());
        messageText.color = new Color(1, 1, 1, 1);
    }
    void Update()
    {
        _canvasManager.TabViewMenu();
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
                messageText.color = new Color(1, 1, 1, 1);
                _canvasManager.CloseTabViewv2();
            }
            else
            {
                messageText.color = new Color(1, 0, 1, 1);
                _canvasManager.ButtonGoAnimalV2();
            }
        }
    }
    public void CloseTabView()
    {
        animTabView.SetBool("tabview", false);
        messageText.color = new Color(1, 1, 1, 1);
    }
}