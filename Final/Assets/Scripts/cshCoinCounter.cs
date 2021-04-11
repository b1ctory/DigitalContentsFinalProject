using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cshCoinCounter : MonoBehaviour
{
    Text txt;
    GameObject[] coin = GameObject.FindGameObjectsWithTag("Coin");
   
    void Update()
    {
	txt = gameObject.GetComponent<Text>(); 
        txt.text= "남은 문제 갯수 : " + coin.Length;
    }
}
