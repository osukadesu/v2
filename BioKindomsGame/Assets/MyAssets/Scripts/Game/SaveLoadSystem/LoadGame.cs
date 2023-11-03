using System.Collections.Generic;
using UnityEngine;
public class LoadGame : MonoBehaviour
{
    public CraftBuilderBase craftBuilderBase;
    public PlayerMove playerMove;
    public ItemObject itemObjectA1;
    public InventoryUI inventoryUI;
    public void GoLoadGame()
    {   //refactorisar en metodo
        InventorySystem.instance.OnInventoryChangedEventCallBack += inventoryUI.OnUpdateInventory;
        PlayerData playerData = SaveAndLoadManager.LoadDataGame();
        //refactorisar en metodo
        craftBuilderBase._inventoryItemDatas[0].itemIsCheck = playerData.animal1[0];
        craftBuilderBase._inventoryItemDatas[1].itemIsCheck = playerData.animal1[1];
        craftBuilderBase._inventoryItemDatas[2].itemIsCheck = playerData.animal1[2];
        craftBuilderBase._inventoryItemDatas[3].itemIsCheck = playerData.animal1[3];
        craftBuilderBase._inventoryItemDatas[4].itemIsCheck = playerData.animal1[4];
        craftBuilderBase.isCreated = playerData.isCreatedA1[0];
        playerMove.transform.position = new Vector3(
        playerData.position[0],
        playerData.position[1],
        playerData.position[2]
         );
        Debug.Log("Partida encontrada");
        CheckingData(playerData);
    }
    public void CheckingData(PlayerData playerData)
    {
        if (playerData.animal1[0])
        {
            itemObjectA1.OnHandlePickUpLoad();
        }
        if (playerData.animal1[1])
        {
            itemObjectA1.OnHandlePickUpLoad();
        }
        if (playerData.animal1[2])
        {
            itemObjectA1.OnHandlePickUpLoad();
        }
        if (playerData.animal1[3])
        {
            itemObjectA1.OnHandlePickUpLoad();
        }
        if (playerData.animal1[4])
        {
            itemObjectA1.OnHandlePickUpLoad();
        }
    }
}