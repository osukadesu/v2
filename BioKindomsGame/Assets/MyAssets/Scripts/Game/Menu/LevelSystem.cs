using UnityEngine;
public class LevelSystem : MonoBehaviour
{
    [SerializeField] int currentLevel;
    public int CurrentLevel { get { return currentLevel; } set { currentLevel = value; } }
    [SerializeField] LoadController loadController;
    [SerializeField] Transform targetPlayerPosition;
    [SerializeField] LoadGame loadGame;
    [SerializeField] GameObject[] Levels;
    [SerializeField] PlayerMove playerMove;
    [SerializeField] TextGralController textGralController;
    string textMessage;
    void Awake()
    {
        playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        targetPlayerPosition = GameObject.FindGameObjectWithTag("targetPlayer").GetComponent<Transform>();
        loadController = FindObjectOfType<LoadController>();
        loadGame = FindObjectOfType<LoadGame>();
        textGralController = FindObjectOfType<TextGralController>();
    }
    void Start()
    {
        ReadLevel();
    }
    public void ReadLevel()
    {
        if (loadController.LevelLoad)
        {
            PlayerData playerData = SaveAndLoadManager.LoadDataGame();
            currentLevel = playerData.currentLevelData;
            ProcesarNivel(currentLevel);
            Debug.Log("currentLevel = " + currentLevel);
        }
        else
        {
            currentLevel = 1;
            ProcesarNivel(currentLevel);
            Debug.Log("currentLevel = " + currentLevel);
        }
    }
    public void ChangeLevel()
    {
        currentLevel++;
        ProcesarNivel(currentLevel);
        playerMove.transform.position = targetPlayerPosition.position;
    }
    public void ProcesarNivel(int level)
    {
        switch (level)
        {
            case 1:
                Levels[0].SetActive(true);
                Levels[1].SetActive(false);
                Levels[2].SetActive(false);
                Levels[3].SetActive(false);
                Levels[4].SetActive(false);
                textGralController.StartingWTLT(level);
                LevelCondition();
                break;
            case 2:
                Levels[0].SetActive(false);
                Levels[1].SetActive(true);
                Levels[2].SetActive(false);
                Levels[3].SetActive(false);
                Levels[4].SetActive(false);
                textGralController.StartingWTLT(level);
                LevelCondition();
                break;
            case 3:
                Levels[0].SetActive(false);
                Levels[1].SetActive(false);
                Levels[2].SetActive(true);
                Levels[3].SetActive(false);
                Levels[4].SetActive(false);
                textGralController.StartingWTLT(level);
                LevelCondition();
                break;
            case 4:
                Levels[0].SetActive(false);
                Levels[1].SetActive(false);
                Levels[2].SetActive(false);
                Levels[3].SetActive(true);
                Levels[4].SetActive(false);
                textGralController.StartingWTLT(level);
                LevelCondition();
                break;
            case 5:
                Levels[0].SetActive(false);
                Levels[1].SetActive(false);
                Levels[2].SetActive(false);
                Levels[3].SetActive(false);
                Levels[4].SetActive(true);
                textGralController.StartingWTLT(level);
                LevelCondition();
                break;
            default:
                textMessage = "Error al cargar nivel";
                textGralController.StartingAT(textMessage);
                break;
        }
    }
    void LevelCondition()
    {
        if (loadController.LevelLoad)
        {
            PlayerData playerData = SaveAndLoadManager.LoadDataGame();
            loadGame.SetPlayerPosition(playerData);
        }
    }
}