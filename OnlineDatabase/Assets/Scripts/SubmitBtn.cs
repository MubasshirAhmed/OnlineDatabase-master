using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SubmitBtn : MonoBehaviour {



    public void SubmitButtonClick()
    {
        UpdateScoresScript updateScores = GameObject.FindObjectOfType<UpdateScoresScript>();
        updateScores.SaveHighScores();  
    }

    public void ScoreBoardButtonClick(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }

    public void MenuButtonClick(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }
}
