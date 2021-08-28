using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{

    public Transform lookAt;
    public float boundsX = 0.3f;
    public float boundsY = 0.15f;

    // Update is called once per frame
    void LateUpdate()
    {
        Vector2 diffrence = Vector2.zero;

		// CHECK if the lookAt object is out of bounds or not on the X AXIS
		float deltaX = lookAt.position.x - transform.position.x;
		if (deltaX > boundsX || deltaX < -boundsX)
		{
			if (transform.position.x > lookAt.position.x)
			{
                diffrence.x = deltaX + boundsX;
			}
            else if (transform.position.x < lookAt.position.x)
			{
                diffrence.x = deltaX - boundsX;
			}
		}

		// CHECK if the lookAt object is out of bounds or not on the Y AXIS
		float deltaY = lookAt.position.y - transform.position.y;
		if (deltaY > boundsY || deltaY < -boundsY)
		{
			if (transform.position.y > lookAt.position.y)
			{
				diffrence.y = deltaY + boundsY;
			}
			else if (transform.position.y < lookAt.position.y)
			{
				diffrence.y = deltaY - boundsY;
			}
		}

		// FOLLOW OBJECT
		transform.position += new Vector3(diffrence.x,diffrence.y,0);
	}
}
