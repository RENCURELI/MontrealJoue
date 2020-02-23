using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gladospatate : MonoBehaviour
{
    public float MaxHP = 10f;
    public float HP = 10f;
    public float ATK = 100f;
    public float DEF = 100f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 10f;
        HP = MaxHP;
        ATK = 100f;
        DEF = 100f;
        INI = 0f;
    }
}
