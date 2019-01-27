using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class DuckTestDrive
    {
        static void Main(string[] args)
        {
            IDuck duck = new MallardDuck();

            ITurkey turkey = new WildTurkey();
            IDuck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("The Turkey says...");
            turkey.Gobble();
            turkey.Fly();

            Console.WriteLine("\r\nThe Duck says...");
            TestDuck(duck);

            Console.WriteLine("\r\nThe TurkeyAdapter says...");
            TestDuck(turkeyAdapter);

            Console.ReadKey();
        }

        static void TestDuck(IDuck duck)
        {
            duck.Quack();
            duck.Fly();
        }
    }
}
