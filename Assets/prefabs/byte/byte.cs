using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Byte : MonoBehaviour
{
    [SerializeField] Bit[] bits = new Bit[8];
    [SerializeField] private int value = 0;



    void Update()
    {
        BinToDec();
    }

    private void BinToDec()
    {
        value = 0;
        if (bits[0].state) value += 1;  // 2^0 = 1
        if (bits[1].state) value += 2;  // 2^1 = 2
        if (bits[2].state) value += 4;  // 2^2 = 4
        if (bits[3].state) value += 8;  // 2^3 = 8
        if (bits[4].state) value += 16; // 2^4 = 16
        if (bits[5].state) value += 32; // 2^5 = 32
        if (bits[6].state) value += 64; // 2^6 = 64
        if (bits[7].state) value += 128;// 2^7 = 128
    }

    public void SetValue(int newValue)
    {

        if (newValue > 255)
        {
            newValue = 255;
        }

        this.value = newValue;

        if (newValue >= 128)
        {
            bits[7].state = true;
            newValue -= 128;
        }
        else
        {
            bits[7].state = false;
        }

        if (newValue >= 64)
        {
            bits[6].state = true;
            newValue -= 64;
        }
        else
        {
            bits[6].state = false;
        }


        if (newValue >= 32)
        {
            bits[5].state = true;
            newValue -= 32;
        }
        else
        {
            bits[5].state = false;
        }

        if (newValue >= 16)
        {
            bits[4].state = true;
            newValue -= 16;
        }
        else
        {
            bits[4].state = false;
        }

        if (newValue >= 8)
        {
            bits[3].state = true;
            newValue -= 8;
        }
        else
        {
            bits[3].state = false;
        }

        if (newValue >= 4)
        {
            bits[2].state = true;
            newValue -= 4;
        }
        else
        {
            bits[2].state = false;
        }

        if (newValue >= 2)
        {
            bits[1].state = true;
            newValue -= 2;
        }
        else
        {
            bits[1].state = false;
        }

        if (newValue >= 1)
        {
            bits[0].state = true;
            newValue -= 1;
        }
        else
        {
            bits[0].state = false;
        }


    }
}