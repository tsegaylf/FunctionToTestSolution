using System;
using System.Collections.Generic;
using System.Text;

namespace FunctionToTestConsole {
    public class ForcastingFunction {

        public int Multiplier { get; set; } = 0;

        public int Forecast(int x, int y) {
            if (x > 10 || x < -10 || y > 10 || y < -10) {
                throw new Exception("X or Y are outside the Domain");
                    }
            return ((x * x * x) + (y * y)) * Multiplier;
        }
    }
}
