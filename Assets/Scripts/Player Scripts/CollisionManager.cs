using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    // Player CONTROLLER Script
    public PlayerController playerController;

    //public RaycastHit2D rayCastHitX;
    //public RaycastHit2D rayCastHitY;


    // Update is called once per frame
    void FixedUpdate()
    {
        //rayCastHitX = Physics2D.BoxCast(playerController.boxCollider.bounds.center,playerController.boxCollider.bounds.size,0.0f,Vector2.right * playerController.mouvementManager.moveDirection.x, playerController.boxCollider.bounds.size.x * 0.2f, LayerMask.GetMask("Actor","Blocking"));
        //rayCastHitY = Physics2D.BoxCast(playerController.boxCollider.bounds.center, playerController.boxCollider.bounds.size,0.0f,Vector2.up * playerController.mouvementManager.moveDirection.y, playerController.boxCollider.bounds.size.x * 0.2f, LayerMask.GetMask("Actor","Blocking"));
    }
}
