using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class ButtonSave : MonoBehaviour
{
    [SerializeField] Button buttonSave;
    [SerializeField] CraftBuilderSystem craftBuilderSystem;
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
        buttonSave.onClick.AddListener(() => MyButtonSave());
    }
    void Start()
    {
        TextHide();
    }
    public void MyButtonSave()
    {
        SaveAndLoadManager.SaveDataGame(craftBuilderSystem, playerMove);
        StartCoroutine(TextFade());
    }
    private void TextHide()
    {
        txtAnim.SetBool("txtinfogral", false);
        messageText.text = "";
    }

    private void TextView()
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