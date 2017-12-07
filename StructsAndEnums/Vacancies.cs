using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace StructsAndEnums
{
    public struct  Employee
    {
        
        public string Name { get; set; }
        public Vacancies Vacansy { get; set; }
        public int Payment { get; set; }
        public int[] DateOfFReceivingTheGob { get; set; }
        public Employee(string name,int payment,int[] number)
        {
            const int size = 3;
            Name = name;
            Payment = payment;
            DateOfFReceivingTheGob = new int[size];
            Vacansy = Vacancies.Manager;
            for (int i = 0; i < size; i++)
            {
                DateOfFReceivingTheGob[i] = number[i];
                WriteLine(i);
            }
        }
    }
}
