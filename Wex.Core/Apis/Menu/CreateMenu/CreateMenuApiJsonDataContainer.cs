using Neuzilla.Wex.Core.Group;
using Neuzilla.Wex.Core.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Apis
{
    public class CreateMenuApiJsonDataContainer :ITopMenu, IJsonRequestContainer
    {
        public CreateMenuApiJsonDataContainer() {
            this.Buttons = new List<INamedMenuButton>();
        }

        public List<INamedMenuButton> Buttons
        {
            get;
            set;
        }
    }
}
