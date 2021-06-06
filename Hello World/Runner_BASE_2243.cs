using System;
using System.Collections.Generic;
using System.Text;

namespace Hello_World
{
    public class Runner
    {
        public void Run()
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("This is line 2");
            Console.WriteLine("This is line 3");
            Console.WriteLine("Greeting from user 2");

            var calculator = new Calculator();
            int sum = calculator.Add(5, 7);
            Console.WriteLine(sum);

            Console.WriteLine($"The difference between 5 and 7 is {calculator.Substract(5, 7)}");

        }
    }

}
