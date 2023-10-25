using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    public void ButtonNewGame()
    {
        MenuController.instance.isNewGame = true;
        SceneManager.LoadScene(3);
    }
    public void ButtonLoadGame()
    {
        MenuController.instance.isLoadGame = true;
        SceneManager.LoadScene(3);
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