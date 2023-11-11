using UnityEngine;
public class LoadGame : MonoBehaviour
{
    [SerializeField] CraftBuilderSystem craftBuilderSystem;
    [SerializeField] PlayerMove playerMove;
    [SerializeField] ItemObject IOA1P1, IOA1P2, IOA1P3, IOA1P4, IOA1P5;
    [SerializeField] InventoryUI inventoryUI;
    void Awake()
    {
        playerMove = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMove>();
        craftBuilderSystem = FindObjectOfType<CraftBuilderSystem>();
    }
    public void GoLoadGame()
    {
        InventorySystem.instance.OnInventoryChangedEventCallBack += inventoryUI.OnUpdateInventory;
        PlayerData playerData = SaveAndLoadManager.LoadDataGame();
        SetPlayerPosition(playerData);
        MappinAnimal1(playerData);
        CheckingDataAnimal1(playerData);
    }
    public void GoNewGame()
    {
        InventorySystem.instance.OnInventoryChangedEventCallBack += inventoryUI.OnUpdateInventory;
    }
    public void SetPlayerPosition(PlayerData playerData)
    {
        playerMove.transform.position = new Vector3(
            playerData.position[0],
            playerData.position[1],
            playerData.position[2]);
    }
    public void MappinAnimal1(PlayerData playerData)
    {
        craftBuilderSystem._InventoryItemDatas[0].itemIsCheck = playerData.animal11;
        craftBuilderSystem._InventoryItemDatas[1].itemIsCheck = playerData.animal12;
        craftBuilderSystem._InventoryItemDatas[2].itemIsCheck = playerData.animal13;
        craftBuilderSystem._InventoryItemDatas[3].itemIsCheck = playerData.animal14;
        craftBuilderSystem._InventoryItemDatas[4].itemIsCheck = playerData.animal15;
        craftBuilderSystem.IsCreated[0] = playerData.isCreatedA1;
    }
    public void CheckingDataAnimal1(PlayerData playerData)
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
}