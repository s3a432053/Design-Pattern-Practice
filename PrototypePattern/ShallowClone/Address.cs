namespace PrototypePattern.ShallowClone
{
    // 沒有自我 Clone 能力的 Address
    public class Address
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
    }
}
