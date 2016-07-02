using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Menu.Buttons
{
    public class MenuGroupButton:IMenuGroupButton
    {
        public MenuGroupButton()
        {
            this.SubButtons = new List<IMenuButton>();
        }

        public List<IMenuButton> SubButtons
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
    }
}
