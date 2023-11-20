[System.Serializable]
public class PlayerData
{
    public float[] position = new float[3];
    public bool animal11, animal12, animal13, animal14, animal15, isCreatedA1,
    animal21, animal22, animal23, animal24, animal25, isCreatedA2,
    animal31, animal32, animal33, animal34, animal35, isCreatedA3,
    animal41, animal42, animal43, animal44, animal45, isCreatedA4,
    animal51, animal52, animal53, animal54, animal55, isCreatedA5;
    public int currentLevelData;
    public PlayerData(CraftBuilderSystem craftBuilderSystem, PlayerMove playerMove, LevelSystem levelSystem)
    {
        position[0] = playerMove.transform.position.x;
        position[1] = playerMove.transform.position.y;
        position[2] = playerMove.transform.position.z;
        MappingAnimals(craftBuilderSystem);
        currentLevelData = levelSystem.CurrentLevel;
    }
    void MappingAnimals(CraftBuilderSystem craftBuilderSystem)
    {
        MappinAnimal1(craftBuilderSystem);
        MappinAnimal2(craftBuilderSystem);
        MappinAnimal3(craftBuilderSystem);
        MappinAnimal4(craftBuilderSystem);
        MappinAnimal5(craftBuilderSystem);
    }

    void MappinAnimal1(CraftBuilderSystem craftBuilderSystem)
    {
        animal11 = craftBuilderSystem._InventoryItemDatas[0].itemIsCheck;
        animal12 = craftBuilderSystem._InventoryItemDatas[1].itemIsCheck;
        animal13 = craftBuilderSystem._InventoryItemDatas[2].itemIsCheck;
        animal14 = craftBuilderSystem._InventoryItemDatas[3].itemIsCheck;
        animal15 = craftBuilderSystem._InventoryItemDatas[4].itemIsCheck;
        isCreatedA1 = craftBuilderSystem.IsCreated[0];
    }
    void MappinAnimal2(CraftBuilderSystem craftBuilderSystem)
    {
        animal21 = craftBuilderSystem._InventoryItemDatas[5].itemIsCheck;
        animal22 = craftBuilderSystem._InventoryItemDatas[6].itemIsCheck;
        animal23 = craftBuilderSystem._InventoryItemDatas[7].itemIsCheck;
        animal24 = craftBuilderSystem._InventoryItemDatas[8].itemIsCheck;
        animal25 = craftBuilderSystem._InventoryItemDatas[9].itemIsCheck;
        isCreatedA2 = craftBuilderSystem.IsCreated[1];
    }
    void MappinAnimal3(CraftBuilderSystem craftBuilderSystem)
    {
        animal31 = craftBuilderSystem._InventoryItemDatas[10].itemIsCheck;
        animal32 = craftBuilderSystem._InventoryItemDatas[11].itemIsCheck;
        animal33 = craftBuilderSystem._InventoryItemDatas[12].itemIsCheck;
        animal34 = craftBuilderSystem._InventoryItemDatas[13].itemIsCheck;
        animal35 = craftBuilderSystem._InventoryItemDatas[14].itemIsCheck;
        isCreatedA3 = craftBuilderSystem.IsCreated[2];
    }
    void MappinAnimal4(CraftBuilderSystem craftBuilderSystem)
    {
        animal41 = craftBuilderSystem._InventoryItemDatas[15].itemIsCheck;
        animal42 = craftBuilderSystem._InventoryItemDatas[16].itemIsCheck;
        animal43 = craftBuilderSystem._InventoryItemDatas[17].itemIsCheck;
        animal44 = craftBuilderSystem._InventoryItemDatas[18].itemIsCheck;
        animal45 = craftBuilderSystem._InventoryItemDatas[19].itemIsCheck;
        isCreatedA4 = craftBuilderSystem.IsCreated[3];
    }
    void MappinAnimal5(CraftBuilderSystem craftBuilderSystem)
    {
        animal51 = craftBuilderSystem._InventoryItemDatas[20].itemIsCheck;
        animal52 = craftBuilderSystem._InventoryItemDatas[21].itemIsCheck;
        animal53 = craftBuilderSystem._InventoryItemDatas[22].itemIsCheck;
        animal54 = craftBuilderSystem._InventoryItemDatas[23].itemIsCheck;
        animal55 = craftBuilderSystem._InventoryItemDatas[24].itemIsCheck;
        isCreatedA5 = craftBuilderSystem.IsCreated[4];
    }
}