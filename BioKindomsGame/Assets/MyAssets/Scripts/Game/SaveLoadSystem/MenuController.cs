using UnityEngine;
using UnityEngine.UI;
public class MenuController : MonoBehaviour
{
    public static MenuController instance;
    [SerializeField] VerticalLayoutGroup verticalLayoutGroup;
    [SerializeField] bool isNewGame, isLoadGame;
    public bool IsNewGame { get { return isNewGame; } set { isNewGame = value; } }
    public bool IsLoadGame { get { return isLoadGame; } set { isLoadGame = value; } }
    private void Start()
    {
        verticalLayoutGroup = GameObject.FindGameObjectWithTag("menuGameVL").GetComponent<VerticalLayoutGroup>();
        isNewGame = false;
        isLoadGame = false;
        if (true)
        {
            verticalLayoutGroup.padding.top = 72;
        }
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        instance = this;
    }
}