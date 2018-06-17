using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextObject : MonoBehaviour
{
    public Text m_mytext;
    // Use this for initialization
    void Start()
    {
        //Text sets your text to say this message
        m_mytext.text = "This is my text";
    }

    // Update is called once per frame
    void Update()
    {
        //Press the space key to change the Text message
        if (Input.GetKey(KeyCode.Space))
        {
            m_mytext.text = "Text has changed.";
        }

    }
}


