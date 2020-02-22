using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LacetDefait : MonoBehaviour
{
    public float MaxHP = 1f;
    public float HP = 1f;
    public float ATK = 100f;
    public float DEF = 5f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 1f;
        HP = MaxHP;
        ATK = 100f;
        DEF = 5f;
        INI = 0f;
    }
}
