using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JebediaKerman : MonoBehaviour
{
    public float MaxHP = 30f;
    public float HP = 30f;
    public float ATK = 50f;
    public float DEF = 60f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 30f;
        HP = MaxHP;
        ATK = 50f;
        DEF = 60f;
        INI = 0f;
    }
}
