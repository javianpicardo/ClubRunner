using CRConsole.InterfaceModel;
using CRConsole.ML.Models;
using CRConsole.ML;
using Unity;

namespace CRConsole.Factory
{
    public static class Factory
    {
        private static IUnityContainer container = null;

        public static IBase Create(string type)
        {
            if (container == null)
            {
                container = new UnityContainer();
                container.RegisterType<IBase, Person>("Person");
                container.RegisterType<IBase, Descendants>("Descendants");
            }
            return container.Resolve<IBase>(type);
        }

        public static IPerson SeedPerson()
        {
            IPerson person = new Person();
            Person[] personNull = new Person[0];
            Person[] person0 = new Person[10];
            person = new Person { FirstName = "Steve", Children = person0 };

            person0[0] = new Person { FirstName = "Steve", Children = personNull };
            person0[1] = new Person { FirstName = "Steve", Children = personNull };
            person0[2] = new Person { FirstName = "Steve" , Children = personNull };
            person0[3] = new Person { FirstName = "Steve" , Children = personNull };
            person0[4] = new Person { FirstName = "Steve" , Children = personNull };
            person0[5] = new Person { FirstName = "Steve" , Children = personNull };
            person0[6] = new Person { FirstName = "Steve" , Children = personNull };
            person0[7] = new Person { FirstName = "Steve" , Children = personNull };
            person0[8] = new Person { FirstName = "Steve" , Children = personNull };
            Person[] person0_10 = new Person[1];
            person0_10[0] = new Person { FirstName = "Picardo", Children = personNull };
      
            person0[9] = new Person { FirstName = "Steve", Children = person0_10 };           

            person.Children[9].Children = person0_10;
            return person;
        }


    }
}
