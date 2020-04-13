using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, result;
            Console.WriteLine("Informe um numero para a tabuada. ");
            num = int.Parse(Console.ReadLine());

            for (int i = 0; i <=10; i++)
            {
                result = num * i;
                Console.WriteLine(num+" x " + i +" = "+result);
            }
        }
    }
}
