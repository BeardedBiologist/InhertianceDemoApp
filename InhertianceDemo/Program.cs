﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone();
            Landline landline = new Landline();
            Phone phone = new Smartphone();

            landline.PlaceCall();
            smartphone.Carrier();
            phone.PlaceCall();

            Console.ReadLine();
        }
    }
}