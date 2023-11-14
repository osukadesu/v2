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
    }
    public void ProcesarNivel(int level)
    {
        switch (level)
        {
            case 1:
                Levels[0].SetActive(true);
                Levels[1].SetActive(false);
                Debug.Log("Bienvenido al Nivel 1");
                break;
            case 2:
                Levels[0].SetActive(false);
                Levels[1].SetActive(true);
                if (loadController.LevelLoad)
                {
                    PlayerData playerData = SaveAndLoadManager.LoadDataGame();
                    loadGame.SetPlayerPosition(playerData);
                }
                else
                {
                    playerMove.transform.position = targetPlayerPosition.position;
                    Debug.Log("Bienvenido al Nivel 2");
                }
                break;
            default:
                Debug.LogError("Error al cargar nivel");
                break;
        }
    }
}