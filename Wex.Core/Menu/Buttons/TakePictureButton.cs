using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neuzilla.Wex.Core.Menu.Buttons
{
    public class TakePictureButton : IClickMenuButton
    {
        public MenuButtonType Type
        {
            get { return MenuButtonType.pic_sysphoto; }
        }

        public string Name
        {
            get;
            set;
        }

        public string Key
        {
            get;
            set;
        }
    }
}
