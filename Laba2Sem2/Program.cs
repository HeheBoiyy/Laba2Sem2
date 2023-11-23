namespace Laba2Sem2
{
    internal class Program
    {
        static void Main(string[] args) 
        { 
            ProtectionSystem protectionSystem = new ProtectionSystem("IBM",7);
            Skyda skyda = new Skyda(protectionSystem);
            BasicNotifier basic = new BasicNotifier();
            EndNotifier end = new EndNotifier();
            basic.Subcribe(skyda);
            end.Subscribe(skyda);
            while (skyda.protection.LayerNumber > skyda.protection.FalledLayerNumber)
            {
                skyda.Attack();
            }
        }
    }
}
