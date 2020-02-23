using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wendigo : MonoBehaviour
{
    public float MaxHP = 40f;
    public float HP = 40f;
    public float ATK = 40f;
    public float DEF = 15f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 40f;
        HP = MaxHP;
        ATK = 40f;
        DEF = 15f;
        INI = 0f;
    }
}
