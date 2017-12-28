using UnityEngine;
using System.Collections;
using LitJson;
using System.Collections.Generic;

public class ShowHighScoreScript : MonoBehaviour {

    private JsonData itemData;
    List<DataList> nameScore = new List<DataList>();

    // Use this for initialization
    IEnumerator Start()
    {

        WWW itemsData = new WWW("http://mubasshirahmed.comli.com/HighScores/show_high_scores.php");
        yield return itemsData;
        string itemDataString = itemsData.text;

        itemData = JsonMapper.ToObject(itemDataString);
        //Debug.Log(itemData["user_info"][0]["name"]);
        FindAllData();
    }

    // Update is called once per frame

    void Update()
    {


    }

    void FindAllData()
    {
        

        for (int i = 0; i < itemData["user_info"].Count; i++)
        {
            string name = ((itemData["user_info"][i]["name"]).ToString());
            string score = ((itemData["user_info"][i]["score"]).ToString());
            nameScore.Add(new DataList(name, score));
        }

        //foreach (DataList datalist in nameScore)
        //{
        //    Debug.Log(datalist.name);
        //    Debug.Log(datalist.score);
        //}
    }


    public List<DataList> GetScores()
    {

        return nameScore;
    }

}

//public class DataList
//{
    
//}