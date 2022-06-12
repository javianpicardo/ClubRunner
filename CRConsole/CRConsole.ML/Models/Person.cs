using CRConsole.InterfaceModel;

namespace CRConsole.ML.Models
{
    public class Person : IPerson
    {
        public string FirstName { get; set; }
        public IPerson[] Children { get; set; }
    }
}
