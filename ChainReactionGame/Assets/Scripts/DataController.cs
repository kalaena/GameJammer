using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour 
{
    private PlayerProgress playerProgress;
	
	void Start ()  
	{
		DontDestroyOnLoad (gameObject);
        loadPlayerProgress();
	}

    public void loadPlayerProgress()
    {
        playerProgress = new PlayerProgress();

        if (PlayerPrefs.HasKey("highestScore"))
        {
            playerProgress.highestScore = PlayerPrefs.GetInt("highestScore");
        }
    }

    public void SavePlayerProgress() 
    {
        PlayerPrefs.SetInt("highestScore", playerProgress.highestScore);
    }

    public void SubmitNewPlayerScore(int newScore) 
    {
        if (newScore > playerProgress.highestScore)
        {
            playerProgress.highestScore = newScore;
            SavePlayerProgress();
        }
    }

    public int GetHighestPlayerScore()
    {
        return playerProgress.highestScore;
    }

}