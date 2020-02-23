using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gobelin : MonoBehaviour
{
    public float MaxHP = 8f;
    public float HP = 8f;
    public float ATK = 30f;
    public float DEF = 25f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 8f;
        HP = MaxHP;
        ATK = 30f;
        DEF = 25f;
        INI = 0f;
    }
}
