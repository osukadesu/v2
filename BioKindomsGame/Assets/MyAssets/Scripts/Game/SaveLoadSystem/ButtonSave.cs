using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class ButtonSave : MonoBehaviour
{
    [SerializeField] Button buttonSave;
    [SerializeField] CraftBuilderSystem craftBuilderSystem;
    [SerializeField] LevelSystem levelSystem;
    [SerializeField] PlayerMove playerMove;
    [SerializeField] TextGralController textGralController;
    string textMessage;
    void Awake()
    {
        playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        buttonSave = GameObject.FindGameObjectWithTag("btnSave").GetComponent<Button>();
        craftBuilderSystem = FindObjectOfType<CraftBuilderSystem>();
        levelSystem = FindObjectOfType<LevelSystem>();
        textGralController = FindObjectOfType<TextGralController>();
        buttonSave.onClick.AddListener(() => MyButtonSave());
    }
    public void MyButtonSave()
    {
        SaveAndLoadManager.SaveDataGame(craftBuilderSystem, playerMove, levelSystem);
        textMessage = "Partida Guardada!";
        textGralController.StartingAT2(textMessage);
    }
}