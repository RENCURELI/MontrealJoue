using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BebezombideMinecraft : MonoBehaviour
{
    public float MaxHP = 15f;
    public float HP = 15f;
    public float ATK = 20f;
    public float DEF = 40f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 15f;
        HP = MaxHP;
        ATK = 20f;
        DEF = 40f;
        INI = 0f;
    }
}
