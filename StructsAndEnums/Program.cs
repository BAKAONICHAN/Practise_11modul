using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StructsAndEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Nuriddin";
            int payment = 1200000;
           const int size = 3;
            int[] array = new int[size];
            Vacancies  type = Vacancies.Manager;
            WriteLine(type);
            Employee employee = new Employee();
            employee.Name = name;
            employee.Payment = payment;
            employee.Vacansy = type;                     
            employee.DateOfFReceivingTheGob = new int[size] ;
           


            
            ReadLine();

        }
    }
}
