using UnityEngine;
using UnityEngine.UI;
public class ButtonSave : MonoBehaviour
{
    [SerializeField] Button buttonSave;
    [SerializeField] CraftBuilderBase craftBuilderBase;
    [SerializeField] PlayerMove playerMove;
    void Awake()
    {
        buttonSave.onClick.AddListener(() => MyButtonSave());
    }
    public void MyButtonSave()
    {
        SaveAndLoadManager.SaveDataGame(craftBuilderBase, playerMove);
    }
}