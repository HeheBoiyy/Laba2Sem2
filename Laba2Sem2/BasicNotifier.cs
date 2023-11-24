using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2Sem2
{
    public class BasicNotifier : IReactProtectionFall
    {
        public int LayerReactorNumber {  get; set; }
        public string Message {  get; set; }
        public void Subcribe(Skyda skyda)
        {
            skyda.ProtectionFall += new Skyda.ProtectionFallHandler(OnProtectionFall);
        }

        public void OnProtectionFall(object obj, ProtectionFallEventArgs protectionFallEventArgs)
        {
            LayerReactorNumber = protectionFallEventArgs.FalledProtectionLayers;
            if (LayerReactorNumber != protectionFallEventArgs.protectionSystem.LayerNumber)
            {
                Message = $"{protectionFallEventArgs.protectionSystem.Title}      {protectionFallEventArgs.protectionSystem.Data}     Слой:{LayerReactorNumber}     Прошло дней: {protectionFallEventArgs.protectionSystem.DaysGone}";
                Console.WriteLine(Message);
            }
        }

    }
}
