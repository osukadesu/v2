using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public float[] position = new float[3];
    public bool animal11, animal12, animal13, animal14, animal15, isCreatedA1,
    animal21, animal22, animal23, animal24, animal25, isCreatedA2;
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
}