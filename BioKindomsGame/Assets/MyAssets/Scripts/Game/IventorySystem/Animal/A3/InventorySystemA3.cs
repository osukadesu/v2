using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class InventorySystemA3 : MonoBehaviour
{
    public static InventorySystemA3 instance3;
    public delegate void onInventoryChangedEvent();
    public event onInventoryChangedEvent OnInventoryChangedEventCallBack;
    public Dictionary<InventoryItemData, InventoryItem> _itemDictionary;
    public List<InventoryItem> inventoryItems;
    [SerializeField] InventoryUIA3 inventoryUIA3;
    void Start()
    {
        instance3.OnInventoryChangedEventCallBack += inventoryUIA3.OnUpdateInventory;
    }
    private void Awake()
    {
        inventoryItems = new List<InventoryItem>();
        _itemDictionary = new Dictionary<InventoryItemData, InventoryItem>();
        Singleton();
    }
    private void Singleton()
    {
        if (instance3 != null)
        {
            Destroy(gameObject);
        }
        else
        {
            instance3 = this;
            DontDestroyOnLoad(gameObject);
        }
    }
    public void Add(InventoryItemData referenceData)
    {
        if (_itemDictionary.TryGetValue(referenceData, out InventoryItem value))
        {
            value.AddStack();
            OnInventoryChangedEventCallBack.Invoke();
        }
        else
        {
            InventoryItem newItem = new InventoryItem(referenceData);
            inventoryItems.Add(newItem);
            _itemDictionary.Add(referenceData, newItem);
            OnInventoryChangedEventCallBack.Invoke();
        }
    }
}