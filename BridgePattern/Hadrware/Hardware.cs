using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    class Hardware
    {
        protected Software _Software;
        public void  SetHardware(Software software)
        {
            _Software = software;
        }


        public virtual void Operation()
        {
            _Software.Operation();
        }

    }
}
