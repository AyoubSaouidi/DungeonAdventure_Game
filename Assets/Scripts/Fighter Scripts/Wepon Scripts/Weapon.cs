using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : Collidable
{

    // Upgrade variables
    public int level;
    public SpriteRenderer spriteRenderer;

    // Damage variables
    public int damagePoints;
    public float pushForce;

    // Attack time variables
    public bool canAttack = false;
    public float timeToWait = 1.5f;

	private void Start()
	{
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.sprite = GameManager.instance.weaponSprites[level];
	}

	protected override void OnCollide(Collider2D hit)
	{
        // If Not Enemey dont Dammge
        if (hit.tag != "Fighter" || hit.name == "Player") return;

        // Weapon DAMMAGE
        Debug.Log("Damaged " + hit.name);
        Damage damage = new Damage(transform.position,damagePoints,pushForce);

        // Send Message To the GameObject Hitted
        hit.SendMessage("ReceiveDamage", damage);
	}

    public void Attack()
	{
        Debug.Log("Attack");
	}
}
