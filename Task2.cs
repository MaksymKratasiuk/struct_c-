using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_c_
{
    struct Integer
    {
        public int value;

        public Integer(int value)
        {
            this.value = value;
        }

        public Integer Add(Integer other)
        {
            return new Integer(value + other.value);
        }

        public Integer Subtract(Integer other)
        {
            return new Integer(value - other.value);
        }

        public Integer Multiply(Integer other)
        {
            return new Integer(value * other.value);
        }

        public Integer Divide(Integer other)
        {
            return new Integer(value / other.value);
        }
    }

    internal class Task2
    {
        public static void task2()
        {
            Console.WriteLine("enter first number -> ");
            Integer a = new Integer(int.Parse(Console.ReadLine()));

            Console.WriteLine("enter second number -> ");
            Integer b = new Integer(int.Parse(Console.ReadLine()));

            Integer c = a.Add(b);
            Console.WriteLine($"{a.value} + {b.value} = {c.value}");

             c = a.Subtract(b);
            Console.WriteLine($"{a.value} - {b.value} = {c.value}");

            c = a.Multiply(b);
            Console.WriteLine($"{a.value} * {b.value} = {c.value}");

            c = a.Divide(b);
            Console.WriteLine($"{a.value} / {b.value} = {c.value}");
        }
    }
}
