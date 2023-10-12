namespace Adunare2Numere
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("a=");a=int.Parse(Console.ReadLine()); 
            Console.Write("b=");b=int.Parse(Console.ReadLine());
            if (a <= int.MaxValue - b) 
            {
                Console.WriteLine(a + b);
            }
            else
            {
                Console.WriteLine("ArithmeticOverflow");
            }
        }
    }
}