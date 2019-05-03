using System;
using System.Reflection;

namespace RelayAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            var resultOne = ControllerRepository.Call("John", "Save", null);
            var resultTwo = ControllerRepository.Call("John", "Get", new object[] { "get john" });
            var resultThird = ControllerRepository.Call("Test", "Save", null);
            var resultFourth = ControllerRepository.Call("Test", "Get", new object[] { "get test" });

            Console.WriteLine($"resultOne: {resultOne}");
            Console.WriteLine($"resultTwo: {resultTwo}");
            Console.WriteLine($"resultThird: {resultThird}");
            Console.WriteLine($"resultFourth: {resultFourth}");
        }
    }
}
