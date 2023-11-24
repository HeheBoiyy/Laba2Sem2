using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2Sem2
{
    public class EndNotifier : IReactProtectionFall
    {
        public int LayerReactorNumber { get; set; }
        public string Message {get;set;}
        public void Subscribe(Skyda skyda)
        {
            skyda.ProtectionFall += new Skyda.ProtectionFallHandler(OnProtectionFall);
        }
        public void OnProtectionFall(object obj, ProtectionFallEventArgs protectionFallEventArgs)
        {
            LayerReactorNumber = protectionFallEventArgs.FalledProtectionLayers;
            if (LayerReactorNumber == protectionFallEventArgs.protectionSystem.LayerNumber)
            {
                Message = $"{protectionFallEventArgs.protectionSystem.Title}      {protectionFallEventArgs.protectionSystem.Data}     Слой:{LayerReactorNumber}     Прошло дней сумарно:{protectionFallEventArgs.protectionSystem.DaysGone}";
                Console.WriteLine(Message);
            }
        }
    }
}
