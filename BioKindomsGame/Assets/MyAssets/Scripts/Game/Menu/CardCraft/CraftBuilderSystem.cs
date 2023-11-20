using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class CraftBuilderSystem : MonoBehaviour
{
    [SerializeField] CanvasManager _canvasManager;
    [SerializeField] Button[] btnBuilder, btnItemCraft;
    [SerializeField] bool[] isCreated;
    [SerializeField] LevelSystem levelSystem;
    public bool[] IsCreated
    {
        get { return isCreated; }
        set { isCreated = value; }
    }
    [SerializeField] Animator[] animCheck, animInfo, animFillImgItem, animUnLock;
    [SerializeField] GameObject[] imageHide;
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
        levelSystem = FindObjectOfType<LevelSystem>();
        InicialState();
        btnBuilder[0].onClick.AddListener(() => _canvasManager.CraftAnimal1());
        btnBuilder[1].onClick.AddListener(() => _canvasManager.CraftAnimal2());
        btnBuilder[2].onClick.AddListener(() => _canvasManager.CraftAnimal3());
        btnBuilder[3].onClick.AddListener(() => _canvasManager.CraftAnimal4());
        btnBuilder[4].onClick.AddListener(() => _canvasManager.CraftAnimal5());
    }
    void InicialState()
    {
        levelSystem.plataformEnd.SetActive(false);
        for (int i = 0; i < 5; i++)
        {
            btnBuilder[i].interactable = false;
            btnItemCraft[i].interactable = true;
            animFillImgItem[i].SetBool("fillimgitem", false);
            animUnLock[i].SetBool("itemunlock", false);
            isCreated[i] = false;
        }
        for (int i = 0; i < 4; i++)
        {
            imageHide[i].SetActive(true);
        }
    }
    void Update()
    {
        UnlockBuildAll();
    }
    public void UnlockBuildAll()
    {
        PartAnimal();
    }
    private void PartAnimal()
    {
        UnlockAnimal1();
        UnlockAnimal2();
        UnlockAnimal3();
        UnlockAnimal4();
        UnlockAnimal5();
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
    void UnlockAnimal3()
    {
        if (_inventoryItemDatas[10].itemIsCheck && _inventoryItemDatas[11].itemIsCheck && _inventoryItemDatas[12].itemIsCheck && _inventoryItemDatas[13].itemIsCheck && _inventoryItemDatas[14].itemIsCheck)
        {
            btnBuilder[2].interactable = true;
        }
        else
        {
            btnBuilder[2].interactable = false;
        }
    }
    void UnlockAnimal4()
    {
        if (_inventoryItemDatas[15].itemIsCheck && _inventoryItemDatas[16].itemIsCheck && _inventoryItemDatas[17].itemIsCheck && _inventoryItemDatas[18].itemIsCheck && _inventoryItemDatas[19].itemIsCheck)
        {
            btnBuilder[3].interactable = true;
        }
        else
        {
            btnBuilder[3].interactable = false;
        }
    }
    void UnlockAnimal5()
    {
        if (_inventoryItemDatas[20].itemIsCheck && _inventoryItemDatas[21].itemIsCheck && _inventoryItemDatas[22].itemIsCheck && _inventoryItemDatas[23].itemIsCheck && _inventoryItemDatas[24].itemIsCheck)
        {
            btnBuilder[4].interactable = true;
        }
        else
        {
            btnBuilder[4].interactable = false;
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
        imageHide[0].SetActive(false);
        levelSystem.plataformEnd.SetActive(true);
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
        imageHide[1].SetActive(false);
        levelSystem.plataformEnd.SetActive(true);
    }
    public void ButtonBuildAnimal3()
    {
        btnBuilder[2].interactable = false;
        btnItemCraft[2].interactable = false;
        animCheck[2].SetBool("check", true);
        animInfo[2].SetBool("btninfoview", true);
        animFillImgItem[2].SetBool("fillimgitem", true);
        isCreated[2] = true;
        animUnLock[2].SetBool("itemunlock", true);
        imageHide[2].SetActive(false);
        levelSystem.plataformEnd.SetActive(true);
    }
    public void ButtonBuildAnimal4()
    {
        btnBuilder[3].interactable = false;
        btnItemCraft[3].interactable = false;
        animCheck[3].SetBool("check", true);
        animInfo[3].SetBool("btninfoview", true);
        animFillImgItem[3].SetBool("fillimgitem", true);
        isCreated[3] = true;
        animUnLock[3].SetBool("itemunlock", true);
        imageHide[3].SetActive(false);
        levelSystem.plataformEnd.SetActive(true);
    }
    public void ButtonBuildAnimal5()
    {
        btnBuilder[4].interactable = false;
        btnItemCraft[4].interactable = false;
        animCheck[4].SetBool("check", true);
        animInfo[4].SetBool("btninfoview", true);
        animFillImgItem[4].SetBool("fillimgitem", true);
        isCreated[4] = true;
        StartCoroutine(NextKindomDelay());
        levelSystem.plataformEnd.SetActive(true);
    }
    IEnumerator NextKindomDelay()
    {
        yield return new WaitForSeconds(1f);
        animUnLock[4].SetBool("itemunlock", true);
        imageHide[4].SetActive(false);
    }
}