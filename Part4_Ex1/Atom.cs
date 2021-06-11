using System;

namespace Part4_Ex1
{
    public class Atom
    {
        public int AtomicNumber { get; set; }
        string AtomicSymbol { get; set; }
        string NameAtomic { get; set; }
        float WeightAtomic { get; set; }
        
        public bool accept()
        {
            try
            {
                while (true)
                {
                    Console.Write("Enter atomic number: ");
                    if (int.TryParse(Console.ReadLine(), out var number))
                    {
                        AtomicNumber = number;
                        if (AtomicNumber == 0)
                        {
                            return false;    
                        }
                        break;
                    }
                }
                Console.Write("Enter atomic symbol: ");
                AtomicSymbol = Console.ReadLine();
                Console.Write("Enter atomic full name: ");
                NameAtomic = Console.ReadLine();
                Console.Write("Enter atomic weight: ");
                WeightAtomic = Convert.ToSingle(Console.ReadLine());
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            return false;
        }

        public void display()
        {
            Console.WriteLine("{0} - {1} - {2} - {3}", AtomicNumber, AtomicSymbol, NameAtomic, WeightAtomic);
        }
    }
}