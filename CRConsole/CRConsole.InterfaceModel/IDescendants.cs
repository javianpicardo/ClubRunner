using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRConsole.InterfaceModel
{
    public interface IDescendants : IBase
    {
       int Getdescendants(IPerson _person, string name);       
    }
}
