using UnityEngine;
using System.Collections;
using System.Collections.Generic;

/// <summary>
/// Manages the basics of the game such as spawning and communicating with the user interface
/// </summary>
public class GameManager : MonoBehaviour
{

    [Header("General")]
    public UserInterfaceManager UserInterface;

    [Header("Spawning")]
    public bool SpawnEnemies;
    public GameObject Player;
    public List<GameObject> EnemyPrefabs = new List<GameObject>();
    public List<GameObject> SpawnPoints = new List<GameObject>();

    private int _score;

    void Start()
    {
        TogglePlayer(true);
        Player.GetComponent<Player>().HitPoints = 3;

        _score = 0;
        if (SpawnEnemies)
        {
            SpawnEnemy();
        }
    }

    /// <summary>
    /// Executes the beginning game logic 
    /// </summary>
    public void OnEnable()
    {
        Start();
    }

    /// <summary>
    /// Spawns an enemy AI and recusively invokes itself to ensure spawning continues. Automatically stops running when the script has been disabled.
    /// </summary>
    public void SpawnEnemy()
    {
        int enemy = Random.Range(0, EnemyPrefabs.Count);
        int spawnLocation = Random.Range(0, SpawnPoints.Count);

        GameObject.Instantiate(EnemyPrefabs[enemy], SpawnPoints[spawnLocation].transform.position, Quaternion.identity);

        Invoke("SpawnEnemy", Random.Range(3, 10));
    }



    /// <summary>
    /// Toggles the player game object.
    /// </summary>
    /// <param name="visible"></param>

    public void TogglePlayer(bool visible)
    {
        Player.SetActive(visible);
    }

    /// <summary>
    /// Increments the score and calls the UI for display.
    /// </summary>
    public void IncrementScore()
    {
        _score++;

        UserInterface.AdjustScore(_score);
    }

    /// <summary>
    /// Ends the game
    /// </summary>
    public void EndGame()
    {
        TogglePlayer(false);

        CancelInvoke();
        foreach (GameObject enemy in GameObject.FindGameObjectsWithTag("Enemy"))
        {
            Destroy(enemy);
        }

        UserInterface.EndGame(); //Adjust the UI
    }

}
