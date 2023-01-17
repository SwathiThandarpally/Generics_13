using static Generics_13.GenericsMax;

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
            //Refactor_2
            Console.WriteLine("Maximum Integer Is:" + Refactor2<int>.findmax(100, 75, 50));
            Console.WriteLine("Maximum Float Is:" + Refactor2<float>.findmax(1.50f, 0.75f, 5.0f));
            Console.WriteLine("Maximum String Is:" + Refactor2<string>.findmax("Appple", "Peach", "Banana"));
            Console.WriteLine("-----------------------------------");
            //UC_4
            Console.WriteLine("Maximum Integer Number is: ");
            int intoutput = ExtendMaxUC_4.MaximumIntegerNumber(50, 12, 60, 200);
            Console.WriteLine(intoutput);
            Console.WriteLine("Maximum Float Number is:");
            float output1 = ExtendMaxUC_4.MaximumFloatNumber(3.33f, 50.40f, 80.7f, 21.60f);
            Console.WriteLine(output1);
            Console.WriteLine("Maximum String value is : ");
            string stringoutput = ExtendMaxUC_4.MaximumStringNumber("Apple", "Banana", "PineApple", "Peach");
            Console.WriteLine(stringoutput);
            Console.WriteLine("-----------------------------------");
            //UC_5
            int[] intArray1 = { 2, 344, 432, 555, 678 };
            GenericMaximum<int> generic1 = new GenericMaximum<int>(intArray1);
            generic1.PrintMaxValue();
            float[] float1 = { 11.1f, 22.3f, 44.7f, 66.7f };
            GenericMaximum<float> generic2 = new GenericMaximum<float>(float1);
            generic2.PrintMaxValue();
            string[] string1 = { "Apple", "Banana", "PineApple", "Peach" };
            GenericMaximum<string> genericString1 = new GenericMaximum<string>(string1);
            genericString1.PrintMaxValue();
            Console.ReadKey();

        }
    }
}                

