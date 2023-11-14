using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class ButtonSave : MonoBehaviour
{
    [SerializeField] Button buttonSave;
    [SerializeField] CraftBuilderSystem craftBuilderSystem;
    [SerializeField] LevelSystem levelSystem;
    [SerializeField] PlayerMove playerMove;
    [SerializeField] Animator txtAnim;
    [SerializeField] Text messageText;
    void Awake()
    {
        playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        txtAnim = GameObject.FindGameObjectWithTag("txtGral").GetComponent<Animator>();
        messageText = GameObject.FindGameObjectWithTag("txtGral").GetComponent<Text>();
        buttonSave = GameObject.FindGameObjectWithTag("btnSave").GetComponent<Button>();
        craftBuilderSystem = FindObjectOfType<CraftBuilderSystem>();
        levelSystem = FindObjectOfType<LevelSystem>();
        buttonSave.onClick.AddListener(() => MyButtonSave());
    }
    void Start()
    {
        TextHide();
    }
    public void MyButtonSave()
    {
        StartCoroutine(TextFade());
        SaveAndLoadManager.SaveDataGame(craftBuilderSystem, playerMove, levelSystem);
    }
    void TextHide()
    {
        txtAnim.SetBool("txtinfogral", false);
        messageText.text = "";
    }

    void TextView()
    {
        txtAnim.SetBool("txtinfogral", true);
        messageText.text = "Partida Guardada!";
    }
    IEnumerator TextFade()
    {
        TextView();
        yield return new WaitForSeconds(1.5f);
        TextHide();
    }
}