using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.Linq;

public class PlayerScoreListScripts : MonoBehaviour {

    public List<DataList> nameScore;

    // Use this for initialization
    IEnumerator Start () {
        yield return new WaitForSeconds(1);
        nameScore = new List<DataList>();

        ShowHighScoreScript holdScoreObject = GameObject.FindObjectOfType<ShowHighScoreScript>();
        GameObject go1 = GameObject.Find("Rank1");
        GameObject go2 = GameObject.Find("Rank2");
        GameObject go3 = GameObject.Find("Rank3");
        GameObject go4 = GameObject.Find("Rank4");
        GameObject go5 = GameObject.Find("Rank5");

        nameScore = holdScoreObject.GetScores();


        if (nameScore.Count!=0)
        {
            //Debug.Log("NOT NULL");

            //foreach (DataList datalist in nameScore)
            //{
            //    Debug.Log(datalist.name);
            //    Debug.Log(datalist.score);
            //}


            var dictionary = new Dictionary<string, int>(5);



            dictionary.Add(nameScore[0].name, int.Parse(nameScore[0].score));
            dictionary.Add(nameScore[1].name, int.Parse(nameScore[1].score));
            dictionary.Add(nameScore[2].name, int.Parse(nameScore[2].score));
            dictionary.Add(nameScore[3].name, int.Parse(nameScore[3].score));
            dictionary.Add(nameScore[4].name, int.Parse(nameScore[4].score));

            var items = from pair in dictionary
                        orderby pair.Value descending
                        select pair;

            nameScore.Clear();
           
            foreach (KeyValuePair<string, int> pair in items)
            {
               
                //Console.WriteLine("{0}: {1}", pair.Key, pair.Value);
                nameScore.Add(new DataList(pair.Key, (pair.Value).ToString()));
            }



            go1.transform.Find("NameTxt").GetComponent<Text>().text = nameScore[0].name;
            go1.transform.Find("ScoreTxt").GetComponent<Text>().text = nameScore[0].score;
            go2.transform.Find("NameTxt").GetComponent<Text>().text = nameScore[1].name;
            go2.transform.Find("ScoreTxt").GetComponent<Text>().text = nameScore[1].score;
            go3.transform.Find("NameTxt").GetComponent<Text>().text = nameScore[2].name;
            go3.transform.Find("ScoreTxt").GetComponent<Text>().text = nameScore[2].score;
            go4.transform.Find("NameTxt").GetComponent<Text>().text = nameScore[3].name;
            go4.transform.Find("ScoreTxt").GetComponent<Text>().text = nameScore[3].score;
            go5.transform.Find("NameTxt").GetComponent<Text>().text = nameScore[4].name;
            go5.transform.Find("ScoreTxt").GetComponent<Text>().text = nameScore[4].score;
        }

        
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
