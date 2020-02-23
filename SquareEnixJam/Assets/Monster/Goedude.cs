using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goedude : MonoBehaviour
{
    public float MaxHP = 50f;
    public float HP = 50f;
    public float ATK = 20f;
    public float DEF = 40f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 50f;
        HP = MaxHP;
        ATK = 20f;
        DEF = 40f;
        INI = 0f;
    }
}
