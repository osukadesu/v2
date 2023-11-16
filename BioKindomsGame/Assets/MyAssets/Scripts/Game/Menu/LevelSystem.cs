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
    string myMessage;
    void Awake()
    {
        playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        targetPlayerPosition = GameObject.FindGameObjectWithTag("targetPlayer").GetComponent<Transform>();
        loadController = FindObjectOfType<LoadController>();
        loadGame = FindObjectOfType<LoadGame>();
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
                Debug.Log("Bienvenido al Nivel 1");
                break;
            case 2:
                Levels[0].SetActive(false);
                Levels[1].SetActive(true);
                Levels[2].SetActive(false);
                Levels[3].SetActive(false);
                myMessage = "Bienvenido al Nivel 2";
                LevelCondition(myMessage);
                break;
            case 3:
                Levels[0].SetActive(false);
                Levels[1].SetActive(false);
                Levels[2].SetActive(true);
                Levels[3].SetActive(false);
                myMessage = "Bienvenido al Nivel 3";
                LevelCondition(myMessage);
                break;
            case 4:
                Levels[0].SetActive(false);
                Levels[1].SetActive(false);
                Levels[2].SetActive(false);
                Levels[3].SetActive(true);
                myMessage = "Bienvenido al Nivel 4";
                LevelCondition(myMessage);
                break;
            default:
                Debug.LogError("Error al cargar nivel");
                break;
        }
    }
    private void LevelCondition(string message)
    {
        if (loadController.LevelLoad)
        {
            PlayerData playerData = SaveAndLoadManager.LoadDataGame();
            loadGame.SetPlayerPosition(playerData);
            Debug.Log(message);
        }
    }
}