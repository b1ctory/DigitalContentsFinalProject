using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class cshPopUp : MonoBehaviour
{

    public cshPlayerController sPlayer;
    public GameObject Coin;
    // Start is called before the first frame update
    
    public float closeDistance = 1.0f;
    public float farDistance = 2.0f;
    void Update()
    {
        Vector3 offset = sPlayer.transform.position - Coin.transform.position;
            float sqrLen = offset.sqrMagnitude;
            // square the distance we compare with
            if (sqrLen < closeDistance * closeDistance)
            {
		ChangeQuizScene();
		
            }
	
    }

    public void ChangeQuizScene() {
	SceneManager.LoadScene("quiz");
    } 
}
