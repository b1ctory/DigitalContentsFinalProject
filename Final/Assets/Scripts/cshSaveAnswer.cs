using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 
public class cshSaveAnswer : MonoBehaviour
{
    public InputField inputAnswer;
    public static string fieldText; 
    
    private void Update() {
	 fieldText = inputAnswer.text; 
    }

    public void save() {
    	 fieldText = inputAnswer.text; 
	 SceneManager.LoadScene("test");
    }
}
