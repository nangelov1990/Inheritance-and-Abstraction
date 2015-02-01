﻿namespace Animals.Data
{
    using System;
    using Animals.Data.Enum;

    public class Cat : Animal
    {
        public Cat(string name, int age, Genders gender)
            : base(name, age, gender)
        {
        }

        public override void ProduceSound()
        {
            Console.WriteLine("I say myauuu!");
        }
    }
}
