using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ZBDropDown : MonoBehaviour
{
    public Guerrier guerrier;

    public GameObject Title;
    public GameObject TitleMaxHP;
    public GameObject TitleHP;
    public GameObject TitleATK;
    public GameObject TitleDEF;
    public GameObject TitleINI;
    public GameObject TitleCombat;
    public GameObject TitleEquipment;
    public GameObject TitleRepos;
    public GameObject TitleLevelUP;
    public GameObject CombatTitle;

    public TMP_Dropdown dropdown;
    public bool isInCombat = false;

    public float OeMaxHP = 40f;
    public float OeHP = 40f;
    public float OeATK = 65f;
    public float OeDEF = 70f;
    public float OeINI = 0f;

    public float MjMaxHP = 100f;
    public float MjHP = 100f;
    public float MjATK = 10f;
    public float MjDEF = 50f;
    public float MjINI = 0f;

    public float InMaxHP = 50f;
    public float InHP = 50f;
    public float InATK = 45f;
    public float InDEF = 100f;
    public float InINI = 0f;

    private void Update()
    {
        if (dropdown.value == 0)
        {

        }
        if (dropdown.value == 1 && isInCombat == false)
        {

            isInCombat = true;

            do
            {
                OeHP -= guerrier.ATK / OeDEF;
                guerrier.HP -= OeATK / guerrier.DEF;
                Debug.Log("Combat en cours Index 1");
                Debug.Log(OeHP);
            } while (OeHP > 0);

            if (OeHP <= 0 || guerrier.HP <= 0)
            {
                isInCombat = false;
                dropdown.value = 0;
                Debug.Log("End");
                CombatTitle.gameObject.SetActive(false);
                Title.gameObject.SetActive(true);
                TitleMaxHP.gameObject.SetActive(true);
                TitleHP.gameObject.SetActive(true);
                TitleATK.gameObject.SetActive(true);
                TitleDEF.gameObject.SetActive(true);
                TitleINI.gameObject.SetActive(true);
                TitleCombat.gameObject.SetActive(true);
                TitleEquipment.gameObject.SetActive(true);
                TitleRepos.gameObject.SetActive(true);
                TitleLevelUP.gameObject.SetActive(true);
                OeHP = OeMaxHP;
            }

        }
        if (dropdown.value == 2 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                MjHP -= guerrier.ATK / MjDEF;
                guerrier.HP -= MjATK / guerrier.DEF;
                Debug.Log("Combat en cours index 2");
                Debug.Log(MjHP);
            } while (MjHP > 0);

            if (MjHP <= 0 || guerrier.HP <= 0)
            {
                isInCombat = false;
                dropdown.value = 0;
                Debug.Log("End");
                CombatTitle.gameObject.SetActive(false);
                Title.gameObject.SetActive(true);
                TitleMaxHP.gameObject.SetActive(true);
                TitleHP.gameObject.SetActive(true);
                TitleATK.gameObject.SetActive(true);
                TitleDEF.gameObject.SetActive(true);
                TitleINI.gameObject.SetActive(true);
                TitleCombat.gameObject.SetActive(true);
                TitleEquipment.gameObject.SetActive(true);
                TitleRepos.gameObject.SetActive(true);
                TitleLevelUP.gameObject.SetActive(true);
                MjHP = MjMaxHP;
            }

        }
        if (dropdown.value == 3 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                InHP -= guerrier.ATK / InDEF;
                guerrier.HP -= InATK / guerrier.DEF;
                Debug.Log("Combat en cours index 3");
                Debug.Log(InHP);
            } while (InHP > 0);

            if (InHP <= 0 || guerrier.HP <= 0)
            {
                isInCombat = false;
                dropdown.value = 0;
                Debug.Log("End");
                CombatTitle.gameObject.SetActive(false);
                Title.gameObject.SetActive(true);
                TitleMaxHP.gameObject.SetActive(true);
                TitleHP.gameObject.SetActive(true);
                TitleATK.gameObject.SetActive(true);
                TitleDEF.gameObject.SetActive(true);
                TitleINI.gameObject.SetActive(true);
                TitleCombat.gameObject.SetActive(true);
                TitleEquipment.gameObject.SetActive(true);
                TitleRepos.gameObject.SetActive(true);
                TitleLevelUP.gameObject.SetActive(true);
                InHP = InMaxHP;
            }

        }
      
    }
}
