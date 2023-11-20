public class ItemObjectA4 : ItemObjectTemplate
{
    protected internal override void OnHandlePickUp()
    {
        textMessage = referenceItem.itemName + " Guardado!";
        textGralController.StartingAT2(textMessage);
        InventorySystemA4.instance4.Add(referenceItem);
        referenceItem.itemIsCheck = true;
        Destroy(this.gameObject);
    }
    protected internal override void OnHandlePickUpLoad()
    {
        DisableCollider();
        InventorySystemA4.instance4.Add(referenceItem);
        referenceItem.itemIsCheck = true;
        Destroy(this.gameObject);
    }
}