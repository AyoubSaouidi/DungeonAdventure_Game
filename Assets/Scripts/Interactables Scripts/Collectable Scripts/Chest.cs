using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : Collectable
{

	public Sprite emptyChestSprite;
	public int pesosAmount = 5;
	public FloatingText floatingTextStyle;

	protected override void OnCollect()
	{
		// Check if isColected or Not
		if( IsNotCollected() )
		{
			// Set isCollected to true
			Collect();

			// Change the sprite to EMPTY chest
			GetComponent<SpriteRenderer>().sprite = emptyChestSprite;

			// Show Floating Text -- UI
			floatingTextStyle.text = "+"+pesosAmount+" pesos!";
			GameManager.instance.ShowFloatingText(floatingTextStyle,transform.position,transform.rotation);

			// COLLECTION LOGIC HERE...
			GameManager.instance.pesosCount += pesosAmount;
			Debug.Log("Granted " + pesosAmount + " pesos!");
		}

		print("Shit");
		
	}

}
