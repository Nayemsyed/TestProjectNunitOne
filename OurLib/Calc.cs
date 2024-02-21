using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OurLib
{
    public class Calc
    {
        public int Add(int num1, int num2)
        {
            return num1+ num2;
        }
        public int Avg(int num1, int num2)
        {
            return (num1 + num2)/2;
        }
        public int Diff(int num1, int num2)
        {
            return num1 - num2;
        }
        public int Multi(int num1, int num2)
        {
            return num1 * num2;
        }
    }
}
