using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2Sem2
{
    public class Skyda
    {
        public int KnownFalledLayers = 0;
        public int FalledLayers = 0;
        public ProtectionSystem protection;
        public delegate void ProtectionFallHandler(object sender, ProtectionFallEventArgs protectionFallEventArgs);
        public event ProtectionFallHandler ProtectionFall;
        public virtual void Attack()
        {
            protection.GetAttack();
            NotifyProtectionFall();
        }
        public virtual void NotifyProtectionFall()
        {
            KnownFalledLayers = protection.FalledLayerNumber;
            if (protection.ProtecionCheck() == false)
            {
                ProtectionFall(this, new ProtectionFallEventArgs(protection.FalledLayerNumber, protection));
            }
        }
        public Skyda(ProtectionSystem protection)
        {
            this.protection = protection;
        }

    }
}
