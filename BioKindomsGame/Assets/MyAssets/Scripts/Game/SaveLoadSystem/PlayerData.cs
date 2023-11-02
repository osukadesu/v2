[System.Serializable]
public class PlayerData
{
    public float[] position = new float[3];
    public bool[] animal, isCreated;
    public PlayerData(CraftBuilderBase craftBuilderBase, PlayerMove playerMove)
    {
        position[0] = playerMove.transform.position.x;
        position[1] = playerMove.transform.position.y;
        position[2] = playerMove.transform.position.z;
        animal[0] = craftBuilderBase._inventoryItemDatas[0].itemIsCheck;
        animal[1] = craftBuilderBase._inventoryItemDatas[1].itemIsCheck;
        animal[2] = craftBuilderBase._inventoryItemDatas[2].itemIsCheck;
        animal[3] = craftBuilderBase._inventoryItemDatas[3].itemIsCheck;
        animal[4] = craftBuilderBase._inventoryItemDatas[4].itemIsCheck;
        isCreated[0] = craftBuilderBase.isCreated;
    }
}