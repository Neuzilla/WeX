using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Menu.Buttons
{
    public class ViewUrlButton : IViewMenuButton
    {
        public MenuButtonType Type
        {
            get { return MenuButtonType.view; }
        }

        public string Name
        {
            get;
            set;
        }

        public string Url
        {
            get;
            set;
        }
        public string MediaId
        {
            get;
            set;
        }
    }
}
