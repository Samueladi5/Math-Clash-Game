using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Money : MonoBehaviour
{
    public static int money = 50000;

    public int GetMoney()
    {
        return money;
    }

    public int AddMoney(int plusMoney)
    {
        
        return money + plusMoney;
    }
}
