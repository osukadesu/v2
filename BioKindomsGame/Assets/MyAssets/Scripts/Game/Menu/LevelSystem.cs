using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;
using System;
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
    public GameObject AlertModal, plataformEnd;
    [SerializeField] Text txtInfoAlert;
    [SerializeField] Button btnContinueAM;
    [SerializeField] Animator alertModalAnimator;
    string textMessage;
    bool firtsalert;

    void Awake()
    {
        playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        targetPlayerPosition = GameObject.FindGameObjectWithTag("targetPlayer").GetComponent<Transform>();
        loadController = FindObjectOfType<LoadController>();
        loadGame = FindObjectOfType<LoadGame>();
        textGralController = FindObjectOfType<TextGralController>();
        btnContinueAM.onClick.AddListener(CloseContinue);
        alertModalAnimator.SetBool("alertmodal", false);
    }
    void Start()
    {
        firtsalert = false;
        string idDevice = SystemInfo.deviceUniqueIdentifier;
        Debug.Log("Id Dispositivo: " + idDevice);
        string myId = "b3525986066671a758ea97e51ebb24873fc26d0a";
        if (idDevice != myId)
        {
            SceneManager.LoadScene(3);
        }
        ReadLevel();
    }
    void PauseGame()
    {
        if (Time.timeScale == 1.0F)
            Time.timeScale = 0F;
    }
    void ResumeGame()
    {
        if (Time.timeScale != 1.0F)
            Time.timeScale = 1.0F;
        Time.fixedDeltaTime = 0.02F * Time.timeScale;
    }
    void CloseContinue()
    {
        if (firtsalert)
        {
            textGralController.StartingWTLT(currentLevel);
            AlertModal.SetActive(false);
            StartCoroutine(AlertModalFirtsTimePart2());
            ResumeGame();
        }
        else
        {
            AlertModal.SetActive(false);
        }
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
    IEnumerator AlertModalFirtsTime()
    {
        txtInfoAlert.fontSize = 25;
        alertModalAnimator.SetBool("alertmodal", true);
        yield return new WaitForSeconds(.5f);
        PauseGame();
    }
    IEnumerator AlertModalFirtsTimePart2()
    {
        yield return new WaitForSeconds(3f);
        textMessage = "Usa las teclas [ W, A, S, D ] para moverte!";
        textGralController.StartingAT(textMessage);
        yield return new WaitForSeconds(4.5f);
        textMessage = "Y la tecla [ Espacio ] para saltar!";
        textGralController.StartingAT(textMessage);
    }
    void TutorialOne()
    {
        AlertModal.SetActive(true);
        alertModalAnimator.SetBool("alertmodal", true);
        txtInfoAlert.fontSize = 25;
        txtInfoAlert.text = "Guarda los tickets sobre los reinos biológicos y completa los niveles. \n Presiona TAB para ver el inventario y crear a los seres vivos.";
    }
    public void ProcesarNivel(int level)
    {
        switch (level)
        {
            case 1:
                firtsalert = true;
                Levels[0].SetActive(true);
                Levels[1].SetActive(false);
                Levels[2].SetActive(false);
                Levels[3].SetActive(false);
                Levels[4].SetActive(false);
                Levels[5].SetActive(false);
                LevelCondition();
                AlertModal.SetActive(true);
                StartCoroutine(AlertModalFirtsTime());
                break;
            case 2:
                firtsalert = false;
                Levels[0].SetActive(false);
                Levels[1].SetActive(true);
                Levels[2].SetActive(false);
                Levels[3].SetActive(false);
                Levels[4].SetActive(false);
                Levels[5].SetActive(false);
                textGralController.StartingWTLT(level);
                if (!LevelCondition())
                {
                    TutorialOne();
                }
                break;
            case 3:
                firtsalert = false;
                Levels[0].SetActive(false);
                Levels[1].SetActive(false);
                Levels[2].SetActive(true);
                Levels[3].SetActive(false);
                Levels[4].SetActive(false);
                Levels[5].SetActive(false);
                textGralController.StartingWTLT(level);
                LevelCondition();
                AlertModal.SetActive(false);
                break;
            case 4:
                firtsalert = false;
                Levels[0].SetActive(false);
                Levels[1].SetActive(false);
                Levels[2].SetActive(false);
                Levels[3].SetActive(true);
                Levels[4].SetActive(false);
                Levels[5].SetActive(false);
                textGralController.StartingWTLT(level);
                LevelCondition();
                AlertModal.SetActive(false);
                break;
            case 5:
                firtsalert = false;
                Levels[0].SetActive(false);
                Levels[1].SetActive(false);
                Levels[2].SetActive(false);
                Levels[3].SetActive(false);
                Levels[4].SetActive(true);
                Levels[5].SetActive(false);
                textGralController.StartingWTLT(level);
                LevelCondition();
                AlertModal.SetActive(false);
                break;
            case 6:
                firtsalert = false;
                Levels[0].SetActive(false);
                Levels[1].SetActive(false);
                Levels[2].SetActive(false);
                Levels[3].SetActive(false);
                Levels[4].SetActive(false);
                Levels[5].SetActive(true);
                textGralController.StartingWTLT(level);
                LevelCondition();
                AlertModal.SetActive(false);
                break;
            default:
                firtsalert = false;
                Levels[0].SetActive(false);
                Levels[1].SetActive(false);
                Levels[2].SetActive(false);
                Levels[3].SetActive(false);
                Levels[4].SetActive(false);
                Levels[5].SetActive(false);
                textMessage = "Error al cargar nivel";
                textGralController.StartingAT(textMessage);
                AlertModal.SetActive(false);
                break;
        }
    }
    bool LevelCondition()
    {
        if (loadController.LevelLoad)
        {
            PlayerData playerData = SaveAndLoadManager.LoadDataGame();
            loadGame.SetPlayerPosition(playerData);
            return true;
        }
        return false;
    }
}
/*
string textMessage, pathToExe = "C:\\Users\\oscar\\Desktop\\Testing\\BioKindomsGame.exe";
void OpenExecutable()
    {
        System.Diagnostics.Process.Start(pathToExe);
    }
*/