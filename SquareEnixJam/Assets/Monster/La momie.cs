using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lamomie : MonoBehaviour
{
    public float MaxHP = 20f;
    public float HP = 20f;
    public float ATK = 50f;
    public float DEF = 50f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 20f;
        HP = MaxHP;
        ATK = 50f;
        DEF = 50f;
        INI = 0f;
    }
}
