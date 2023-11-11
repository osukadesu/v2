using UnityEngine;
using UnityEngine.UI;
public class ItemObjectA3 : ItemObjectTemplate
{
    protected internal override void OnHandlePickUp()
    {
        txtAnim.SetBool("txtinfogral", false);
        messageText.text = referenceItem.itemName + " Guardado!";
        InventorySystemA3.instance3.Add(referenceItem);
        referenceItem.itemIsCheck = true;
        Destroy(gameObject);
    }
    protected internal override void OnHandlePickUpLoad()
    {
        InventorySystemA3.instance3.Add(referenceItem);
        referenceItem.itemIsCheck = true;
        Destroy(gameObject);
    }
}