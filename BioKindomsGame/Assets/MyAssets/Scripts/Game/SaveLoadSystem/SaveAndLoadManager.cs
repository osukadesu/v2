using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveAndLoadManager
{
    public static void SaveDataGame(CraftBuilderSystem craftBuilderSystem, PlayerMove playerMove)
    {
        PlayerData playerData = new(craftBuilderSystem, playerMove);
        string datapath = Application.persistentDataPath + "/player.data";
        FileStream fileStream = new(datapath, FileMode.Create);
        BinaryFormatter binaryFormatter = new();
        binaryFormatter.Serialize(fileStream, playerData);
        Debug.Log("Save Game");
        fileStream.Close();
    }
    public static PlayerData LoadDataGame()
    {
        string datapath = Application.persistentDataPath + "/player.data";
        if (File.Exists(datapath))
        {
            FileStream fileStream = new(datapath, FileMode.Open);
            BinaryFormatter binaryFormatter = new();
            PlayerData playerData = (PlayerData)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            Debug.Log("Load Game");
            return playerData;
        }
        else
        {
            Debug.LogError("No se encontró la partida");
            return null;
        }
    }
}