using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    // Managers
    public InputManager inputManager;
    public MouvementManager mouvementManager;
    public AnimationManager animationManager;
    public CollisionManager collisionManager;

    // Collider
    public CapsuleCollider2D capsuleCollider2D;
	public Rigidbody2D rigidBody;

	// Start is called before the first frame update
	void Start()
    {
        capsuleCollider2D = GetComponent<CapsuleCollider2D>();
		rigidBody = GetComponent<Rigidbody2D>();
	}

}
