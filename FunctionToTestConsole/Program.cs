using System;

namespace FunctionToTestConsole {
    class Program {

        static void Main(string[] args) {

            var ff = new ForcastingFunction();
            try {
                 // Multiplier is zero
                 var result = ff.Forecast(-11, 11); //expect Exception
                Console.WriteLine("Test Failed!");
            } catch (Exception ex) {
                Console.WriteLine("Test Passed!");
            }


        }
    }
}
