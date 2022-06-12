using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRConsole.InterfaceModel;
using CRConsole.Factory;

namespace CRConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Load person object through factory Class.
            IBase objPerson = Factory.Factory.Create("Person");
            //Load Seed Data for Person Class.
            objPerson = Factory.Factory.SeedPerson();
            String descendantString = "Steve";
            IDescendants objDescendants = (IDescendants)Factory.Factory.Create("Descendants");
            int Count = objDescendants.Getdescendants((IPerson)objPerson, descendantString);
            Console.WriteLine("The count of Descendants with Name: " + descendantString + " are :"+Count);
            Console.WriteLine("Press Enter to Exit!");
            Console.ReadLine();
        }
    }
}
