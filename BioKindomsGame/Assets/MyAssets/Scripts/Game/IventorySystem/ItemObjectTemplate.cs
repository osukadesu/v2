using UnityEngine;
using UnityEngine.UI;
public abstract class ItemObjectTemplate : MonoBehaviour
{
    [SerializeField] protected Animator txtAnim;
    [SerializeField] protected InventoryItemData referenceItem;
    [SerializeField] protected Text messageText;
    [SerializeField] protected bool item;
    void Awake()
    {
        AwakeCharge();
    }
    void Update()
    {
        PickupKeydown();
    }
    void AwakeCharge()
    {
        txtAnim = GameObject.FindGameObjectWithTag("txtGral").GetComponent<Animator>();
        messageText = GameObject.FindGameObjectWithTag("txtGral").GetComponent<Text>();
        referenceItem.itemIsCheck = false;
        messageText.text = "";
        txtAnim.SetBool("txtinfogral", false);
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
            txtAnim.SetBool("txtinfogral", true);
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
            txtAnim.SetBool("txtinfogral", true);
            messageText.text = "Presiona E para recoger " + "( " + referenceItem.itemName + " )";
            item = true;
            Debug.Log("In Enter");
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            txtAnim.SetBool("txtinfogral", false);
            messageText.text = "";
            item = false;
            Debug.Log("In Exit");
        }
    }
    protected internal abstract void OnHandlePickUp();
    protected internal abstract void OnHandlePickUpLoad();
}