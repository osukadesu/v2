using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveAndLoadManager
{
    public static void SaveDataGame(CraftBuilderBase craftBuilderBase, PlayerMove playerMove)
    {
        PlayerData playerData = new PlayerData(craftBuilderBase, playerMove);
        string datapath = Application.persistentDataPath + "/player.data";
        FileStream fileStream = new FileStream(datapath, FileMode.Create);
        BinaryFormatter binaryFormatter = new BinaryFormatter();
        binaryFormatter.Serialize(fileStream, playerData);
        fileStream.Close();
        Debug.Log("Partida Guardada");
    }
    public static PlayerData LoadDataGame()
    {
        string datapath = Application.persistentDataPath + "/player.data";
        if (File.Exists(datapath))
        {
            FileStream fileStream = new FileStream(datapath, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            PlayerData playerData = (PlayerData)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return playerData;
        }
        else
        {
            Debug.LogError("No se encontró la partida");
            return null;
        }
    }
    public static PlayerData LoadNewGame()
    {
        string datapath = Application.persistentDataPath + "/playerdefault.data";
        if (File.Exists(datapath))
        {
            FileStream fileStream = new FileStream(datapath, FileMode.Open);
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            PlayerData playerData = (PlayerData)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return playerData;
        }
        else
        {
            Debug.LogError("No se encontró la partida");
            return null;
        }
    }
}