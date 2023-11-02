using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadController : MonoBehaviour
{
    public LoadGame loadGame;
    public NewGame newGame;
    public MenuController menuController;
    private void Start()
    {
        menuController = FindObjectOfType<MenuController>();
        if (menuController.IsLoadGame)
        {
            loadGame.GoLoadGame();
        }
        if (menuController.IsNewGame)
        {
            newGame.GoNewGame();
        }
    }
}