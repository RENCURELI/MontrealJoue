using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPText : MonoBehaviour
{
    public Guerrier guerrier;

    public Text text1;
    public string text;
    

    private void Update()
    {
        text = guerrier.HP.ToString();
        text1.text = text;
    }
}
