using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{

	public Sprite emptyChestSprite;
	public int pesosAmount = 5;

	protected override void OnCollect()
	{
		// Check if isColected or Not
		if( IsNotCollected() )
		{
			// Set isCollected to true
			Collect();

			// Change the sprite to EMPTY chest
			GetComponent<SpriteRenderer>().sprite = emptyChestSprite;

			// COLLECTION LOGIC HERE...
			Debug.Log("Granted " + pesosAmount + " pesos!");
		}
		
	}

}
