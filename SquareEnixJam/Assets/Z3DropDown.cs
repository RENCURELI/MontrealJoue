using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Z3DropDown : MonoBehaviour
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

    public float ToMaxHP = 40f;
    public float ToHP = 40f;
    public float ToATK = 35f;
    public float ToDEF = 25f;
    public float ToINI = 0f;

    public float GuMaxHP = 50f;
    public float GuHP = 50f;
    public float GuATK = 50f;
    public float GuDEF = 20f;
    public float GuINI = 0f;

    public float AvMaxHP = 1f;
    public float AvHP = 1f;
    public float AvATK = 100f;
    public float AvDEF = 150f;
    public float AvINI = 0f;

    public float TiMaxHP = 1f;
    public float TiHP = 1f;
    public float TiATK = 100f;
    public float TiDEF = 100f;
    public float TiINI = 0f;

    public float RaMaxHP = 50f;
    public float RaHP = 50f;
    public float RaATK = 20f;
    public float RaDEF = 40f;
    public float RaINI = 0f;

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
                ToHP -= guerrier.ATK / ToDEF;
                guerrier.HP -= ToATK / guerrier.DEF;
                Debug.Log("Combat en cours Index 1");
                Debug.Log(ToHP);
            } while (ToHP > 0);

            if (ToHP <= 0 || guerrier.HP <= 0)
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
                ToHP = ToMaxHP;
            }

        }
        if (dropdown.value == 2 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                GuHP -= guerrier.ATK / GuDEF;
                guerrier.HP -= GuATK / guerrier.DEF;
                Debug.Log("Combat en cours index 2");
                Debug.Log(RaHP);
            } while (GuHP > 0);

            if (GuHP <= 0 || guerrier.HP <= 0)
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
                GuHP = GuMaxHP;
            }

        }
        if (dropdown.value == 3 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                AvHP -= guerrier.ATK / AvDEF;
                guerrier.HP -= AvATK / guerrier.DEF;
                Debug.Log("Combat en cours index 3");
                Debug.Log(AvHP);
            } while (AvHP > 0);

            if (AvHP <= 0 || guerrier.HP <= 0)
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
                AvHP = AvMaxHP;
            }

        }
        if (dropdown.value == 4 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                TiHP -= guerrier.ATK / TiDEF;
                guerrier.HP -= TiATK / guerrier.DEF;
                Debug.Log("Combat en cours index 4");
                Debug.Log(TiHP);
            } while (TiHP > 0);

            if (TiHP <= 0 || guerrier.HP <= 0)
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
                TiHP = TiMaxHP;
            }

        }
        if (dropdown.value == 5 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                RaHP -= guerrier.ATK / RaDEF;
                guerrier.HP -= RaATK / guerrier.DEF;
                Debug.Log("Combat en cours index 5");
                Debug.Log(RaHP);
            } while (RaHP > 0);

            if (RaHP <= 0 || guerrier.HP <= 0)
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
                RaHP = RaMaxHP;
            }

        }
    }

}

