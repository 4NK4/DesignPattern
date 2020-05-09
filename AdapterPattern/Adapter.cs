using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterPattern
{
    class Adapter:Targ
    {
        private Other other = new Other();

        public override void GetTarg()
        {
            other.GetSpecialTarg();
        }

    }
}
