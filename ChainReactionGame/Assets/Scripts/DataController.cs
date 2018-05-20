using UnityEngine;
using System.Collections;
using System.IO; 
using UnityEngine.SceneManagement;

public class DataController : MonoBehaviour 
{
    private PlayerProgress playerProgress;
	
	void Start ()  
	{
		//DontDestroyOnLoad (gameObject);
        loadPlayerProgress();
	}

    public void loadPlayerProgress()
    {
        playerProgress = new PlayerProgress();

        if (PlayerPrefs.HasKey("highestScore"))
        {          
            playerProgress.highestScore = PlayerPrefs.GetInt("highestScore");            
        }

        else
        {           
            PlayerPrefs.SetInt("highestScore", 0);
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
            Debug.Log("newScore: " + newScore + " > " + "highScore: " + playerProgress.highestScore);
            playerProgress.highestScore = newScore;
            SavePlayerProgress();
        }
    }

    public int GetHighestPlayerScore()
    {
        return playerProgress.highestScore;
    }

}