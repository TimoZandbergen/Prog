﻿using System;

namespace Les01
{
    class Program
    {

        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();
            HealthPotion potion = new HealthPotion("HealthPotion", "Heal for amount");


            //inventory.Additem(new Item("Health", 50));
            //inventory.Additem(new Item("Attack", 10));

            inventory.Additem(potion);

            inventory.GetItem();
            foreach (Item it in inventory.GetItem())
            {
                //Console.WriteLine(it.health);
                //Console.WriteLine(it.attack);
                it.Use();
            }
            int userinput;
            
            //Console.WriteLine("Press 1 to heal");
            string input = Console.ReadLine();
            int healNumber;
            if (int.TryParse(input, out healNumber))
            {
                while (true)
                {
                    bool validnr;
                    switch (healNumber)
                    {

                        case 0:
                            Console.WriteLine("Healed HP with 50");
                            validnr = true;
                            break;


                        case 1:
                            Console.WriteLine("Dropped healthpotion");
                            validnr = true;
                            break;

                        default:
                            Console.WriteLine("wrong number");
                            validnr = true;
                            break;

                    }
                    if (validnr == true)
                    {
                        break;
                    }

                }
            }
            

            //Console.WriteLine("you healed");
            userinput = Console.Read();
            //Console.WriteLine("heal value = {0}", userinput);

            
            // als je op 1 klikt heal je en op 2 dan drop je je healthpotion. als je niks heb dan ander bericht
        }
    }
}