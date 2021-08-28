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
    public BoxCollider2D boxCollider;
    //public Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start()
    {
        boxCollider = GetComponent<BoxCollider2D>();
        //rigidBody = GetComponent<Rigidbody2D>();
    }

}
