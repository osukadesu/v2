using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
public static class SaveAndLoadManager
{
    [SerializeField] private static bool fileExist;
    public static bool MyFileExist { get { return fileExist; } set { fileExist = value; } }
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
            MyFileExist = true;
            FileStream fileStream = new(datapath, FileMode.Open);
            BinaryFormatter binaryFormatter = new();
            PlayerData playerData = (PlayerData)binaryFormatter.Deserialize(fileStream);
            fileStream.Close();
            return playerData;
        }
        else
        {
            Debug.LogError("No se encontró la partida");
            MyFileExist = false;
            return null;
        }
    }
    public static PlayerData LoadNewGame()
    {
        string datapath = Application.persistentDataPath + "/playerdefault.data";
        if (File.Exists(datapath))
        {
            FileStream fileStream = new(datapath, FileMode.Open);
            BinaryFormatter binaryFormatter = new();
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