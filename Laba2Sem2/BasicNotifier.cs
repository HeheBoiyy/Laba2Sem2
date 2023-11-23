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
            if (protectionFallEventArgs.FalledProtectionLayers != protectionFallEventArgs.protectionSystem.LayerNumber)
            {
                Message = $"{protectionFallEventArgs.protectionSystem.Title}      {protectionFallEventArgs.protectionSystem.Data}     {protectionFallEventArgs.protectionSystem.FalledLayerNumber}     Прошло дней: {protectionFallEventArgs.protectionSystem.DaysGone}";
                Console.WriteLine(Message);
            }
        }

    }
}
