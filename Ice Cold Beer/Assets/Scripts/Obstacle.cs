using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public GameObject gameOverText;
    private AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Touched trigger");
        if (collision.tag == "Player" && GameOver.IsGameOver == false)
        {
            gameOverText.SetActive(true);
            audioSource.Play();
            Debug.Log("The player has hit the obstacle");
            GameOver.IsGameOver = true;
        }
    } 
}
