using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DropDownZ1 : MonoBehaviour
{
    //int turns = 1;

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
    public GameObject CombatTitle;

    public TMP_Dropdown dropdown;
    public bool isInCombat = false;

    public float LaMaxHP = 1f;
    public float LaHP = 1f;
    public float LaATK = 100f;
    public float LaDEF = 5f;
    public float LaINI = 0f;

    public float ChMaxHP = 30f;
    public float ChHP = 30f;
    public float ChATK = 5f;
    public float ChDEF = 30f;
    public float ChINI = 0f;

    public float GoMaxHP = 8f;
    public float GoHP = 8f;
    public float GoATK = 30f;
    public float GoDEF = 25f;
    public float GoINI = 0f;

    public float LoMaxHP = 5f;
    public float LoHP = 5f;
    public float LoATK = 20f;
    public float LoDEF = 30f;
    public float LoINI = 0f;

    public float RaMaxHP = 3f;
    public float RaHP = 3f;
    public float RaATK = 15f;
    public float RaDEF = 20f;
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
                LaHP -= guerrier.ATK / LaDEF;
                guerrier.HP -= LaATK / guerrier.DEF;
                Debug.Log("Combat en cours Index 1");
                Debug.Log(LaHP);
            } while (LaHP > 0);

            if (LaHP <= 0 || guerrier.HP <= 0)
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
                LaHP = LaMaxHP;
            }

        }
        if (dropdown.value == 2 && isInCombat == false)
        {
            isInCombat = true;
            
            do
            {
                RaHP -= guerrier.ATK / RaDEF;
                guerrier.HP -= RaATK / guerrier.DEF;
                Debug.Log("Combat en cours index 2");
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
                RaHP = RaMaxHP;
            }

        }
        if (dropdown.value == 3 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                LoHP -= guerrier.ATK / LoDEF;
                guerrier.HP -= LoATK / guerrier.DEF;
                Debug.Log("Combat en cours index 3");
                Debug.Log(LoHP);
            } while (LoHP > 0);

            if (LoHP <= 0 || guerrier.HP <= 0)
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
                LoHP = LoMaxHP;
            }

        }
        if (dropdown.value == 4 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                GoHP -= guerrier.ATK / GoDEF;
                guerrier.HP -= GoATK / guerrier.DEF;
                Debug.Log("Combat en cours index 4");
                Debug.Log(GoHP);
            } while (GoHP > 0);

            if (GoHP <= 0 || guerrier.HP <= 0)
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
                GoHP = GoMaxHP;
            }

        }
        if (dropdown.value == 5 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                ChHP -= guerrier.ATK / ChDEF;
                guerrier.HP -= ChATK / guerrier.DEF;
                Debug.Log("Combat en cours index 5");
                Debug.Log(ChHP);
            } while (ChHP > 0);

            if (ChHP <= 0 || guerrier.HP <= 0)
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
                ChHP = ChMaxHP;
            }

        }
    }

}