using UnityEngine;
public class ItemObjectA5 : ItemObjectTemplate
{
    protected internal override void OnHandlePickUp()
    {
        txtAnim.SetBool("txtinfogral", false);
        messageText.text = referenceItem.itemName + " Guardado!";
        InventorySystemA5.instance5.Add(referenceItem);
        referenceItem.itemIsCheck = true;
        Destroy(this.gameObject);
    }
    protected internal override void OnHandlePickUpLoad()
    {
        txtAnim.SetBool("txtinfogral", false);
        messageText.text = "";
        DisableCollider();
        InventorySystemA5.instance5.Add(referenceItem);
        referenceItem.itemIsCheck = true;
        Destroy(this.gameObject);
    }
}