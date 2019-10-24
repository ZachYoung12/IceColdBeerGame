using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//detects when the ball touches the goal, and then win a level

public class Goal : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched trigger");
        if (collision.tag == "Player")
        {
            Debug.Log("The player has entered the goal");
        }
    }
}
