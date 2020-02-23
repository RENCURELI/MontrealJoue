using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MaxHPText : MonoBehaviour
{
    public Guerrier guerrier;

    public Text text1;
    public string text; 

    public void Awake()
    {
        //text1 = text;
    }

    private void Update()
    {
        text = guerrier.MaxHP.ToString();
        text1.text = text;
        //text = guerrier.MaxHP;
    }

}
