using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyattCalculator.classes
{
    class Calculate
    {
        System.Data.DataTable dt = new DataTable();

        public string toBeComputed { get; set; }
        public double curNum { get; set; }
        public double num1 { get; set; }
        public double num2 { get; set; }
        public string op { get; set; } 
        
        public void add (Calculate n)
        {
            n.num1 = n.curNum;
            n.op = "+";
            n.toBeComputed += "+";
            //Console.WriteLine("num1 = " + n.num1);
        }

        public void subtract(Calculate n)
        {
            num1 = n.curNum;
            n.op = "-";
            n.toBeComputed += "-";
            //Console.WriteLine("num1 = " + num1);
        }

        public void multiply(Calculate n)
        {
            num1 = n.curNum;
            n.op = "*";
            n.toBeComputed += "*";
            //Console.WriteLine("num1 = " + num1);
        }

        public void divide(Calculate n)
        {
            num1 = n.curNum;
            n.op = "/";
            n.toBeComputed += "/";
            //Console.WriteLine("num1 = " + num1);
        }

        public void rem(Calculate n)
        {
            num1 = n.curNum;
            n.op = "%";
            n.toBeComputed += "%";
        }

        public double work(Calculate n)
        {
            double answer = 0;

            if(n.op == "+") //add
            {
                answer = n.num1 + n.num2;
            }
            if (n.op == "-") //add
            {
                answer = n.num1 - n.num2;
            }
            if (n.op == "*") //add
            {
                answer = n.num1 * n.num2;
            }
            if (n.op == "/") //add
            {
                answer = n.num1 / n.num2;
            }
            if (n.op == "%") //add
            {
                answer = n.num1 % n.num2;
            }

            return answer;
        }

        public double math(Calculate c)
        {
            double result = 0;
            try
            {
                if (c.toBeComputed != null)
                {
                    Console.WriteLine(toBeComputed);
                    result = Convert.ToDouble(new DataTable().Compute(toBeComputed, null));

                }
            }
            catch(Exception e)
            {
                return 3911009001193.246810; //this number just signifies an error has occored
            }
            return result;
        }
    }
}
