using CRConsole.InterfaceModel;

namespace CRConsole.ML
{
    public class Descendants : IDescendants
    {
        public int descendants = 0;
        public int Getdescendants(IPerson _person, string name)
        {
            foreach (IPerson child in _person.Children)
            {
                if (child.FirstName == name)
                {
                    descendants++;
                };
                Getdescendants(child, name);
            }
            return descendants;
        }
    }
}
