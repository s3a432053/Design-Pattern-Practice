namespace PrototypePattern.DeepClone
{
    // 有自我 Clone 能力的 Address
    public class Address : ICloneable
    {
        private string _addr;

        public string Get()
        {
            return _addr;
        }
        public void Set(string addr)
        {
            _addr = addr;
        }

        public object Clone()
        {
            Console.WriteLine("Clone 地址成功！");
            return (Address)base.MemberwiseClone();
        }
    }
}
