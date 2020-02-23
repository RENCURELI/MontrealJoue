using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropDownArme : MonoBehaviour
{
    public Guerrier guerrier;

    public TMP_Dropdown dropdown;

    private void Update()
    {
        if(dropdown.value == 0)
        {
            guerrier.item1 = Resources.Load<Item>("Test");
        }

        if (dropdown.value == 1)
        {

        }

        if (dropdown.value == 2)
        {

        }

        if (dropdown.value == 3)
        {

        }

        if (dropdown.value == 4)
        {

        }

        if (dropdown.value == 0)
        {

        }
    }

}
