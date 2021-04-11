using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshPlay : MonoBehaviour
{
    private static bool playerExists;
    // Start is called before the first frame update
    void Start()
    {
        if (!playerExists)
        {
            playerExists = true;
            DontDestroyOnLoad(transform.gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        //DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
