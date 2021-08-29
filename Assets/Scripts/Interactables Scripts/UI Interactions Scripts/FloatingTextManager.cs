using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FloatingTextManager : MonoBehaviour
{

	public void ShowFloatingText(FloatingText floatingTextStyling, Vector3 position, Quaternion rotation)
	{
		// Instantiate A Floating Text GameObject
		GameObject pooledTextObject = ObjectPooler.instance.GetPooledObject();
		if (pooledTextObject == null) return;

		// Set The floating Text Styling
		pooledTextObject.GetComponent<Text>().text = floatingTextStyling.text;
		pooledTextObject.GetComponent<Text>().fontSize = floatingTextStyling.fontSize;
		pooledTextObject.GetComponent<Text>().fontStyle = floatingTextStyling.fontStyle;
		pooledTextObject.GetComponent<Text>().color = floatingTextStyling.color;

		// Duration & Motion
		pooledTextObject.GetComponent<PoolState>().duration = floatingTextStyling.duration;
		pooledTextObject.GetComponent<AnimateText>().motion = floatingTextStyling.motion;

		//Set Position and Rotation
		// Set Parent Transform
		pooledTextObject.transform.SetParent(transform);
		pooledTextObject.transform.position = Camera.main.WorldToScreenPoint(position);
		pooledTextObject.transform.rotation = rotation;

		// Activate Floatin Text
		pooledTextObject.SetActive(true);
	}
}
