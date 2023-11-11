using System.Security.Cryptography.X509Certificates;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PrincipalMenuView : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
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
            MethodPM();
        }
    }
    public void MethodPM()
    {
        MenuController.menuController.IsNewGame = false;
        MenuController.menuController.IsLoadGame = false;
        SceneManager.LoadScene(1);
    }
}