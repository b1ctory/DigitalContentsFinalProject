using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 
public class cshScoreBoard : MonoBehaviour
{
    public Text num;
    public Text scoreResult;
    // Start is called before the first frame update
    void Start()
    {
        num.text = PlayerPrefs.GetString("Hn") + PlayerPrefs.GetString("Class") + PlayerPrefs.GetString("Number");
	scoreResult.text = PlayerPrefs.GetString(PlayerPrefs.GetString("score"));
	Debug.Log(PlayerPrefs.GetString(PlayerPrefs.GetString("score")));
    }

    // Update is called once per frame
    void Update()
    {
	 string hen = PlayerPrefs.GetInt("Hn").ToString() + "0" + PlayerPrefs.GetInt("Class").ToString() + "0" +PlayerPrefs.GetInt("Number").ToString();
         num.text = hen;
	scoreResult.text = PlayerPrefs.GetString("score") + "점";
    }
}
