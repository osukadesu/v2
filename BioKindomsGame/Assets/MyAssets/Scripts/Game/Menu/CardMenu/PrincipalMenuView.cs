using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PrincipalMenuView : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] MenuController menuController;
    void Awake()
    {
        menuController = FindObjectOfType<MenuController>();
    }
    void Update()
    {
        _canvasManager.PrincipalMenuViewMethod();
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    public void PrincipalMenuViewMethod()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            MethodPrincipalMenu();
        }
    }
    public void MethodPrincipalMenu()
    {
        menuController.IsNewGame = false;
        menuController.IsLoadGame = false;
        SceneManager.LoadScene(1);
    }
}