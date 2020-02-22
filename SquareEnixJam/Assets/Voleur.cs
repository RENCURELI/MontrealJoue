using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Voleur : MonoBehaviour
{
    public float MaxHP = 30f;
    public float HP = 30f;
    public float ATK = 30f;
    public float DEF = 30f;
    public float INI = 30f;

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
        HP += 10;
    }

    
}
