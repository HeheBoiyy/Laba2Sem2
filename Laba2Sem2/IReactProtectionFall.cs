using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2Sem2
{
    public interface IReactProtectionFall
    {
        public int LayerReactorNumber { get; set; }
        public string Message { get; set; }

        public void Subscribe(Skyda skyda)
        {
            skyda.ProtectionFall += new Skyda.ProtectionFallHandler(OnProtectionFall);
        }
        public void OnProtectionFall(object obj, ProtectionFallEventArgs protectionFallEventArgs)
        {
            
        }
    }
}
