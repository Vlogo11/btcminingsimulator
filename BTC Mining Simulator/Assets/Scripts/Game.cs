using System.Collections;
using UnityEngine.UI;
using UnityEngine;

public class Game : MonoBehaviour
{
    public Text ui;

    public void Increment()
    {
        GameManager.o2 += GameManager.multiplier;
        PlayerPrefs.SetInt("o2", GameManager.o2);
    }


    public void Buy(int num)
    {
        if (num == 0 && GameManager.o2 >= 0)
        {
            PlayerPrefs.DeleteAll();
        }

        if (num == 1 && GameManager.o2 >= 500)
        {
            GameManager.multiplier += 1;
            GameManager.o2 -= 500;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 2 && GameManager.o2 >= 500000000)
        {
            GameManager.multiplier += 4000000;
            GameManager.o2 -= 500000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 3 && GameManager.o2 >= 2000000000)
        {
            GameManager.multiplier += 20000000;
            GameManager.o2 -= 2000000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 4 && GameManager.o2 >= 2000000000)
        {
            GameManager.multiplier += 90000000;
            GameManager.o2 -= 2000000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 5 && GameManager.o2 >= 12000)
        {
            GameManager.multiplier += 1500;
            GameManager.o2 -= 12000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }
        if (num == 6 && GameManager.o2 >= 50000)
        {
            GameManager.multiplier += 6500;
            GameManager.o2 -= 50000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 7 && GameManager.o2 >= 0)
        {
            GameManager.multiplier += 0;
            GameManager.o2 = 0;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 8 && GameManager.o2 >= 500000)
        {
            GameManager.multiplier += 1800;
            GameManager.o2 -= 500000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 9 && GameManager.o2 >= 1000000)
        {
            GameManager.multiplier += 4000;
            GameManager.o2 -= 1000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 10 && GameManager.o2 >= 3000000)
        {
            GameManager.multiplier += 15000;
            GameManager.o2 -= 3000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 11 && GameManager.o2 >= 10000000)
        {
            GameManager.multiplier += 55000;
            GameManager.o2 -= 10000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 12 && GameManager.o2 >= 50000000)
        {
            GameManager.multiplier += 300000;
            GameManager.o2 -= 50000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 13 && GameManager.o2 >= 2000)
        {
            GameManager.multiplier += 5;
            GameManager.o2 -= 2000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 14 && GameManager.o2 >=6000)
        {
            GameManager.multiplier += 17;
            GameManager.o2 -= 6000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 15 && GameManager.o2 >= 15000)
        {
            GameManager.multiplier += 45;
            GameManager.o2 -= 15000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 16 && GameManager.o2 >= 50000)
        {
            GameManager.multiplier += 160;
            GameManager.o2 -= 50000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 17 && GameManager.o2 >= 200000)
        {
            GameManager.multiplier += 660;
            GameManager.o2 -= 200000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 18 && GameManager.o2 >= 1000)
        {
            GameManager.multiplier += 60;
            GameManager.o2 -= 1000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 19 && GameManager.o2 >= 5000)
        {
            GameManager.multiplier += 400;
            GameManager.o2 -= 5000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 20 && GameManager.o2 >= 20000)
        {
            GameManager.multiplier += 2000;
            GameManager.o2 -= 20000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 21 && GameManager.o2 >=50000)
        {
            GameManager.multiplier += 5500;
            GameManager.o2 -= 50000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 22 && GameManager.o2 >= 150000)
        {
            GameManager.multiplier += 20000;
            GameManager.o2 -= 150000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 23 && GameManager.o2 >= 500000)
        {
            GameManager.multiplier += 80000;
            GameManager.o2 -= 500000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 24 && GameManager.o2 >= 210000)
        {
            GameManager.multiplier += 700;
            GameManager.o2 -= 210000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 25 && GameManager.o2 >= 210000)
        {
            GameManager.multiplier += 100000000;
            GameManager.o2 -= 700000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        // Core I3

        if (num == 101 && GameManager.o2 >= 5000)
        {
            GameManager.multiplier += 10;
            GameManager.o2 -= 5000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 102 && GameManager.o2 >= 12500)
        {
            GameManager.multiplier += 25;
            GameManager.o2 -= 12500;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 103 && GameManager.o2 >= 25000)
        {
            GameManager.multiplier += 50;
            GameManager.o2 -= 25000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 104 && GameManager.o2 >= 20000)
        {
            GameManager.multiplier += 50;
            GameManager.o2 -= 20000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 105 && GameManager.o2 >= 50000)
        {
            GameManager.multiplier += 125;
            GameManager.o2 -= 50000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 106 && GameManager.o2 >= 100000)
        {
            GameManager.multiplier += 250;
            GameManager.o2 -= 100000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 107 && GameManager.o2 >= 60000)
        {
            GameManager.multiplier += 170;
            GameManager.o2 -= 60000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 108 && GameManager.o2 >= 150000)
        {
            GameManager.multiplier += 425;
            GameManager.o2 -= 150000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 109 && GameManager.o2 >= 300000)
        {
            GameManager.multiplier += 850;
            GameManager.o2 -= 300000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 110 && GameManager.o2 >= 150000)
        {
            GameManager.multiplier += 450;
            GameManager.o2 -= 150000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 111 && GameManager.o2 >= 375000)
        {
            GameManager.multiplier += 1125;
            GameManager.o2 -= 375000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 112 && GameManager.o2 >= 750000)
        {
            GameManager.multiplier += 2250;
            GameManager.o2 -= 750000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 113 && GameManager.o2 >= 500000)
        {
            GameManager.multiplier += 1600;
            GameManager.o2 -= 500000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 114 && GameManager.o2 >= 1250000)
        {
            GameManager.multiplier += 4000;
            GameManager.o2 -= 1250000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 115 && GameManager.o2 >= 2500000)
        {
            GameManager.multiplier += 8000;
            GameManager.o2 -= 2500000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 116 && GameManager.o2 >= 2000000)
        {
            GameManager.multiplier += 6600;
            GameManager.o2 -= 2000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 117 && GameManager.o2 >= 5000000)
        {
            GameManager.multiplier += 16500;
            GameManager.o2 -= 5000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 118 && GameManager.o2 >= 10000000)
        {
            GameManager.multiplier += 33000;
            GameManager.o2 -= 10000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        //AD
        if (num == 137 && GameManager.o2 >= 0)
        {
            GameManager.multiplier += 0;
            GameManager.o2 += 100;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 138 && GameManager.o2 >= 0)
        {
            GameManager.multiplier += 1;
            GameManager.o2 += 0;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        // Core I5

        if (num == 119 && GameManager.o2 >= 2100000)
        {
            GameManager.multiplier += 7000;
            GameManager.o2 -= 2100000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 120 && GameManager.o2 >= 5250000)
        {
            GameManager.multiplier += 17500;
            GameManager.o2 -= 5250000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 121 && GameManager.o2 >= 10500000)
        {
            GameManager.multiplier += 35000;
            GameManager.o2 -= 10500000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 122 && GameManager.o2 >= 5000000)
        {
            GameManager.multiplier += 18000;
            GameManager.o2 -= 5000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 123 && GameManager.o2 >= 12500000)
        {
            GameManager.multiplier += 45000;
            GameManager.o2 -= 12500000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 124 && GameManager.o2 >= 25000000)
        {
            GameManager.multiplier += 90000;
            GameManager.o2 -= 25000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 125 && GameManager.o2 >= 10000000)
        {
            GameManager.multiplier += 40000;
            GameManager.o2 -= 10000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 126 && GameManager.o2 >= 25000000)
        {
            GameManager.multiplier += 100000;
            GameManager.o2 -= 25000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 127 && GameManager.o2 >= 50000000)
        {
            GameManager.multiplier += 200000;
            GameManager.o2 -= 50000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 128 && GameManager.o2 >= 30000000)
        {
            GameManager.multiplier += 150000;
            GameManager.o2 -= 30000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 129 && GameManager.o2 >= 75000000)
        {
            GameManager.multiplier += 375000;
            GameManager.o2 -= 75000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 130 && GameManager.o2 >= 150000000)
        {
            GameManager.multiplier += 750000;
            GameManager.o2 -= 150000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 131 && GameManager.o2 >= 100000000)
        {
            GameManager.multiplier += 550000;
            GameManager.o2 -= 100000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 132 && GameManager.o2 >= 250000000)
        {
            GameManager.multiplier += 1375000;
            GameManager.o2 -= 250000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 133 && GameManager.o2 >= 500000000)
        {
            GameManager.multiplier += 2750000;
            GameManager.o2 -= 500000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 134 && GameManager.o2 >= 500000000)
        {
            GameManager.multiplier += 3000000;
            GameManager.o2 -= 500000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 135 && GameManager.o2 >= 1250000000)
        {
            GameManager.multiplier += 7500000;
            GameManager.o2 -= 1250000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

        if (num == 136 && GameManager.o2 >= 1850000000)
        {
            GameManager.multiplier += 11100000;
            GameManager.o2 -= 1850000000;
            PlayerPrefs.SetInt("o2", GameManager.o2);
            PlayerPrefs.SetInt("multiplier", GameManager.multiplier);
        }

    }

    void Update()
    {
        ui.text = "MONEY: " + GameManager.o2;
    }
}
