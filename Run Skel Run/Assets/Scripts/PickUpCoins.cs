using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpCoins : MonoBehaviour
{
    public int scoreGiven;

    private ScoreKeeper scoreKeeper;

    private AudioSource coinSound;
    // Start is called before the first frame update
    void Start()
    {
        scoreKeeper = FindObjectOfType<ScoreKeeper>();

        coinSound = GameObject.Find("CoinSound").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            scoreKeeper.AddScore(scoreGiven);
            gameObject.SetActive(false);
            if(coinSound.isPlaying)
            {
                coinSound.Stop();
                coinSound.Play();
            } else
            {
                coinSound.Play();
            }

        }    
    }
}
