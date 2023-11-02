using UnityEditor.SearchService;
using UnityEngine.SceneManagement;

public class CraftAnimal1 : CraftBuilderBase
{
    void Awake()
    {
        btnBuilder.onClick.AddListener(() => _canvasManager.CraftAnimal1());
    }
    void Start()
    {
        btnBuilder.interactable = false;
        btnItemCraft.interactable = true;
        animFillImgItem.SetBool("fillimgitem", false);
        animUnLock.SetBool("itemunlock", false);
        isCreated = false;
    }
    protected internal override void UnlockBuild()
    {
        if (_inventoryItemDatas[0].itemIsCheck && _inventoryItemDatas[1].itemIsCheck && _inventoryItemDatas[2].itemIsCheck && _inventoryItemDatas[3].itemIsCheck && _inventoryItemDatas[4].itemIsCheck)
        {
            btnBuilder.interactable = true;
        }
        else
        {
            btnBuilder.interactable = false;
        }
    }
    protected internal override void ButtonBuild()
    {
        btnBuilder.interactable = false;
        btnItemCraft.interactable = false;
        animCheck.SetBool("check", true);
        animInfo.SetBool("btninfoview", true);
        animFillImgItem.SetBool("fillimgitem", true);
        isCreated = true;
        animUnLock.SetBool("itemunlock", true);
        SceneManager.LoadScene(3);
    }
}
