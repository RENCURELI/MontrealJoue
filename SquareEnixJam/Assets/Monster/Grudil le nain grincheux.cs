using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grudillenaingrincheux : MonoBehaviour
{
    public float MaxHP = 50f;
    public float HP = 50f;
    public float ATK = 30f;
    public float DEF = 40f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 50f;
        HP = MaxHP;
        ATK = 30f;
        DEF = 40f;
        INI = 0f;
    }
}
