using System;

namespace Part4_Ex2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Employee employee = new Employee("Nguyen", "Nhat", "Hanoi", 01234, 1200);
            Console.WriteLine(employee.ToString());
            Console.WriteLine(employee.CalculateBonus(100));
        }
    }
}