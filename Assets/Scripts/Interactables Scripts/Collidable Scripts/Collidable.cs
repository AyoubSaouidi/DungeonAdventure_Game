using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{

    protected ContactFilter2D filter;
    protected BoxCollider2D boxCollider;
    protected Collider2D[] hits = new Collider2D[10];


    // Start is called before the first frame update
    protected virtual void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
    }

    // Update is called once per frame
    protected virtual void Update()
    {
        // CHECK IF we collide with other objects (OVERLAP)
        boxCollider.OverlapCollider(filter, hits);

		// DEPENDING TO OBJECT DO SOMETHING
		for (int i = 0; i < hits.Length; i++)
		{

            if (hits[i] == null)
                continue;

            OnCollide(hits[i]);

            hits[i] = null;

        }
	}

	protected virtual void OnCollide(Collider2D hit)
	{
        // DO SOMETHING
        Debug.Log("Collided with: " + hit.name);
	}
}
