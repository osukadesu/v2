using UnityEngine;
using UnityEngine.UI;
public class CraftBuilderSystem : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button[] btnBuilder, btnItemCraft;
    [SerializeField] bool[] isCreated;
    public bool[] IsCreated
    {
        get { return isCreated; }
        set { isCreated = value; }
    }
    [SerializeField] Animator[] animCheck, animInfo, animFillImgItem, animUnLock;
    [SerializeField] InventoryItemData[] _inventoryItemDatas;
    public InventoryItemData[] _InventoryItemDatas
    {
        get { return _inventoryItemDatas; }
        set { _inventoryItemDatas = value; }
    }
    public void Configure(CanvasManager canvasManager)
    {
        _canvasManager = canvasManager;
    }
    void Awake()
    {
        InicialState();
        btnBuilder[0].onClick.AddListener(() => _canvasManager.CraftAnimal1());
        btnBuilder[1].onClick.AddListener(() => _canvasManager.CraftAnimal2());
        /*
         btnBuilder[2].onClick.AddListener(() => _canvasManager.CraftAnimal3());
         btnBuilder[3].onClick.AddListener(() => _canvasManager.CraftAnimal4());
         btnBuilder[4].onClick.AddListener(() => _canvasManager.CraftAnimal5());
        */
    }
    void InicialState()
    {
        Animal1(); Animal2();
    }
    void Animal1()
    {
        btnBuilder[0].interactable = false;
        btnItemCraft[0].interactable = true;
        animFillImgItem[0].SetBool("fillimgitem", false);
        animUnLock[0].SetBool("itemunlock", false);
        isCreated[0] = false;
    }
    void Animal2()
    {
        btnBuilder[1].interactable = false;
        btnItemCraft[1].interactable = true;
        animFillImgItem[1].SetBool("fillimgitem", false);
        animUnLock[1].SetBool("itemunlock", false);
        isCreated[1] = false;
    }
    void Update()
    {
        UnlockBuildAll();
    }
    public void UnlockBuildAll()
    {
        UnlockAnimal1();
        UnlockAnimal2();
    }
    void UnlockAnimal1()
    {
        if (_inventoryItemDatas[0].itemIsCheck && _inventoryItemDatas[1].itemIsCheck && _inventoryItemDatas[2].itemIsCheck && _inventoryItemDatas[3].itemIsCheck && _inventoryItemDatas[4].itemIsCheck)
        {
            btnBuilder[0].interactable = true;
        }
        else
        {
            btnBuilder[0].interactable = false;
        }
    }
    void UnlockAnimal2()
    {
        if (_inventoryItemDatas[5].itemIsCheck && _inventoryItemDatas[6].itemIsCheck && _inventoryItemDatas[7].itemIsCheck && _inventoryItemDatas[8].itemIsCheck && _inventoryItemDatas[9].itemIsCheck)
        {
            btnBuilder[1].interactable = true;
        }
        else
        {
            btnBuilder[1].interactable = false;
        }
    }
    public void ButtonBuildAnimal1()
    {
        btnBuilder[0].interactable = false;
        btnItemCraft[0].interactable = false;
        animCheck[0].SetBool("check", true);
        animInfo[0].SetBool("btninfoview", true);
        animFillImgItem[0].SetBool("fillimgitem", true);
        isCreated[0] = true;
        animUnLock[0].SetBool("itemunlock", true);
    }
    public void ButtonBuildAnimal2()
    {
        btnBuilder[1].interactable = false;
        btnItemCraft[1].interactable = false;
        animCheck[1].SetBool("check", true);
        animInfo[1].SetBool("btninfoview", true);
        animFillImgItem[1].SetBool("fillimgitem", true);
        isCreated[1] = true;
        animUnLock[1].SetBool("itemunlock", true);
    }
}