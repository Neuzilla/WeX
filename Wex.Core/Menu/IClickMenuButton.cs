using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Menu
{
    public interface IClickMenuButton:IMenuButton
    {
        string Key { get; set; }
    }
}
