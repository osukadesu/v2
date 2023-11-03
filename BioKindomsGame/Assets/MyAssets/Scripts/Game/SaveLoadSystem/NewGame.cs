using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NewGame : MonoBehaviour
{
    public InventoryUI inventoryUI;
    public InventoryUIA2 inventoryUIA2;
    public InventoryUIA3 inventoryUIA3;
    public InventoryUIA4 inventoryUIA4;
    public InventoryUIA5 inventoryUIA5;
    public void GoNewGame()
    {
        AnimalInventoryEvent();
        _ = SaveAndLoadManager.LoadNewGame();
        Debug.Log("Partida Creada");
    }

    private void AnimalInventoryEvent()
    {
        InventorySystem.instance.OnInventoryChangedEventCallBack += inventoryUI.OnUpdateInventory;
        InventorySystemA2.instance2.OnInventoryChangedEventCallBack += inventoryUIA2.OnUpdateInventory;
        InventorySystemA3.instance3.OnInventoryChangedEventCallBack += inventoryUIA3.OnUpdateInventory;
        InventorySystemA4.instance4.OnInventoryChangedEventCallBack += inventoryUIA4.OnUpdateInventory;
        InventorySystemA5.instance5.OnInventoryChangedEventCallBack += inventoryUIA5.OnUpdateInventory;
    }
}
