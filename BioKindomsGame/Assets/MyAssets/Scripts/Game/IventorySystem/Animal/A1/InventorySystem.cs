using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InventorySystem : MonoBehaviour
{
    public static InventorySystem instance;
    public delegate void onInventoryChangedEvent();
    public event onInventoryChangedEvent onInventoryChangedEventCallBack;
    public Dictionary<InventoryItemData, InventoryItem> _itemDictionary;
    public List<InventoryItem> inventoryItems;
    [SerializeField] InventoryUI inventoryUI;
    void Start()
    {
        instance.onInventoryChangedEventCallBack += inventoryUI.OnUpdateInventory;
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        inventoryItems = new List<InventoryItem>();
        _itemDictionary = new Dictionary<InventoryItemData, InventoryItem>();
        instance = this;
    }
    public void Add(InventoryItemData referenceData)
    {
        if (_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            value.AddStack();
            onInventoryChangedEventCallBack.Invoke();
        }
        else
        {
            InventoryItem newItem = new InventoryItem(referenceData);
            inventoryItems.Add(newItem);
            _itemDictionary.Add(referenceData, newItem);
            onInventoryChangedEventCallBack.Invoke();
        }
    }
}