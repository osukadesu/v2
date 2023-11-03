public class ItemObjectA2 : ItemObjectTemplate
{
    protected internal override void OnHandlePickUp()
    {
        txtAnim.SetBool("txtinfogral", false);
        messageText.text = referenceItem.itemName + " Guardado!";
        InventorySystemA2.instance2.Add(referenceItem);
        referenceItem.itemIsCheck = true;
        Destroy(gameObject);
    }
    protected internal override void OnHandlePickUpLoad()
    {
        InventorySystemA2.instance2.Add(referenceItem);
        Destroy(gameObject);
    }
}