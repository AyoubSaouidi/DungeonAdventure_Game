using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectable : Collidable
{

	private bool isCollected = false;

	protected override void OnCollide(Collider2D hit)
	{
		if (hit.gameObject.CompareTag("Player"))
			OnCollect();
	}

	protected virtual void OnCollect()
	{
		Debug.Log("Collect Me please!");
		Collect();
	}

	protected bool IsNotCollected()
	{
		return isCollected == false;
	}

	protected void Collect()
	{
		isCollected = true;
	}




}
