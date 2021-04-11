using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cshText : MonoBehaviour
{
    public List<string> a = new List<string>();
    public Text obj;
    // Start is called before the first frame update
    void Start()
    {
        int count = cshToNextPage.count;
        a.Add("dd");
        a.Add("Q1 : " + PlayerPrefs.GetString("q1"));
        a.Add("Q2 : " + PlayerPrefs.GetString("q2"));
        a.Add("Q3 : " + PlayerPrefs.GetString("q3"));
        a.Add("Q4 : " + PlayerPrefs.GetString("q4"));
        a.Add("Q5 : " + PlayerPrefs.GetString("q5"));

    
        obj.text = a[count];
	
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}