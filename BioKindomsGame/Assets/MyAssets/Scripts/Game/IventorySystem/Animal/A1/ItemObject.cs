public class ItemObject : ItemObjectTemplate
{
    protected internal override void OnHandlePickUp()
    {
        txtAnim.SetBool("txtinfogral", false);
        messageText.text = referenceItem.itemName + " Guardado!";
        InventorySystem.instance.Add(referenceItem);
        referenceItem.itemIsCheck = true;
        Destroy(gameObject);
    }
    protected internal override void OnHandlePickUpLoad()
    {
        txtAnim.SetBool("txtinfogral", false);
        messageText.text = "";
        InventorySystem.instance.Add(referenceItem);
        referenceItem.itemIsCheck = true;
        Destroy(gameObject);
    }
}