using UnityEngine;
public class MenuController : MonoBehaviour
{
    public static MenuController instance;
    public bool isNewGame, isLoadGame;
    private void Start()
    {
        isNewGame = false;
        isLoadGame = false;
    }
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}