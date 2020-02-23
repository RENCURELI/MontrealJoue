using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LechapeaumagiquedeHarryPotter : MonoBehaviour
{
    public float MaxHP = 30f;
    public float HP = 30f;
    public float ATK = 5f;
    public float DEF = 30f;
    public float INI = 0f;

    private void Start()
    {
        MaxHP = 30f;
        HP = MaxHP;
        ATK = 5f;
        DEF = 30f;
        INI = 0f;
    }
}
