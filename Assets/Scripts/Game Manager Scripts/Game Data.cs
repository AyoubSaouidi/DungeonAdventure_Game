




[System.Serializable]
public class GameData
{

	public int preferedSkin;
	public int pesosCount;
	public int experienceCount;
	public int weaponLevel;

	// Fill GameData depending on the GameManager state
	public GameData() {
		GameManager gameManager = GameManager.instance;
		preferedSkin = gameManager.preferedSkin;
		pesosCount = gameManager.pesosCount;
		experienceCount = gameManager.experienceCount;
		weaponLevel = gameManager.weaponLevel;
	}
}
