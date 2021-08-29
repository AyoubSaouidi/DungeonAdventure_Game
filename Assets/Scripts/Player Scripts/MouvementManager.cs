using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouvementManager : MonoBehaviour
{
    public PlayerController playerController;

    [SerializeField]
    public float speed;
    public float speedStamp;

    public Vector2 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        speedStamp = 30f;
        speed = speedStamp;
        moveDirection = Vector2.zero;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move(playerController.inputManager.isRightPressed,playerController.inputManager.isLeftPressed, playerController.inputManager.isUpPressed, playerController.inputManager.isDownPressed);
    }

    void Move(bool right, bool left, bool up, bool down)
    {
        // MOUVEMENT VARIABLES
        float x = 0;
        float y = 0;
        float speedFactor = 1f;

        // X MOUVEMENT
        if (right)
        {
            x = 1;
        }
        if (left)
        {
            x = -1;
        }
        if (right && left)
        {
            x = 0;
        }

        // Y MOUVEMENT
        if (up)
        {
            y = 1;
        }
        if (down)
        {
            y = -1;
        }
        if (up && down)
        {
            y = 0;
        }

        // MOVE IN THE MOVEMENT DIRECTION
        moveDirection = new Vector2(x, y);
        if (Mathf.Abs(moveDirection.x) == 1 && Mathf.Abs(moveDirection.y) == 1)
            speedFactor = 0.7f;
        speed = speedStamp * speedFactor;

        //      // X AXIS
        //if (!playerController.collisionManager.rayCastHitX)
        //      {
        //          transform.Translate(new Vector3(moveDirection.x * speed, 0, 0) * Time.deltaTime);
        //      }

        //      // Y Axis
        //      if (!playerController.collisionManager.rayCastHitY)
        //      {
        //          transform.Translate(new Vector3(0,moveDirection.y * speed, 0) * Time.deltaTime);
        //      }

        playerController.rigidBody.velocity = moveDirection * speed * Time.deltaTime;
    }
}
