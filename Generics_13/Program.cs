using static Generics_13.GenericsMax;

namespace Generics_13
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Finding Maximum Numbers By Using Generics");
            int[] intArray = { 100, 75, 50 };
            GenericMaximum<int> generics = new GenericMaximum<int>(intArray);
            generics.PrintMaxValue();
            Console.WriteLine("-----------------------------------");

        }
    }
}                

