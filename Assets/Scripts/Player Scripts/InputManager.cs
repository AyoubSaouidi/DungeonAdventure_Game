using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    public PlayerController playerController;

    public bool isRightPressed;
    public bool isLeftPressed;
    public bool isUpPressed;
    public bool isDownPressed;

    // Start is called before the first frame update
    void Start()
    {
        isRightPressed = false;
        isLeftPressed = false;
        isUpPressed = false;
        isDownPressed = false;
    }

    // Update is called once per frame
    void Update()
    {
        // IS RIGHT ARROW PRESSED
		if (Input.GetKey(KeyCode.RightArrow))
		{
            isRightPressed = true;
		}
		else
		{
            isRightPressed = false;
		}

        // IS LEFT ARROW PRESSED
		if (Input.GetKey(KeyCode.LeftArrow))
		{
            isLeftPressed = true;
		}
        else
		{
            isLeftPressed = false;
		}

        // IS UP ARROW PRESSED
        if (Input.GetKey(KeyCode.UpArrow))
        {
            isUpPressed = true;
        }
        else
        {
            isUpPressed = false;
        }

        // IS DOWN ARROW PRESSED
        if (Input.GetKey(KeyCode.DownArrow))
        {
            isDownPressed = true;
        }
        else
        {
            isDownPressed = false;
        }
    }
}
