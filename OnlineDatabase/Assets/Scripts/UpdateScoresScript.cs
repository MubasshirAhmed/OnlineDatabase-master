using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UpdateScoresScript : MonoBehaviour {

    
    private string URL = "http://mubasshirahmed.comli.com/HighScores/update_scores.php";

    private string nameInput;
    private int scoreInput;

    // Use this for initialization
    void Start()
    {
       

        //SaveHighScores();
    }

    public void SaveHighScores()
    {
        //Debug.Log("SavehighScores");
        GameObject inputFieldGo1 = GameObject.Find("InputName");
        InputField inputField1 = inputFieldGo1.GetComponent<InputField>();
        nameInput = inputField1.text;

        GameObject inputFieldGo2 = GameObject.Find("InputScore");
        InputField inputField2 = inputFieldGo2.GetComponent<InputField>();
        scoreInput = int.Parse((inputField2.text).ToString());

        //Debug.Log(nameInput);
        //Debug.Log(scoreInput);

        WWWForm form = new WWWForm();
        form.AddField("name", nameInput);
        form.AddField("score", scoreInput);
        WWW www = new WWW(URL, form);
    }
}
