using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour
{

    public PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FaceSpriteWithMouvement();
    }

    void FaceSpriteWithMouvement()
	{
		if (playerController.mouvementManager.moveDirection.x > 0)
            transform.localScale = new Vector2(Mathf.Abs(transform.localScale.x),transform.localScale.y);
        else if(playerController.mouvementManager.moveDirection.x < 0)
            transform.localScale = new Vector2(-1 * Mathf.Abs(transform.localScale.x), transform.localScale.y);
    }
}
