using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuButtons : MonoBehaviour
{
    public void ButtonNewGame()
    {
        MenuController.instance.IsNewGame = true;
        SceneManager.LoadScene(2);
    }
    public void ButtonLoadGame()
    {
        MenuController.instance.IsLoadGame = true;
        SceneManager.LoadScene(2);
    }
    public void ButtonOptions()
    {
        //despues. 
    }
    public void ButtonExit()
    {
        Application.Quit();
    }
}