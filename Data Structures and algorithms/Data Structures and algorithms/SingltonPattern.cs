using Data_Structures_and_algorithms.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_Structures_and_algorithms
{
    class SingltonPattern
    {
        public static void SingltonMainMethod()
        {
            Singlton obj1 = Singlton.CreateObject();
            Singlton obj2 = Singlton.CreateObject();
            obj1.RepositoryMethod();
            obj2.TestMethod();
        }
    }
    sealed class Singlton
    {
        private Singlton()
        {
            Console.WriteLine("Singlton Constructor!");
        }
        private static Singlton obj = null;
        public static Singlton CreateObject()
        {
            if (obj == null)
            {
                obj = new Singlton();
            }
            return obj;
        }

        public void TestMethod()
        {
            Console.WriteLine("Enter a Test Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a Test Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Test Salary");
            string salary = Console.ReadLine();
            test objT = new test();
            objT.EmployeeName = name;
            objT.Age = age;
            objT.EmployeeSalary = salary;
            TestDBEntt entity = new TestDBEntt();
            var t = entity.tests.Add(objT);
            Console.WriteLine("\n {0} \n {1} \n {2} ", t.EmployeeName, t.Age, t.EmployeeSalary);
        }

        public void RepositoryMethod()
        {
            Console.WriteLine("Enter a Repository Name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter a Repository Age");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter a Repository Contact Number");
            string contact = Console.ReadLine();
            RespositoryTable objR = new RespositoryTable();
            objR.Name = name;
            objR.Age = age;
            objR.ContactNo = contact;
            TestDBEntt entity = new TestDBEntt();
            var r = entity.RespositoryTables.Add(objR);
            Console.WriteLine("\n {0} \n {1} \n {2} ", r.Name , r.Age , r.ContactNo);
        }
    }
}