using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MainManager : MonoBehaviour
{
    public TextMeshPro ScoreText;
    public string playerName;
    public static int playerScore;
    public GameObject[] enemyPrefabs;
    private float startDelay = 2f;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        playerName = MenuUIHandler.data.playerName;
        ScoreText.text = $"{playerName}'s Score : 0";
        InvokeRepeating("SpawnEnemies", 0.3f, 0.5f);
    }


    void Update()
    {
        ScoreText.text = $"{playerName}'s Score : {playerScore}";      
    }

    void SpawnEnemies()
    {
        int randomEnemy = Random.Range(0, 2);
        Vector3 spawnPos = new Vector3(11f, Random.Range(-2f, 4.5f), -0.45f);
        Instantiate(enemyPrefabs[randomEnemy], spawnPos, enemyPrefabs[randomEnemy].transform.rotation);
    }
}
