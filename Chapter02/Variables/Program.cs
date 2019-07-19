using System;

namespace Chapter02_Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            // let the height variable become equal to the value 1.88
            double heightInMetres = 1.88;
            Console.WriteLine($"The variable {nameof(heightInMetres)} has the value " + 
                $"{heightInMetres}");
        }
    }
}
