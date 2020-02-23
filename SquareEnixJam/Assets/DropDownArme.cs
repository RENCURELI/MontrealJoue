using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropDownArme : MonoBehaviour
{
    public Guerrier guerrier;

    public TMP_Dropdown dropdown;
    public bool isStatBoost = false;

    private void Update()
    {
        if(dropdown.value == 0)
        {
            guerrier.item1 = Resources.Load<Item>("Test");
        }

        if (dropdown.value == 1 && isStatBoost == false)
        {
            guerrier.ATK += 2;
            guerrier.DEF += 0;
            guerrier.MaxHP += 0;
        }

        if (dropdown.value == 2)
        {
            //Marteau de forgeron
        }

        if (dropdown.value == 3)
        {
            //Arc de chasseur
        }

        if (dropdown.value == 4)
        {
            //Gougoune de competition
        }

        if (dropdown.value == 5)
        {
            //Chope de nain
        }

        if (dropdown.value == 6)
        {
            //Le bilboquet ancestral
        }

        if (dropdown.value == 7)
        {
            //Epee de feu
        }

        if (dropdown.value == 8)
        {
            //Epee de glace
        }
    }

}
