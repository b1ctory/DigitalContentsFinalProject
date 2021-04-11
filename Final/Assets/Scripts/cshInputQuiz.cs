using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cshInputQuiz : MonoBehaviour
{
    public InputField q1;
    public InputField q2;
    public InputField q3;
    public InputField q4;
    public InputField q5;

    public InputField a1;
    public InputField a2;
    public InputField a3;
    public InputField a4;
    public InputField a5;

    public void Save()
    {
        PlayerPrefs.SetString("q1", q1.text);
	PlayerPrefs.SetString("q2", q2.text);
	PlayerPrefs.SetString("q3", q3.text);
	PlayerPrefs.SetString("q4", q4.text);
	PlayerPrefs.SetString("q5", q5.text);

	PlayerPrefs.SetString("a1", a1.text);
	PlayerPrefs.SetString("a2", a2.text);
	PlayerPrefs.SetString("a3", a3.text);
	PlayerPrefs.SetString("a4", a4.text);
	PlayerPrefs.SetString("a5", a5.text);
    }

}
