using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateText : MonoBehaviour
{
    public Vector2 motion;


	private void OnEnable()
	{
		GetComponent<RectTransform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
	}

	// Update is called once per frame
	void Update()
    {
        // Animate Text
        transform.position += new Vector3(motion.x, motion.y, 0) * Time.deltaTime;
    }
}
