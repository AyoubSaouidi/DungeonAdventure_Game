using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fighter : MonoBehaviour
{
    // Floating Text
    public FloatingText floatingText;

    //Public Fields
    public int health = 10;
    public int maxHealth = 10;
    public float pushRecoverySpeed = 0.2f;

    // Immunity
    protected float immuneTime = 1f;
    protected float lastImmuneTime;

    // Push 
    protected Vector3 pushDirection;


    // Receive Damage --> health = 0 --> Die 
    protected virtual void ReceiveDamage(Damage damage)
	{
        // Check if we're immune or not
        if(Time.time - lastImmuneTime > immuneTime)
		{
            lastImmuneTime = Time.time;
            health -= damage.damagePoints;
            pushDirection = (transform.position - damage.origin).normalized * damage.pushForce;


            // FLOATING TEXT
            floatingText.text = "-" + damage.damagePoints.ToString();
            // -- offset Position
            float textOffsetX = transform.position.x + GetComponent<Collider2D>().bounds.size.x / 2;
            float textOffsetY = transform.position.y + GetComponent<Collider2D>().bounds.size.y / 2; 
            Vector3 textPosition = new Vector3(textOffsetX,textOffsetY,transform.position.z);
            // Show Text
            GameManager.instance.ShowFloatingText(floatingText, textPosition , transform.rotation);

            // DIE if No health
            if(health <= 0)
			{
                health = 0;
                Die();
			}
		}
	}

    protected virtual void Die()
	{
        Debug.Log("Dead");
	}



}
