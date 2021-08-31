using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
	private void Awake()
	{

		if (instance != null && instance != this) {
			Destroy(gameObject);
			return;
		}

		instance = this;
		DontDestroyOnLoad(gameObject);
	}

	// Ressources -----------------------------------
	public List<Sprite> playerSprites;
	public List<Sprite> weaponSprites;
	public List<int> weaponPrices;
	public List<int> xpTable;

	// References -----------------------------------
	public PlayerController playerController;
	public FloatingTextManager floatingTextManager;
	// ....

	// Logic Variables ------------------------------
	public int preferedSkin = 1;
	public int pesosCount = 0;
	public int experienceCount = 0;
	public int weaponLevel = 2;




	// Load Data on Enabled
	void OnEnable()
	{
		SceneManager.sceneLoaded += LoadState;
	}

	// Update UI
	public void ShowFloatingText(FloatingText floatingText, Vector3 position, Quaternion rotation)
	{
		floatingTextManager.ShowFloatingText(floatingText, position, rotation);
	}


	// State Management -----------------------------
	// --->> Load State
	public static void LoadState(Scene scene, LoadSceneMode loadMode)
	{
		SceneManager.sceneLoaded -= LoadState;
		SaveSystem.LoadGameData();
		Weapon playerWeapon = instance.playerController.GetComponentInChildren<Weapon>();
		//playerWeapon.level = instance.weaponLevel;
		Debug.Log("Load State -- scene: " + scene.name + " -- mode:  " + loadMode);
	}
	// --->> Save State
	public void SaveState()
	{
		SaveSystem.SaveGameData();
		Debug.Log("Save State");
	}

}
