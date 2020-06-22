using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshCollision : MonoBehaviour
{
    
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "SelectableObj")
        {
            Destroy(collision.gameObject);
        }
    }


}