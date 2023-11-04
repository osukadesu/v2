using System.IO;
using UnityEngine;
using UnityEngine.UI;
public class MenuController : MonoBehaviour
{
    public static MenuController instance;
    [SerializeField] GameObject btnLoadGame;
    [SerializeField] VerticalLayoutGroup verticalLayoutGroup;
    [SerializeField] bool isNewGame, isLoadGame;
    public bool IsNewGame { get { return isNewGame; } set { isNewGame = value; } }
    public bool IsLoadGame { get { return isLoadGame; } set { isLoadGame = value; } }
    void Start()
    {
        verticalLayoutGroup = GameObject.FindGameObjectWithTag("menuGameVL").GetComponent<VerticalLayoutGroup>();
        isNewGame = false;
        isLoadGame = false;
        MenuOrder();
    }
    void Awake()
    {
        DontDestroyOnLoad(gameObject);
        instance = this;
    }
    public void MenuOrder()
    {
        string datapath = Application.persistentDataPath + "/player.data";
        if (File.Exists(datapath))
        {
            btnLoadGame.SetActive(true);
            verticalLayoutGroup.padding.top = 0;
        }
        else
        {
            btnLoadGame.SetActive(false);
            verticalLayoutGroup.padding.top = 70;
        }
    }
}