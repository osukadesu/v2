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
        txtAnim = GameObject.FindGameObjectWithTag("txtGral").GetComponent<Animator>();
        messageText = GameObject.FindGameObjectWithTag("txtGral").GetComponent<Text>();
    }
    void Start()
    {
        item = false;
        messageText.text = "";
        txtAnim.SetBool("txtinfogral", false);
        referenceItem.itemIsCheck = false;
    }
    void Update()
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
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            txtAnim.SetBool("txtinfogral", false);
            messageText.text = "";
            item = false;
        }
    }
    protected internal abstract void OnHandlePickUp();
    protected internal abstract void OnHandlePickUpLoad();

}