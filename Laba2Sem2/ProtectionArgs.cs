using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2Sem2
{
    public class ProtectionFallEventArgs : EventArgs
    {
        public int FalledProtectionLayers { get; set; }
        public ProtectionSystem protectionSystem {get;}
        public ProtectionFallEventArgs(int falledProtectionLayers, ProtectionSystem protectionSystem)
        {
            FalledProtectionLayers = falledProtectionLayers;
            this.protectionSystem = protectionSystem;
        }
    }
}
