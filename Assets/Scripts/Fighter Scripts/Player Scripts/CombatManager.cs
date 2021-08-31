using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    // Player CONTROLLER Script
    public PlayerController playerController;

    // Weapon
    public Weapon weapon;
    private float time = 0f;

    // Start is called before the first frame update
    void Start()
    {
        weapon = GetComponentInChildren<Weapon>();
        time = 0f;
    }

    // Update is called once per frame
    void Update()
    {
		if (time <= 0)
		{
			if (playerController.inputManager.isAttackPressed)
			{
                Attack();
                time = weapon.timeToWait;
			}
		}
		else
		{
            time -= Time.deltaTime;
		}
    }

    private void Attack()
	{
        weapon.Attack();
	}
}
