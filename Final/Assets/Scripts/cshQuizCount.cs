using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cshQuizCount : MonoBehaviour
{
   
    public Text ScriptTxt;
    
    void Start() {
	PlayerPrefs.SetInt("coinCount",5);
    } 

    void Update()
    {
	ScriptTxt.text = "남은 문제 갯수 : " +  PlayerPrefs.GetInt("coinCount").ToString();

    }
}
