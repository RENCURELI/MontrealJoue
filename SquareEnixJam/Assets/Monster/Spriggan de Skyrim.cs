using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriggandeSkyrim : MonoBehaviour
{
    public float MaxHP = 35f;
    public float HP = 35f;
    public float ATK = 20f;
    public float DEF = 20f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 35f;
        HP = MaxHP;
        ATK = 20f;
        DEF = 20f;
        INI = 0f;
    }
}
