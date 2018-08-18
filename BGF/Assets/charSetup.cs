using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charSetup : MonoBehaviour
{
    public int pNum, curPos, curHP, MaxHP, SK1, SK2, SK3, SK4, SK5, SK6;

    public charSetup(int player, int currp, int currh, int fullHP, int S1, int S2, int S3, int S4, int S5, int S6)
    {
        pNum = player;
        curPos = currp;
        curHP = currh;
        MaxHP = fullHP;
        SK1 = S1;
        SK2 = S2;
        SK3 = S3;
        SK4 = S4;
        SK5 = S5;
        SK6 = S6;
    }


}
