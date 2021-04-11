using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cshToNextPage : MonoBehaviour
{

    public static int count = 0;
    // Start is called before the first frame update
    public void ChangeMainScene ()
    {
        SceneManager.LoadScene("main");
    }

    // Update is called once per frame
    public void ChangeInputScene()
    {
        SceneManager.LoadScene("studentInput");
    }

    public void ChangeGameScene() {
	count++;
	SceneManager.LoadScene("Play");
	cshPlayerController.canMove = true;
    } 

    public void ChangeTeacherScene() {
	SceneManager.LoadScene("teacher");
    } 

    public void ChangeQuizTeacherScene() {
	SceneManager.LoadScene("teacherInput");
    } 

    public void ChangeScoreBoard() {
	SceneManager.LoadScene("scoreboard");
    }


  

    
    
}
