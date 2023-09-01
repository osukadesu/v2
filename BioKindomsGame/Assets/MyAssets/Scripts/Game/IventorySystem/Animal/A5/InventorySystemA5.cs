using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InventorySystemA5 : MonoBehaviour
{
    public static InventorySystemA5 instance5;
    public delegate void onInventoryChangedEvent();
    public event onInventoryChangedEvent onInventoryChangedEventCallBack;
    public Dictionary<InventoryItemData, InventoryItem> _itemDictionary;
    public List<InventoryItem> inventoryItems;
    [SerializeField] InventoryUIA5 inventoryUIA5;
    void Start()
    {
        instance5.onInventoryChangedEventCallBack += inventoryUIA5.OnUpdateInventoryA5;
    }
    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
        inventoryItems = new List<InventoryItem>();
        _itemDictionary = new Dictionary<InventoryItemData, InventoryItem>();
        instance5 = this;
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