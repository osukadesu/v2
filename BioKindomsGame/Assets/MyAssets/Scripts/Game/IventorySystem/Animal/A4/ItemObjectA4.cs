using UnityEngine;
using UnityEngine.UI;
public class ItemObjectA4 : ItemObjectTemplate
{
    protected internal override void OnHandlePickUp()
    {
        txtAnim.SetBool("txtinfogral", false);
        messageText.text = referenceItem.itemName + " Guardado!";
        InventorySystemA4.instance4.Add(referenceItem);
        referenceItem.itemIsCheck = true;
        Destroy(gameObject);
    }
    protected internal override void OnHandlePickUpLoad()
    {
        InventorySystemA4.instance4.Add(referenceItem);
        Destroy(gameObject);
    }
}