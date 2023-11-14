using UnityEngine;
public class LoadController : MonoBehaviour
{
    [SerializeField] LoadGame loadGame;
    [SerializeField] MenuController menuController;
    [SerializeField] bool levelLoad;
    public bool LevelLoad { get { return levelLoad; } set { levelLoad = value; } }
    void Awake()
    {
        loadGame = FindObjectOfType<LoadGame>();
        menuController = FindObjectOfType<MenuController>();
        LoadControllerMethod();
    }
    void LoadControllerMethod()
    {
        if (menuController.IsNewGame)
        {
            levelLoad = false;
            loadGame.GoNewGame();
        }
        if (menuController.IsLoadGame)
        {
            levelLoad = true;
            loadGame.GoLoadGame();
        }
    }
}