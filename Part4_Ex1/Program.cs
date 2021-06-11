using System;
using System.Text;

namespace Part4_Ex1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var atoms = new Atom[10];
            var currentIndex = 0;
            Console.WriteLine("Atomic Information");
            Console.WriteLine("==================");
            while (true)
            {
                if (currentIndex >= 10)
                {
                    break;
                }

                var atom = new Atom();
                var result = atom.accept();
                if (result)
                {
                    atoms[currentIndex] = atom;
                    currentIndex++;
                }else if (atom.AtomicNumber == 0)
                {
                    break;
                }
            }

            Console.WriteLine("No Sym Name Weight!");
            Console.WriteLine("---------------------------------");
            for (var i = 0; i < currentIndex; i++)
            {
                atoms[i].display();
            }
        }
    }
}