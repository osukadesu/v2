using UnityEngine;
using UnityEngine.UI;
public abstract class ItemObjectTemplate : MonoBehaviour
{
    [SerializeField] protected InventoryItemData referenceItem;
    [SerializeField] protected bool item;
    [SerializeField] protected TextGralController textGralController;
    protected string textMessage;
    void Awake()
    {
        AwakeCharge();
        textGralController = FindObjectOfType<TextGralController>();
    }
    void Update()
    {
        PickupKeydown();
    }
    void AwakeCharge()
    {
        referenceItem.itemIsCheck = false;
        item = false;
    }
    protected void DisableCollider()
    {
        gameObject.SetActive(false);
    }
    void PickupKeydown()
    {
        if (item && Input.GetKeyDown(KeyCode.E))
        {
            OnHandlePickUp();
        }
        else
        {
            referenceItem.itemIsCheck = false;
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            textMessage = "Presiona E para recoger " + "( " + referenceItem.itemName + " )";
            textGralController.ShowText(textMessage);
            item = true;
            Debug.Log("In Enter");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            textGralController.HideText();
            item = false;
            Debug.Log("In Exit");
        }
    }
    protected internal abstract void OnHandlePickUp();
    protected internal abstract void OnHandlePickUpLoad();
}