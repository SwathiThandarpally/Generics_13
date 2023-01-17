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

        }
    }
}                

