using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Guerrier : MonoBehaviour
{
    public float MaxHP = 35f;
    public float HP = 35f;
    public float ATK = 20f;
    public float DEF = 35f;
    public float INI = 30f;

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
    public GameObject CombatMenu;
    public GameObject Gear;

    public Item item1;

    private void Awake()
    {
        MaxHP = 30f;
        HP = MaxHP;
        ATK = 30f;
        DEF = 30f;
        INI = 30f;
    }

    public void Repos()
    {
        HP = MaxHP;
    }

    public void LevelUp()
    {
        MaxHP += 10;
        HP += 10;
        ATK += 10;
        DEF += 10;
    }

    public void Combat()
    {
        Title.gameObject.SetActive(false);
        TitleMaxHP.gameObject.SetActive(false);
        TitleHP.gameObject.SetActive(false);
        TitleATK.gameObject.SetActive(false);
        TitleDEF.gameObject.SetActive(false);
        TitleINI.gameObject.SetActive(false);
        TitleCombat.gameObject.SetActive(false);
        TitleEquipment.gameObject.SetActive(false);
        TitleRepos.gameObject.SetActive(false);
        TitleLevelUP.gameObject.SetActive(false);
        CombatMenu.gameObject.SetActive(true);
    }

    public void Return()
    {
        Title.gameObject.SetActive(true);
        TitleMaxHP.gameObject.SetActive(true);
        TitleHP.gameObject.SetActive(true);
        TitleATK.gameObject.SetActive(true);
        TitleDEF.gameObject.SetActive(true);
        TitleCombat.gameObject.SetActive(true);
        TitleEquipment.gameObject.SetActive(true);
        TitleRepos.gameObject.SetActive(true);
        TitleLevelUP.gameObject.SetActive(true);
        CombatMenu.gameObject.SetActive(false);
        Gear.gameObject.SetActive(false);
    }

    public void GearPage()
    {
        Title.gameObject.SetActive(false);
        TitleCombat.gameObject.SetActive(false);
        TitleEquipment.gameObject.SetActive(false);
        TitleRepos.gameObject.SetActive(false);
        TitleLevelUP.gameObject.SetActive(false);
        Gear.gameObject.SetActive(true);
    }

    public void MaxHPMinus()
    {
        MaxHP -= 1;
    }

    public void MaxHPPlus()
    {
        MaxHP += 1;
    }

    public void ATKMinus()
    {
        ATK -= 1;
    }

    public void ATKPlus()
    {
        ATK += 1;
    }

    public void DEFMinus()
    {
        DEF -= 1;
    }

    public void DEFPlus()
    {
        DEF += 1;
    }
}
