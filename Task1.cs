using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct_c_
{
    struct Drib
    {
        public int nominator;
        public int denomirator;

        public Drib Plus(Drib b)
        {
            Drib result= new Drib();

            if (this.denomirator == b.denomirator)
            {
                result.nominator = this.nominator+ b.nominator;
                result.denomirator = b.denomirator;
            }    
            else
            {
                result.denomirator =this.denomirator* b.denomirator;
                result.nominator = this.nominator * b.denomirator + b.nominator * this.denomirator;
            }
            return result;
        }
        public Drib Minus( Drib b)
        {
            Drib result = new Drib();

            if (this.denomirator == b.denomirator)
            {
                result.nominator = this.nominator - b.nominator;
                result.denomirator = b.denomirator;
            }
            else
            {
                result.denomirator = this.denomirator * b.denomirator;
                result.nominator = this.nominator * b.denomirator - b.nominator * this.denomirator;
            }
            return result;
        }

        public Drib Multiply( Drib b)
        {
            Drib result = new Drib();

            result.nominator = this.nominator * b.nominator;
            result.denomirator = this.denomirator * b.denomirator;
            return result;
        }

        public Drib Division( Drib b)
        {
            Drib result = new Drib();

            result.nominator = this.nominator * b.denomirator;
            result.denomirator = this.denomirator * b.nominator;
            return result;
        }

        public void Show()
        {
            Console.WriteLine($"{this.nominator}/{this.denomirator}");
        }
    }

    internal class Task1
    {
        public static void task1()
        {
            Drib drib1 = new Drib();
            Console.WriteLine("enter drib1 nominator -> "); drib1.nominator = int.Parse(Console.ReadLine());
            Console.WriteLine("enter drib1 denominator -> "); drib1.denomirator = int.Parse(Console.ReadLine());

            Drib drib2 = new Drib();
            Console.WriteLine("enter drib2 nominator -> "); drib2.nominator = int.Parse(Console.ReadLine());
            Console.WriteLine("enter drib2 denominator -> "); drib2.denomirator = int.Parse(Console.ReadLine());
                
            drib1.Plus(drib2 ).Show();
            drib1.Minus(drib2).Show();
            drib1.Multiply(drib2).Show();
            drib1.Division(drib2).Show();


        }


    }
}
