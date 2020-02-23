using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loup : MonoBehaviour
{
    public float MaxHP = 5f;
    public float HP = 5f;
    public float ATK = 20f;
    public float DEF = 30f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 5f;
        HP = MaxHP;
        ATK = 20f;
        DEF = 30f;
        INI = 0f;
    }
}
