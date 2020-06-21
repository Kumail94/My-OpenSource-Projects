using Data_Structures_and_algorithms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_algorithms
{
    public class FactoryPattern
    {
        public static void FactoryMainMethod()
        {
            Console.WriteLine("\nEnter an Object type of a class");
            string typeofObject = Console.ReadLine();
            IFactory factory = Factory.FactoryMethod(typeofObject);
            Console.WriteLine(factory.GetRepository());
        }
    }
    interface IFactory
    {
        RespositoryTable GetRepository();
        test GetTest();
    }
    class Repository : IFactory
    {
        public RespositoryTable GetRepository()
        {
            Console.WriteLine("Enter a Repository Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a Repository Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Repository Contact Number");
            string contact = Console.ReadLine();

            RespositoryTable res = new RespositoryTable();
            res.Name = name;
            res.Age = age;
            res.ContactNo = contact;
            TestDBEntt ent = new TestDBEntt();
            ent.RespositoryTables.Add(res);
            return res;
        }

        public test GetTest()
        {
            Console.WriteLine("Enter a Test Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a Test Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Test Salary");
            string salary = Console.ReadLine();

            test t = new test();
            t.EmployeeName = name;
            t.Age = age;
            t.EmployeeSalary = salary;
            TestDBEntt ent = new TestDBEntt();
            ent.tests.Add(t);
            return t;
        }
    }
    class Test : IFactory
    {
        public RespositoryTable GetRepository()
        {

            Console.WriteLine("Enter a Repository Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a Repository Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Repository Contact Number");
            string contact = Console.ReadLine();

            RespositoryTable res = new RespositoryTable();
            res.Name = name;
            res.Age = age;
            res.ContactNo = contact;
            TestDBEntt ent = new TestDBEntt();
            ent.RespositoryTables.Add(res);
            return res;
        }

        public test GetTest()
        {
            Console.WriteLine("Enter a Test Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a Test Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Test Salary");
            string salary = Console.ReadLine();

            test t = new test();
            t.EmployeeName = name;
            t.Age = age;
            t.EmployeeSalary = salary;
            TestDBEntt ent = new TestDBEntt();
            ent.tests.Add(t);
            return t;
        }
    }
    class Factory
    {
        
        public static IFactory FactoryMethod(string typeOfObject)
        {
            IFactory obj = null;
            if(typeOfObject == "Repository")
            {
                Console.WriteLine("\n Repository Class Object");
                obj = new Repository();
            }
            else if(typeOfObject == "Test")
            {
                Console.WriteLine("\n Test Class Object");
                obj = new Test();
            }
            return obj;
        }
    }
}
