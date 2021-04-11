using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cshStudentInput : MonoBehaviour
{

    public InputField sa;
    public static int countQ = 1;
    public static int score = 0; 
    
    public string[] answer = new string[10]; 
    // Start is called before the first frame update
    void Start()
    {
       
    }
    
    // Update is called once per frame
    public void SubmitAnswer()
    {
	answer[0] = "123";
        PlayerPrefs.SetString("sa" + countQ ,sa.text);
	
	answer[countQ] = PlayerPrefs.GetString("sa"+countQ);
	
	if (PlayerPrefs.GetString("a" + countQ).Equals(PlayerPrefs.GetString("sa"+countQ))) {
		score += 20;
		PlayerPrefs.SetString("score", score.ToString());
	}
	
 	countQ++;
	
    }

    public void coinCounts() {
	PlayerPrefs.SetInt("coinCount", PlayerPrefs.GetInt("coinCount")-1);
    } 


}
