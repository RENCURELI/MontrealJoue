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

    public Item item1;

    private void Awake()
    {
        MaxHP = 35f;
        HP = MaxHP;
        ATK = 20f;
        DEF = 35f;
        INI = 30f;
    }

    public void Repos()
    {
        HP += 10;
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
    }
}
