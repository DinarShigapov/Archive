﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Labs226_2021.Game
{
    class Activate: Unit
    {
        public static void Activ()
        {
            Warrior war = new Warrior("Кратос", 30, 15, 25, 10);
            Mage mag = new Mage("Геральт", 30, 15, 25, 10);
            Archer rog = new Archer("Леголас", 30, 15, 25, 10);

            Unit[] array = new Unit[3] { war, mag, rog };

            for (int i = 0; i < array.Length; i++)
            {

                array[i].PAttack = 0;
                array[i].MAttack = 0;
                array[i].PDefence = 0;
                array[i].MDefence = 0;
                array[i].Health = 0;
                array[i].Mana = 0;
                array[i].PAttack = 0;
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i].CurrencyHealth = array[i].Health;
            }



            mag.ShowInfo();
            Console.WriteLine();





            // Создание классов
            // Битва
            Console.WriteLine(array[0].CurrencyHealth);
            Console.WriteLine(array[1].PAttack);

            Console.WriteLine(array[0].CurrencyHealth - array[1].PAttack);






        }
    }
}
