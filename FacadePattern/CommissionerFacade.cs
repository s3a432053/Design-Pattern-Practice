namespace FacadePattern
{
    // 專員外觀 - 負責幫客戶到各部門執行貸款流程
    public class CommissionerFacade
    {
        private readonly Department_A obj1 = new();
        private readonly Department_B obj2 = new();
        private readonly Department_C obj3 = new();
        private readonly Department_D obj4 = new();
        public void Method()
        {
            obj1.Method1();
            obj2.Method2();
            obj3.Method3();
            obj4.Method4();
        }
    }
}
