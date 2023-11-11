using UnityEngine;
public class LoadController : MonoBehaviour
{
    [SerializeField] LoadGame loadGame;
    [SerializeField] MenuController menuController;
    [SerializeField] int valueLevel;
    public int ValueLevel { get { return valueLevel; } }
    void Awake()
    {
        loadGame = FindObjectOfType<LoadGame>();
        menuController = FindObjectOfType<MenuController>();
        LoadControllerMethod();
    }
    private void LoadControllerMethod()
    {
        if (menuController.IsNewGame)
        {
            valueLevel = 1;
            loadGame.GoNewGame();
        }
        if (menuController.IsLoadGame)
        {
            loadGame.GoLoadGame();
        }
    }
}