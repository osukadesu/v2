using System.Collections;
using UnityEngine;
public class LoadController : MonoBehaviour
{
    public LoadGame loadGame;
    public MenuController menuController;
    public CraftBuilderBase craftBuilderBase;
    public PlayerMove playerMove;
    void Start()
    {
        menuController = FindObjectOfType<MenuController>();
        if (menuController.IsLoadGame)
        {
            loadGame.GoLoadGame();
        }
        if (menuController.IsNewGame)
        {
            StartCoroutine("TimerNewToLoad");
        }
    }
    IEnumerator TimerNewToLoad()
    {
        GoInitialSave();
        yield return new WaitForSeconds(1.5f);
        loadGame.GoInitialLoad();
    }
    public void GoInitialSave()
    {
        SaveAndLoadManager.InitialSave(craftBuilderBase, playerMove);
    }
}