using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour {
    
    Vector2 dir;

    public float movementDelay = 0.2f;
    float timePassed = 0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        CheckMovement();
	}

    void CheckMovement()
    {
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            dir = Vector2.down;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            dir = Vector2.up;
        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            dir = Vector2.left;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            dir = Vector2.right;
        }

        if(timePassed > movementDelay)
        {
            timePassed = 0f;
            //applicato il movimento
            ApplyMovement();
        }
        else
        {
            timePassed += Time.deltaTime;
        }
    }

    void ApplyMovement()
    {
        transform.Translate(dir);
    }
}
