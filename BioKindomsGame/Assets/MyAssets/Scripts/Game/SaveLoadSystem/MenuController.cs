using System.IO;
using UnityEngine;
using UnityEngine.UI;
public class MenuController : MonoBehaviour
{
    public static MenuController menuController;
    [SerializeField] bool isNewGame, isLoadGame;
    public bool IsNewGame { get { return isNewGame; } set { isNewGame = value; } }
    public bool IsLoadGame { get { return isLoadGame; } set { isLoadGame = value; } }
    void Awake()
    {
        Singleton();
        isNewGame = false;
        isLoadGame = false;
    }
    private void Singleton()
    {
        if (menuController == null)
        {
            menuController = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}