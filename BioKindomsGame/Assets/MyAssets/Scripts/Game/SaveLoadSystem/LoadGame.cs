using UnityEngine;
public class LoadGame : MonoBehaviour
{
    public CraftBuilderBase craftBuilderBase;
    public PlayerMove playerMove;
    public ItemObject[] itemObjectA1;
    public InventoryUI inventoryUI;
    public void GoLoadGame()
    {
        InventorySystem.instance.OnInventoryChangedEventCallBack += inventoryUI.OnUpdateInventory;
        PlayerData playerData = SaveAndLoadManager.LoadDataGame();
        MappinAnimal1(playerData);
        SetPlayerPosition(playerData);
        Debug.Log("GoLoadGame");
        CheckingData(playerData);
    }
    public void GoInitialLoad()
    {
        InventorySystem.instance.OnInventoryChangedEventCallBack += inventoryUI.OnUpdateInventory;
        PlayerData playerData = SaveAndLoadManager.InitialLoad();
        MappinAnimal1(playerData);
        SetPlayerPosition(playerData);
        Debug.Log("GoInitialLoad");
        CheckingData(playerData);
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
        craftBuilderBase._inventoryItemDatas[0].itemIsCheck = playerData.animal11;
        craftBuilderBase._inventoryItemDatas[1].itemIsCheck = playerData.animal12;
        craftBuilderBase._inventoryItemDatas[2].itemIsCheck = playerData.animal13;
        craftBuilderBase._inventoryItemDatas[3].itemIsCheck = playerData.animal14;
        craftBuilderBase._inventoryItemDatas[4].itemIsCheck = playerData.animal15;
        craftBuilderBase.isCreated = playerData.isCreatedA1;
    }

    public void CheckingData(PlayerData playerData)
    {
        if (playerData.animal11)
        {
            itemObjectA1[0].OnHandlePickUpLoad();
        }
        if (playerData.animal12)
        {
            itemObjectA1[1].OnHandlePickUpLoad();
        }
        if (playerData.animal13)
        {
            itemObjectA1[2].OnHandlePickUpLoad();
        }
        if (playerData.animal14)
        {
            itemObjectA1[3].OnHandlePickUpLoad();
        }
        if (playerData.animal15)
        {
            itemObjectA1[4].OnHandlePickUpLoad();
        }
    }
}