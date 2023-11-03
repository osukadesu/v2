[System.Serializable]
public class PlayerData
{
    public float[] position = new float[3];
    public bool[] animal1, isCreatedA1;
    public PlayerData(CraftBuilderBase craftBuilderBase, PlayerMove playerMove)
    {
        position[0] = playerMove.transform.position.x;
        position[1] = playerMove.transform.position.y;
        position[2] = playerMove.transform.position.z;
        Animal1Check(craftBuilderBase);
        isCreatedA1[0] = craftBuilderBase.isCreated;
    }
    private void Animal1Check(CraftBuilderBase craftBuilderBase)
    {
        animal1[0] = craftBuilderBase._inventoryItemDatas[0].itemIsCheck;
        animal1[1] = craftBuilderBase._inventoryItemDatas[1].itemIsCheck;
        animal1[2] = craftBuilderBase._inventoryItemDatas[2].itemIsCheck;
        animal1[3] = craftBuilderBase._inventoryItemDatas[3].itemIsCheck;
        animal1[4] = craftBuilderBase._inventoryItemDatas[4].itemIsCheck;
    }
}