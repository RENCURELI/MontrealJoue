using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JabaleButt : MonoBehaviour
{
    public float MaxHP = 60f;
    public float HP = 60f;
    public float ATK = 25f;
    public float DEF = 48f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 60f;
        HP = MaxHP;
        ATK = 25f;
        DEF = 48f;
        INI = 0f;
    }
}
