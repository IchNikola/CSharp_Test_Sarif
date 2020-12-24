using System;
using System.Collections.Generic;
using System.Linq;

namespace TestSarif
{
    class Program
    {
        static void Main()
        {
            var result = Formula42(3, 5);
        }

        static int Formula42(int? coefficientA, int? coefficientB)
        {
            var data = new List<int>();
            if (coefficientA != null)
                data.Add(Formula42(coefficientA.Value));
            else if (coefficientB != null)
                data.Add(Formula42(coefficientA.Value));
            return data.SingleOrDefault();
        }

        static private int Formula42(int coefficient)
        {
            return coefficient;
        }
    }
}