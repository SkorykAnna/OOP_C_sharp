using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;



namespace Project1
{
    public class Bird
    {
        public string Name;
        public int Weight;

        public Bird(string name, int weight)
        {
            this.Name = name;
            this.Weight = weight;
        }
       public override string ToString() { return Name; }
    }


    class Class1
    {
        static void Main(string[] args)
        {
            List<Bird> birds = new List<Bird>();
            birds.Add(new Bird("Kurka", 3));
            birds.Add(new Bird("Guska", 7));
            birds.Add(new Bird("Kachka", 5));
            birds.Add(new Bird("Indik", 10));

            var orderedWeight = from i in birds
                                orderby i.Weight ascending
                                select i;

            Console.WriteLine("List sorted by weight( from less to max):");
            foreach (var w in orderedWeight)
            {
                Console.WriteLine(w);
            }
            Console.WriteLine();

            var checkName = from i in birds
                              where i.Name[0] == 'K'
                              select i;


            Console.WriteLine("List of birds name starts with 'K':");
            foreach (var n in checkName)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine();

            var orderedWeightSelected = from i in birds
                                where i.Weight > 6
                                orderby i.Weight descending
                                select i;


            Console.WriteLine("List sorted by weight from max to less \n(birds have more then 6 kg):");
            foreach (var ws in orderedWeightSelected)
            {
                Console.WriteLine(ws);
            }
            Console.WriteLine();

        }

    }

}
