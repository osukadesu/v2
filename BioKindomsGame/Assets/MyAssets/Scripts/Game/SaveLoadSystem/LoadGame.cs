using UnityEngine;
public class LoadGame : MonoBehaviour
{
    [SerializeField] CraftBuilderSystem craftBuilderSystem;
    [SerializeField] LevelSystem levelSystem;
    [SerializeField] PlayerMove playerMove;
    [SerializeField] ItemObject IOA1P1, IOA1P2, IOA1P3, IOA1P4, IOA1P5;
    [SerializeField] ItemObjectA2 IOA2P1, IOA2P2, IOA2P3, IOA2P4, IOA2P5;
    [SerializeField] InventoryUI inventoryUI;
    [SerializeField] InventoryUIA2 inventoryUIA2;
    [SerializeField] float timerLoad;
    void Awake()
    {
        playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        craftBuilderSystem = FindObjectOfType<CraftBuilderSystem>();
        levelSystem = FindObjectOfType<LevelSystem>();
        timerLoad = 1.0f;
    }
    void Update()
    {
        timerLoad -= .5f * Time.deltaTime;
    }
    public void GoLoadGame()
    {
        if (timerLoad <= .0f)
        {
            InventorySystem.instance.OnInventoryChangedEventCallBack += inventoryUI.OnUpdateInventory;
            InventorySystemA2.instance2.OnInventoryChangedEventCallBack += inventoryUIA2.OnUpdateInventory;
            PlayerData playerData = SaveAndLoadManager.LoadDataGame();
            SetPlayerPosition(playerData);
            MappingAnimals(playerData);
            CheckingAnimals(playerData);
            timerLoad = 0;
        }
    }
    public void GoNewGame()
    {
        if (timerLoad <= .0f)
        {
            InventorySystem.instance.OnInventoryChangedEventCallBack += inventoryUI.OnUpdateInventory;
            InventorySystemA2.instance2.OnInventoryChangedEventCallBack += inventoryUIA2.OnUpdateInventory;
            timerLoad = 0;
        }
    }
    public void SetPlayerPosition(PlayerData playerData)
    {
        playerMove.transform.position = new Vector3(
            playerData.position[0],
            playerData.position[1],
            playerData.position[2]);
    }
    void MappingAnimals(PlayerData playerData)
    {
        MappinAnimal1(playerData);
        MappinAnimal2(playerData);
    }
    void MappinAnimal1(PlayerData playerData)
    {
        craftBuilderSystem._InventoryItemDatas[0].itemIsCheck = playerData.animal11;
        craftBuilderSystem._InventoryItemDatas[1].itemIsCheck = playerData.animal12;
        craftBuilderSystem._InventoryItemDatas[2].itemIsCheck = playerData.animal13;
        craftBuilderSystem._InventoryItemDatas[3].itemIsCheck = playerData.animal14;
        craftBuilderSystem._InventoryItemDatas[4].itemIsCheck = playerData.animal15;
        craftBuilderSystem.IsCreated[0] = playerData.isCreatedA1;
    }
    void MappinAnimal2(PlayerData playerData)
    {
        craftBuilderSystem._InventoryItemDatas[5].itemIsCheck = playerData.animal21;
        craftBuilderSystem._InventoryItemDatas[6].itemIsCheck = playerData.animal22;
        craftBuilderSystem._InventoryItemDatas[7].itemIsCheck = playerData.animal23;
        craftBuilderSystem._InventoryItemDatas[8].itemIsCheck = playerData.animal24;
        craftBuilderSystem._InventoryItemDatas[9].itemIsCheck = playerData.animal25;
        craftBuilderSystem.IsCreated[1] = playerData.isCreatedA2;
    }
    void CheckingAnimals(PlayerData playerData)
    {
        CheckingDataAnimal1(playerData);
        CheckingDataAnimal2(playerData);
    }
    void CheckingDataAnimal1(PlayerData playerData)
    {
        if (playerData.animal11)
        {
            IOA1P1.OnHandlePickUpLoad();
        }
        if (playerData.animal12)
        {
            IOA1P2.OnHandlePickUpLoad();
        }
        if (playerData.animal13)
        {
            IOA1P3.OnHandlePickUpLoad();
        }
        if (playerData.animal14)
        {
            IOA1P4.OnHandlePickUpLoad();
        }
        if (playerData.animal15)
        {
            IOA1P5.OnHandlePickUpLoad();
        }
        if (playerData.isCreatedA1)
        {
            craftBuilderSystem.ButtonBuildAnimal1();
        }
    }
    void CheckingDataAnimal2(PlayerData playerData)
    {
        if (playerData.animal21)
        {
            IOA2P1.OnHandlePickUpLoad();
        }
        if (playerData.animal22)
        {
            IOA2P2.OnHandlePickUpLoad();
        }
        if (playerData.animal23)
        {
            IOA2P3.OnHandlePickUpLoad();
        }
        if (playerData.animal24)
        {
            IOA2P4.OnHandlePickUpLoad();
        }
        if (playerData.animal25)
        {
            IOA2P5.OnHandlePickUpLoad();
        }
        if (playerData.isCreatedA2)
        {
            craftBuilderSystem.ButtonBuildAnimal2();
        }
    }
}