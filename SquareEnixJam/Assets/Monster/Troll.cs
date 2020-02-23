using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Troll : MonoBehaviour
{
    public float MaxHP = 40f;
    public float HP = 40f;
    public float ATK = 35f;
    public float DEF = 25f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 40f;
        HP = MaxHP;
        ATK = 35f;
        DEF = 25f;
        INI = 0f;
    }
}
