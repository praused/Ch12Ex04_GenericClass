﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12Ex04_GenericClass
{
    public class SuperCow : Cow
    {
        public void Fly()
        {
            Console.WriteLine($"{name} is flying!");
        }

        public SuperCow(string newName) : base(newName)
        {
        }

        public override void MakeANoise()
        {
            Console.WriteLine($"{name} says 'here I come to save the day!'");
        }
    }
}
