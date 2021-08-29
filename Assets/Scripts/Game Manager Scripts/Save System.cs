using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    static string saveFileName = "gamedata.data";

	public static void LoadGameData()
	{
		// Save File path
		string path = Application.persistentDataPath + saveFileName;

		//Check if save file exists
		if (!File.Exists(path))
		{
			// Log ERROR and return
			Debug.Log("Save File not found in" + path);
			return;
		}

		// Open file that path
		FileStream fileStream = new FileStream(path, FileMode.Open);

		// Deserializing data from binary using Binary Formatter -----
		BinaryFormatter formatter = new BinaryFormatter();
		// Storing data 
		GameData data = formatter.Deserialize(fileStream) as GameData;
		// Updating GameManager state
		GameManager.instance.preferedSkin = data.preferedSkin;
		GameManager.instance.pesosCount = data.pesosCount;
		GameManager.instance.experienceCount = data.experienceCount;
		GameManager.instance.weaponLevel = data.weaponLevel;

		// Closing the File Stream
		fileStream.Close();
	}


	public static void SaveGameData()
	{
		// Create a file on given path
		string path = Application.persistentDataPath + saveFileName;
		FileStream fileStream = new FileStream(path, FileMode.Create);

		// Storing data from GameManager
		GameData data = new GameData();

		// Serializing data into binary fileStream using Binary Formatter
		BinaryFormatter formatter = new BinaryFormatter();
		formatter.Serialize(fileStream, data);

		// Closing the File Stream
		fileStream.Close();
	}

	public static void ResetGameData()
	{
		// Create a file on given path
		string path = Application.persistentDataPath + saveFileName;
		FileStream fileStream = new FileStream(path, FileMode.Create);

		// Storing data from GameManager
		GameData data = new GameData();
		data.preferedSkin = 0;
		data.pesosCount = 0;
		data.experienceCount = 0;
		data.weaponLevel = 0;
		// Serializing data into binary fileStream using Binary Formatter
		BinaryFormatter formatter = new BinaryFormatter();
		formatter.Serialize(fileStream, data);

		// Closing the File Stream
		fileStream.Close();
	}

	
}
