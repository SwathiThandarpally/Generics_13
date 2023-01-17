﻿using static Generics_13.GenericsMax;

namespace Generics_13
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Finding Maximum Numbers By Using Generics");
            //UC_1
            int[] intArray = { 100, 75, 50 };
            GenericMaximum<int> generics = new GenericMaximum<int>(intArray);
            generics.PrintMaxValue();
            Console.WriteLine("-----------------------------------");
            //UC_2
            float[] floatArray = { 1.50f, 0.75f, 5.0f };
            GenericMaximum<float> genericFloat = new GenericMaximum<float>(floatArray);
            genericFloat.PrintMaxValue();
            Console.WriteLine("-----------------------------------");
            //UC_3
            string[] stringArray = { "Appple", "Peach", "Banana" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
            Console.WriteLine("-----------------------------------");
            //Refactor_1
            Console.WriteLine("Find Maximum Number");
            int output = Refactor1.MaximumIntegerNumber(100, 75, 50);
            Console.WriteLine(output);
            float floatoutput = (float)Refactor1.MaximumFloatNumber(1.50f, 0.75f, 5.0f);
            Console.WriteLine(floatoutput);
            string strigoutput = Refactor1.MaximumStringNumber("Appple", "Peach", "Banana");
            Console.WriteLine(strigoutput);
            Console.WriteLine("-----------------------------------");

        }
    }
}                

