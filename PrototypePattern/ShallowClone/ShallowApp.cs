namespace PrototypePattern.ShallowClone
{
    // Demo 淺複製 的 App
    public class ShallowApp
    {
        public void Run()
        {
            // 宣告地址 實體
            Address addr = new();
            addr.Set("木葉村");

            // 宣告鳴人
            Naruto naruto = new();
            // 指派鳴人的住所地址
            naruto.SetAddr(addr);

            // 鳴人 使用影分身之術 (Clone)
            Naruto cloneNaruto = (Naruto)naruto.Clone();

            // 查看鳴人的住所
            Console.WriteLine("鳴人的住所地址 : " + naruto.GetAddr().Get());
            // 查看影分身的住所
            Console.WriteLine("影分身的住所地址 : " + cloneNaruto.GetAddr().Get());

            // 從 木葉村 搬到 台北
            addr.Set("台北");
            Console.WriteLine("搬家成功！");

            // 查看鳴人的住所
            Console.WriteLine("鳴人的住所地址 : " + naruto.GetAddr().Get());
            // 查看影分身的住所
            Console.WriteLine("影分身的住所地址 : " + cloneNaruto.GetAddr().Get());
        }
    }
}
