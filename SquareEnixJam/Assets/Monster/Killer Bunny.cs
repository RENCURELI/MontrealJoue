using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillerBunny : MonoBehaviour
{
    public float MaxHP = 22f;
    public float HP = 22f;
    public float ATK = 80f;
    public float DEF = 80f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 22f;
        HP = MaxHP;
        ATK = 80f;
        DEF = 80f;
        INI = 0f;
    }
}
