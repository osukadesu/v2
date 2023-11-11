[System.Serializable]
public class PlayerData
{
    public float[] position = new float[3];
    public bool animal11, animal12, animal13, animal14, animal15, isCreatedA1;
    public PlayerData(CraftBuilderSystem craftBuilderSystem, PlayerMove playerMove)
    {
        position[0] = playerMove.transform.position.x;
        position[1] = playerMove.transform.position.y;
        position[2] = playerMove.transform.position.z;
        MappinAnimal1(craftBuilderSystem);
    }
    private void MappinAnimal1(CraftBuilderSystem craftBuilderSystem)
    {
        animal11 = craftBuilderSystem._InventoryItemDatas[0].itemIsCheck;
        animal12 = craftBuilderSystem._InventoryItemDatas[1].itemIsCheck;
        animal13 = craftBuilderSystem._InventoryItemDatas[2].itemIsCheck;
        animal14 = craftBuilderSystem._InventoryItemDatas[3].itemIsCheck;
        animal15 = craftBuilderSystem._InventoryItemDatas[4].itemIsCheck;
        isCreatedA1 = craftBuilderSystem.IsCreated[0];
    }
}