using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveManager
{
    public static void SavePlayer(PlayerController player)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        FileStream file = File.Create(Application.persistentDataPath + "/score.data");

        PlayerData data = new PlayerData(player);

        formatter.Serialize(file, data);
        file.Close();

    }

    public static PlayerData LoadScore()
    {
        if (File.Exists(Application.persistentDataPath + "/score.data"))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            FileStream fileScore = File.Open(Application.persistentDataPath + "/score.data", FileMode.Open);
            
            PlayerData data = formatter.Deserialize(fileScore) as PlayerData;
            
            fileScore.Close();

            return data;

        }

        else
        {
            Debug.LogError("Save file not found");
            return null;
        }
    }

    public static void DeleteSave()
    {
        if(File.Exists(Application.persistentDataPath + "/score.data"))
        {
            File.Delete(Application.persistentDataPath + "/score.data");

            Debug.Log("Save file deleted");
        }
            
    }
}
