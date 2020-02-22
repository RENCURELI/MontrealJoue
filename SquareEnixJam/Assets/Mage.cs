using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mage : MonoBehaviour
{
    public float MaxHP = 20f;
    public float HP = 20f;
    public float ATK = 40f;
    public float DEF = 30f;
    public float INI = 30f;

    private void Awake()
    {
        MaxHP = 20f;
        HP = MaxHP;
        ATK = 40f;
        DEF = 30f;
        INI = 30f;
    }

    public void Repos()
    {
        HP += 10;
    }

}
