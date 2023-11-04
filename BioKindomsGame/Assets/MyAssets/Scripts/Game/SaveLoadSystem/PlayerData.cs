[System.Serializable]
public class PlayerData
{
    public float[] position = new float[3];
    public bool animal11, animal12, animal13, animal14, animal15, isCreatedA1;
    public PlayerData(CraftBuilderBase craftBuilderBase, PlayerMove playerMove)
    {
        position[0] = playerMove.transform.position.x;
        position[1] = playerMove.transform.position.y;
        position[2] = playerMove.transform.position.z;
        animal11 = craftBuilderBase._inventoryItemDatas[0].itemIsCheck;
        animal12 = craftBuilderBase._inventoryItemDatas[1].itemIsCheck;
        animal13 = craftBuilderBase._inventoryItemDatas[2].itemIsCheck;
        animal14 = craftBuilderBase._inventoryItemDatas[3].itemIsCheck;
        animal15 = craftBuilderBase._inventoryItemDatas[4].itemIsCheck;
        isCreatedA1 = craftBuilderBase.isCreated;
    }
}