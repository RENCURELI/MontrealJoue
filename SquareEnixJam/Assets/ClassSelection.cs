using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassSelection : MonoBehaviour
{
    public GameObject ButtonsOff;



    public void Guerrier()
    {

        ButtonsOff.gameObject.SetActive(false);
    }

    public void Mage()
    {

        ButtonsOff.gameObject.SetActive(false);
    }

    public void Voleur()
    {

        ButtonsOff.gameObject.SetActive(false);
    }
}
