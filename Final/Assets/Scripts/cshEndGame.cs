using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class cshEndGame : MonoBehaviour
{
    public cshPlayerController sPlayer;
    public GameObject EndPoint;
    // Start is called before the first frame update
    bool abab = true; 
    float closeDistances = 1.0f;
    void Update()
    {
        Vector3 offset = sPlayer.transform.position - EndPoint.transform.position;
        float sqrLen = offset.sqrMagnitude;
	
            // square the distance we compare with
            if (abab == true && sqrLen < closeDistances * closeDistances)
            {
		ChangeEnd();
		abab = false;
            }
	
    }

    public void ChangeEnd() {
	SceneManager.LoadScene("end");
    } 
}
