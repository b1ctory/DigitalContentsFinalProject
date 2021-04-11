using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cshInputStudentInfo : MonoBehaviour
{
    public InputField inputHn;
    public InputField inputClass;
    public InputField inputNumber;
    // Start is called before the first frame update

    public void Save()
    {
        PlayerPrefs.SetInt("Hn", int.Parse(inputHn.text));
        PlayerPrefs.SetInt("Class", int.Parse(inputClass.text));
        PlayerPrefs.SetInt("Number", int.Parse(inputNumber.text));
    }

    
    
}
