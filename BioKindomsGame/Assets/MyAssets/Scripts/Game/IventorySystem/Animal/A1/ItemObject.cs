using UnityEngine;
using UnityEngine.UI;
public class ItemObject : MonoBehaviour
{
    public Animator txtAnim;
    public InventoryItemData referenceItem;
    public Text messageText;
    public bool item;
    private void Start()
    {
        item = false;
        messageText.text = "";
        txtAnim.SetBool("txtinfogral", false);
    }
    void Awake()
    {
        referenceItem.itemIsCheck = false;
    }
    private void Update()
    {
        if (item && Input.GetKeyDown(KeyCode.E))
        {
            txtAnim.SetBool("txtinfogral", false);
            OnHandlePickUp();
        }
        else
        {
            referenceItem.itemIsCheck = false;
        }
    }
    public void OnHandlePickUp()
    {
        txtAnim.SetBool("txtinfogral", false);
        messageText.text = referenceItem.itemName + " Guardado!";
        InventorySystem.instance.Add(referenceItem);
        referenceItem.itemIsCheck = true;
        Destroy(gameObject);
    }
    public void OnHandlePickUpLoad()
    {
        InventorySystem.instance.Add(referenceItem);
        Destroy(gameObject);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            txtAnim.SetBool("txtinfogral", true);
            messageText.text = "Presiona E para recoger " + "( " + referenceItem.itemName + " )";
            item = true;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            txtAnim.SetBool("txtinfogral", false);
            messageText.text = "";
            item = false;
        }
    }
}