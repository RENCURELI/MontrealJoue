using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orc : MonoBehaviour
{
    public float MaxHP = 30f;
    public float HP = 30f;
    public float ATK = 18f;
    public float DEF = 29f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 30f;
        HP = MaxHP;
        ATK = 18f;
        DEF = 29f;
        INI = 0f;
    }
}
