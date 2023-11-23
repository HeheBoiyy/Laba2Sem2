using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba2Sem2
{
    public class ProtectionSystem
    {
        public string Title {  get; set; }
        public int DaysGone = 0;
        public DateTime Data { get; set; }
        public int LayerNumber {  get; set; }
        public int FalledLayerNumber = 0;
        public int PastFalledLayerNumber = 0;
        public ProtectionSystem(string title, int layerNumber)
        {
            Title = title;
            Data = DateTime.Now;
            LayerNumber = layerNumber;
        }
        public virtual bool ProtecionCheck()
        {
            DaysGone++;
            Data = Data.AddDays(1);
            if (PastFalledLayerNumber!=FalledLayerNumber)
            {
                PastFalledLayerNumber = FalledLayerNumber;
                return false;
            }
            return true;
        }
        public virtual void GetAttack() 
        {
            Random rnd = new Random();
            int atacker = rnd.Next(0, 10);
            if ( atacker <= 2 )
            {
                FalledLayerNumber++;
            }
        }
    }
}
