using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform platformGenerator;
    public PlayerController player;
    public EnemyContorller Enemy;
    public DeathMenu deathScene;

    private Vector3 platformStartPoint;
    private Vector3 playerStartPoint, EnemyStartPoint;

    private DestroyPlatform[] platformLists;

    private ScoreKeeper scoreKeeper;

    // Start is called before the first frame update
    void Start()
    {
        platformStartPoint = platformGenerator.position;
        playerStartPoint = player.transform.position;
        EnemyStartPoint = Enemy.transform.position;

        scoreKeeper = FindObjectOfType<ScoreKeeper>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void RestartGame()
    {
        scoreKeeper.scoreIncrease = false;
        player.gameObject.SetActive(false);
        Enemy.gameObject.SetActive(false);

        deathScene.gameObject.SetActive(true);
    }

    public void Reset()
    {
        deathScene.gameObject.SetActive(false);

        platformLists = FindObjectsOfType<DestroyPlatform>();
        for (int i = 0; i < platformLists.Length; i++)
        {
            platformLists[i].gameObject.SetActive(false);
            Destroy(platformLists[i].gameObject);
        }

        player.transform.position = playerStartPoint;
        Enemy.transform.position = EnemyStartPoint;
        platformGenerator.position = platformStartPoint;
        player.gameObject.SetActive(true);
        Enemy.gameObject.SetActive(true);

        scoreKeeper.scoreCounter = 0;
        scoreKeeper.scoreIncrease = true;
    }

    
}
