using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Z2DropDown : MonoBehaviour
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

    public float OrMaxHP = 30f;
    public float OrHP = 30f;
    public float OrATK = 18f;
    public float OrDEF = 29f;
    public float OrINI = 0f;

    public float BeMaxHP = 15f;
    public float BeHP = 15f;
    public float BeATK = 20f;
    public float BeDEF = 40f;
    public float BeINI = 0f;

    public float SpMaxHP = 35f;
    public float SpHP = 35f;
    public float SpATK = 20f;
    public float SpDEF = 20f;
    public float SpINI = 0f;

    public float WeMaxHP = 40f;
    public float WeHP = 40f;
    public float WeATK = 40f;
    public float WeDEF = 15f;
    public float WeINI = 0f;

    public float VoMaxHP = 1f;
    public float VoHP = 1f;
    public float VoATK = 100f;
    public float VoDEF = 35f;
    public float VoINI = 0f;

    private void Update()
    {
        if (dropdown.value == 0)
        {

        }

        if(dropdown.value == 1 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                OrHP -= guerrier.ATK / OrDEF;
                guerrier.HP -= OrATK / guerrier.DEF;
                Debug.Log("Combat en cours Index 1");
                Debug.Log(OrHP);
            } while (OrHP > 0);

            if(OrHP <= 0 || guerrier.HP <= 0)
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
                OrHP = OrMaxHP;
            }
        }

        if (dropdown.value == 2 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                BeHP -= guerrier.ATK / BeDEF;
                guerrier.HP -= BeATK / guerrier.DEF;
                Debug.Log("Combat en cours Index 1");
                Debug.Log(OrHP);
            } while (BeHP > 0);

            if (BeHP <= 0 || guerrier.HP <= 0)
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
                BeHP = BeMaxHP;
            }
        }

        if (dropdown.value == 3 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                SpHP -= guerrier.ATK / SpDEF;
                guerrier.HP -= SpATK / guerrier.DEF;
                Debug.Log("Combat en cours Index 1");
                Debug.Log(OrHP);
            } while (SpHP > 0);

            if (SpHP <= 0 || guerrier.HP <= 0)
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
                SpHP = SpMaxHP;
            }
        }

        if (dropdown.value == 4 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                WeHP -= guerrier.ATK / WeDEF;
                guerrier.HP -= WeATK / guerrier.DEF;
                Debug.Log("Combat en cours Index 1");
                Debug.Log(OrHP);
            } while (WeHP > 0);

            if (WeHP <= 0 || guerrier.HP <= 0)
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
                WeHP = WeMaxHP;
            }
        }

        if (dropdown.value == 5 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                VoHP -= guerrier.ATK / VoDEF;
                guerrier.HP -= VoATK / guerrier.DEF;
                Debug.Log("Combat en cours Index 1");
                Debug.Log(OrHP);
            } while (VoHP > 0);

            if (VoHP <= 0 || guerrier.HP <= 0)
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
                VoHP = VoMaxHP;
            }
        }

    }
}


