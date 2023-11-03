using UnityEngine;
using UnityEngine.UI;
public class ItemObjectA5 : ItemObjectTemplate
{
    protected internal override void OnHandlePickUp()
    {
        txtAnim.SetBool("txtinfogral", false);
        messageText.text = referenceItem.itemName + " Guardado!";
        InventorySystemA5.instance5.Add(referenceItem);
        referenceItem.itemIsCheck = true;
        Destroy(gameObject);
    }
    protected internal override void OnHandlePickUpLoad()
    {
        InventorySystemA5.instance5.Add(referenceItem);
        Destroy(gameObject);
    }
}