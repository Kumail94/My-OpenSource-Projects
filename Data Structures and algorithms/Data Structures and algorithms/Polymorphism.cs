using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_algorithms
{
    class Polymorphism
    {
        public Polymorphism()
        {
            Console.WriteLine("Based Constructor");
        }
        public virtual int MethodA(int n1, int n2)
        {
            return (n1 + n2);
        }
    }
    class MethodOverriding : Polymorphism
    {
        public MethodOverriding()
        {
            Console.WriteLine("Derived Construcor");
        }
        //public override int MethodA(int n1, int n2)
        //{
        //    if (n1 < 0 || n2 < 2)
        //    {
        //        Console.WriteLine("\n Values could not be less than 0");
        //        Console.WriteLine("\n Enter 1st Number");
        //        n1 = Convert.ToInt32(Console.ReadLine());
        //        Console.WriteLine("\n Enter 2nd Number");
        //        n2 = Convert.ToInt32(Console.ReadLine());
        //    }
        //    return (n1 + n2);

        }
    }
