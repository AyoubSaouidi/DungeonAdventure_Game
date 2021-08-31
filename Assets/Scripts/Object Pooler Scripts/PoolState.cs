using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolState : MonoBehaviour
{

	public float duration = 2.0f;

	private void OnEnable()
	{
		Invoke("Destroy",duration);
	}

	private void OnDisable()
	{
		CancelInvoke();
	}

	private void Destroy()
	{
		gameObject.SetActive(false);
	}
}
