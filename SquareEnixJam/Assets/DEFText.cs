using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DEFText : MonoBehaviour
{
    public Guerrier guerrier;

    public Text text1;
    public string text;


    private void Update()
    {
        text = guerrier.DEF.ToString();
        text1.text = text;
    }
}
