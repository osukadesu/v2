using System.Collections.Generic;
using UnityEngine;
public class LoadGame : MonoBehaviour
{
    public CraftBuilderBase craftBuilderBase;
    public PlayerMove playerMove;
    public ItemObject itemObjectA1;
    public ItemObjectA2 itemObjectA2;
    public ItemObjectA3 itemObjectA3;
    public ItemObjectA4 itemObjectA4;
    public ItemObjectA5 itemObjectA5;
    public InventoryUI inventoryUI;
    public InventoryUIA2 inventoryUIA2;
    public InventoryUIA3 inventoryUIA3;
    public InventoryUIA4 inventoryUIA4;
    public InventoryUIA5 inventoryUIA5;
    public void GoLoadGame()
    {
        InventorySystem.instance.OnInventoryChangedEventCallBack += inventoryUI.OnUpdateInventory;
        InventorySystemA2.instance2.OnInventoryChangedEventCallBack += inventoryUIA2.OnUpdateInventoryA2;
        InventorySystemA3.instance3.OnInventoryChangedEventCallBack += inventoryUIA3.OnUpdateInventoryA3;
        InventorySystemA4.instance4.OnInventoryChangedEventCallBack += inventoryUIA4.OnUpdateInventoryA4;
        InventorySystemA5.instance5.OnInventoryChangedEventCallBack += inventoryUIA5.OnUpdateInventoryA5;
        PlayerData playerData = SaveAndLoadManager.LoadDataGame();
        craftBuilderBase._inventoryItemDatas[0].itemIsCheck = playerData.animal[0];
        craftBuilderBase._inventoryItemDatas[1].itemIsCheck = playerData.animal[1];
        craftBuilderBase._inventoryItemDatas[2].itemIsCheck = playerData.animal[2];
        craftBuilderBase._inventoryItemDatas[3].itemIsCheck = playerData.animal[3];
        craftBuilderBase._inventoryItemDatas[4].itemIsCheck = playerData.animal[4];
        craftBuilderBase.isCreated = playerData.isCreated[0];
        playerMove.transform.position = new Vector3(
        playerData.position[0],
        playerData.position[1],
        playerData.position[2]
         );
        Debug.Log("Partida encontrada");
        isApproved(playerData);
    }
    public void isApproved(PlayerData playerData)
    {
        if (playerData.animal[0])
        {
            itemObjectA1.OnHandlePickUpLoad();
        }
        if (playerData.animal[1])
        {
            itemObjectA2.OnHandlePickUpLoad();
        }
        if (playerData.animal[2])
        {
            itemObjectA3.OnHandlePickUpLoad();
        }
        if (playerData.animal[3])
        {
            itemObjectA4.OnHandlePickUpLoad();
        }
        if (playerData.animal[4])
        {
            itemObjectA5.OnHandlePickUpLoad();
        }
    }
}