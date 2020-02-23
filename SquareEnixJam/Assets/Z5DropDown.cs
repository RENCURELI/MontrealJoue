using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Z5DropDown : MonoBehaviour
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

    public float GoMaxHP = 45f;
    public float GoHP = 45f;
    public float GoATK = 60f;
    public float GoDEF = 45f;
    public float GoINI = 0f;

    public float GlMaxHP = 10f;
    public float GlHP = 10f;
    public float GlATK = 100f;
    public float GlDEF = 100f;
    public float GlINI = 0f;

    public float JeMaxHP = 30f;
    public float JeHP = 30f;
    public float JeATK = 50f;
    public float JeDEF = 60f;
    public float JeINI = 0f;

    public float KiMaxHP = 22f;
    public float KiHP = 22f;
    public float KiATK = 80f;
    public float KiDEF = 80f;
    public float KiINI = 0f;

    public float BaMaxHP = 60f;
    public float BaHP = 60f;
    public float BaATK = 60f;
    public float BaDEF = 40f;
    public float BaINI = 0f;

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
                GoHP -= guerrier.ATK / GoDEF;
                guerrier.HP -= GoATK / guerrier.DEF;
                Debug.Log("Combat en cours Index 1");
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
                TitleLevelUP.gameObject.SetActive(true);
                GoHP = GoMaxHP;
            }

        }
        if (dropdown.value == 2 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                GlHP -= guerrier.ATK / GlDEF;
                guerrier.HP -= GlATK / guerrier.DEF;
                Debug.Log("Combat en cours index 2");
                Debug.Log(GlHP);
            } while (GlHP > 0);

            if (GlHP <= 0 || guerrier.HP <= 0)
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
                GlHP = GlMaxHP;
            }

        }
        if (dropdown.value == 3 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                JeHP -= guerrier.ATK / JeDEF;
                guerrier.HP -= JeATK / guerrier.DEF;
                Debug.Log("Combat en cours index 3");
                Debug.Log(JeHP);
            } while (JeHP > 0);

            if (JeHP <= 0 || guerrier.HP <= 0)
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
                JeHP = JeMaxHP;
            }

        }
        if (dropdown.value == 4 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                KiHP -= guerrier.ATK / KiDEF;
                guerrier.HP -= KiATK / guerrier.DEF;
                Debug.Log("Combat en cours index 4");
                Debug.Log(KiHP);
            } while (KiHP > 0);

            if (KiHP <= 0 || guerrier.HP <= 0)
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
                KiHP = KiMaxHP;
            }

        }
        if (dropdown.value == 5 && isInCombat == false)
        {
            isInCombat = true;

            do
            {
                BaHP -= guerrier.ATK / BaDEF;
                guerrier.HP -= BaATK / guerrier.DEF;
                Debug.Log("Combat en cours index 5");
                Debug.Log(BaHP);
            } while (BaHP > 0);

            if (BaHP <= 0 || guerrier.HP <= 0)
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
                BaHP = BaMaxHP;
            }

        }
    }
}
