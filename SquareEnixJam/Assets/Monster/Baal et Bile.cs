using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaaletBile : MonoBehaviour
{
    public float MaxHP = 60f;
    public float HP = 60f;
    public float ATK = 60f;
    public float DEF = 50f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 60f;
        HP = MaxHP;
        ATK = 60f;
        DEF = 50f;
        INI = 0f;
    }
}
