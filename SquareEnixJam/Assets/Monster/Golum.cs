using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Golum : MonoBehaviour
{
    public float MaxHP = 45f;
    public float HP = 45f;
    public float ATK = 80f;
    public float DEF = 40f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 45f;
        HP = MaxHP;
        ATK = 80f;
        DEF = 40f;
        INI = 0f;
    }
}
