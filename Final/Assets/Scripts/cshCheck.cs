using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cshCheck : MonoBehaviour
{
    public Text text;
    // Start is called before the first frame update
    void Awake()
    {
        text.text = cshSaveAnswer.fieldText;
    }

}
