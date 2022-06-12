using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRConsole.InterfaceModel
{
    public interface IPerson : IBase
    {
        string FirstName { get; set; }
        IPerson[] Children { get; set; }
    }
}
