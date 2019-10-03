using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingRampSupport : MonoBehaviour
{
    private float moveSpeed = 0.05f;
    
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("this is a test.");
        //transform.Translate(5, 0, 0);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        //If the player presses the up arrow, we move the square up.
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0, moveSpeed, 0);
        }
        //If the player presses the down arrow, we move the square down.
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, -1 * moveSpeed, 0);
        }
    }
}
