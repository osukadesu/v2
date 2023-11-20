public class ItemObjectA5 : ItemObjectTemplate
{
    protected internal override void OnHandlePickUp()
    {
        textMessage = referenceItem.itemName + " Guardado!";
        textGralController.StartingAT2(textMessage);
        InventorySystemA5.instance5.Add(referenceItem);
        referenceItem.itemIsCheck = true;
        Destroy(this.gameObject);
    }
    protected internal override void OnHandlePickUpLoad()
    {
        DisableCollider();
        InventorySystemA5.instance5.Add(referenceItem);
        referenceItem.itemIsCheck = true;
        Destroy(this.gameObject);
    }
}