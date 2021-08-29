using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collidable : MonoBehaviour
{
	private void OnCollisionEnter2D(Collision2D collision)
	{
        ProcessCollision(collision.collider);
    }

	private void OnTriggerEnter2D(Collider2D collider)
	{
        ProcessCollision(collider);
	}

	protected virtual void ProcessCollision(Collider2D collider)
	{
        // DEPENDING TO OBJECT DO SOMETHING
        OnCollide(collider);
    }

	protected virtual void OnCollide(Collider2D hit)
	{
        // DO SOMETHING
        Debug.Log("Collided with: " + hit.name);
	}
}
