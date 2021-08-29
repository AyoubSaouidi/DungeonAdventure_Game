using UnityEngine;
using UnityEditor.SceneManagement;

public class Portal : Collidable
{

	public string[] sceneNames;

	protected override void OnCollide(Collider2D hit)
	{
		// NO PLAYER 
		if (!hit.CompareTag("Player")) return;

		// Save DATA
		GameManager.instance.SaveState();

		// TELEPORT Player to a random Gungeon
		string sceneName = sceneNames[Random.Range(0, sceneNames.Length)];
		EditorSceneManager.LoadScene(sceneName);
	}

}
