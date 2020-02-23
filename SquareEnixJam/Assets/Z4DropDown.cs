using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Z4DropDown : MonoBehaviour
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

    public float VeMaxHP = 50f;
    public float VeHP = 50f;
    public float VeATK = 30f;
    public float VeDEF = 40f;
    public float VeINI = 0f;

    public float SaMaxHP = 1f;
    public float SaHP = 1f;
    public float SaATK = 100f;
    public float SaDEF = 150f;
    public float SaINI = 0f;

    public float ScMaxHP = 30f;
    public float ScHP = 30f;
    public float ScATK = 50f;
    public float ScDEF = 30f;
    public float ScINI = 0f;

    public float MoMaxHP = 20f;
    public float MoHP = 20f;
    public float MoATK = 50f;
    public float MoDEF = 50f;
    public float MoINI = 0f;

    public float JaMaxHP = 60f;
    public float JaHP = 60f;
    public float JaATK = 25f;
    public float JaDEF = 48f;
    public float JaINI = 0f;

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
                VeHP -= guerrier.ATK / VeDEF;
                guerrier.HP -= VeATK / guerrier.DEF;
                Debug.Log("Combat en cours Index 1");
                Debug.Log(VeHP);
            } while (VeHP > 0);

            if (VeHP <= 0 || guerrier.HP <= 0)
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
                VeHP = VeMaxHP;
            }

        }
        if (dropdown.value == 2 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                SaHP -= guerrier.ATK / SaDEF;
                guerrier.HP -= SaATK / guerrier.DEF;
                Debug.Log("Combat en cours index 2");
                Debug.Log(SaHP);
            } while (SaHP > 0);

            if (SaHP <= 0 || guerrier.HP <= 0)
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
                SaHP = SaMaxHP;
            }

        }
        if (dropdown.value == 3 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                ScHP -= guerrier.ATK / ScDEF;
                guerrier.HP -= ScATK / guerrier.DEF;
                Debug.Log("Combat en cours index 3");
                Debug.Log(ScHP);
            } while (ScHP > 0);

            if (ScHP <= 0 || guerrier.HP <= 0)
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
                ScHP = ScMaxHP;
            }

        }
        if (dropdown.value == 4 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                MoHP -= guerrier.ATK / MoDEF;
                guerrier.HP -= MoATK / guerrier.DEF;
                Debug.Log("Combat en cours index 4");
                Debug.Log(MoHP);
            } while (MoHP > 0);

            if (MoHP <= 0 || guerrier.HP <= 0)
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
                MoHP = MoMaxHP;
            }

        }
        if (dropdown.value == 5 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                JaHP -= guerrier.ATK / JaDEF;
                guerrier.HP -= JaATK / guerrier.DEF;
                Debug.Log("Combat en cours index 5");
                Debug.Log(JaHP);
            } while (JaHP > 0);

            if (JaHP <= 0 || guerrier.HP <= 0)
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
                JaHP = JaMaxHP;
            }

        }
    }
}
