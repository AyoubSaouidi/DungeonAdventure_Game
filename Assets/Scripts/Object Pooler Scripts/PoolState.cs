using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolState : MonoBehaviour
{

	public float duration = 2.0f;

	private void OnEnable()
	{
		Invoke("Destroy",duration);
		Debug.Log("TEXT IS HERE");
	}

	private void OnDisable()
	{
		Debug.Log("TEXT IS GONE");
		CancelInvoke();
	}

	private void Destroy()
	{
		gameObject.SetActive(false);
	}
}
