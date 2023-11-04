using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveAndLoadManager
{
    public static void InitialSave(CraftBuilderBase craftBuilderBase, PlayerMove playerMove)
    {
        PlayerData playerData = new(craftBuilderBase, playerMove);
        string datapath = Application.persistentDataPath + "/playerdefault.data";
        FileStream fileStream = new(datapath, FileMode.Create);
        BinaryFormatter binaryFormatter = new();
        binaryFormatter.Serialize(fileStream, playerData);
        fileStream.Close();
        Debug.Log("Nueva Partida Inicial");
    }
    public static PlayerData InitialLoad()
    {
        string datapath = Application.persistentDataPath + "/playerdefault.data";
        if (File.Exists(datapath))
        {
            FileStream fileStream = new(datapath, FileMode.Open);
            BinaryFormatter binaryFormatter = new();
            PlayerData playerData = (PlayerData)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            Debug.Log("Partida Inicial Encontrada!");
            return playerData;
        }
        else
        {
            Debug.LogError("No se encontró la partida");
            return null;
        }
    }
    public static void SaveDataGame(CraftBuilderBase craftBuilderBase, PlayerMove playerMove)
    {
        PlayerData playerData = new(craftBuilderBase, playerMove);
        string datapath = Application.persistentDataPath + "/player.data";
        FileStream fileStream = new(datapath, FileMode.Create);
        BinaryFormatter binaryFormatter = new();
        binaryFormatter.Serialize(fileStream, playerData);
        fileStream.Close();
        Debug.Log("Partida Guardada");
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
            Debug.Log("Partida Encontrada");
            return playerData;
        }
        else
        {
            Debug.LogError("No se encontró la partida");
            return null;
        }
    }
}