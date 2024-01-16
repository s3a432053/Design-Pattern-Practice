namespace PrototypePattern.DeepClone
{
    // 鳴人 會使用影分身之術做 Clone
    public class Naruto : ICloneable
    {
        private Address addr;

        public Naruto()
        {
            Console.WriteLine("建立鳴人成功！");
        }

        public Address GetAddr()
        {
            return addr;
        }

        public void SetAddr(Address addr)
        {
            this.addr = addr;
        }

        public object Clone()
        {
            Console.WriteLine("鳴人影分身 (Clone) 成功！");
            Naruto naruto = (Naruto)base.MemberwiseClone();
            naruto.addr = (Address)addr.Clone();
            return naruto;
        }
    }
}
