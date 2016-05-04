using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Manages the User Interface game objects
/// </summary>
public class UserInterfaceManager : MonoBehaviour
{
    public Text ScoreText;
    public GameObject MainScreen;
    public GameObject GameScreen;
    public GameObject GameManager;

    public GameObject[] HealthIcons;


    public void AdjustScore(int amount)
    {
        ScoreText.text = "Score: " + amount;
    }


    /// <summary>
    /// Removes a heart from the UI.
    /// </summary>
    public void DecreasePlayerHealth()
    {
        foreach (Transform heart in GameScreen.transform.FindChild("Health").transform)
        {
            if (heart.gameObject.activeSelf)
            {
                heart.gameObject.SetActive(false);
                break;
            }
        }
    }

    /// <summary>
    /// Starts the game by enabling the Game Manager and 
    /// </summary>
    public void Start_OnClick()
    {
        GameManager.SetActive(true);
        ScoreText.text = "Score: 0";

        foreach (Transform health in GameScreen.transform.FindChild("Health").transform)
        {
            health.gameObject.SetActive(true);
        }

        MainScreen.SetActive(false);
        GameScreen.SetActive(true);

    }

    /// <summary>
    /// Ends the gam by removing enemy AI and toggling the appropriate UI
    /// </summary>
    public void EndGame()
    {
        GameManager.SetActive(false);
        MainScreen.SetActive(true);
        GameScreen.SetActive(false);
    }
}
