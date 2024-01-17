namespace ChainOfResponsibilityPattern
{
    public class CTO : Leader
    {
        public CTO() : base("技術長")
        {}

        /// <summary>
        /// 處理休假審核
        /// </summary>
        /// <param name="LeaveDays"></param>
        public override void HandleRequest(int LeaveDays)
        {
            if (LeaveDays <= 20)
            {
                this.LeaveSuccessed(LeaveDays);
            }
            else
            {
                if (GetNext() != null)
                {
                    GetNext().HandleRequest(LeaveDays);
                }
                else
                {
                    this.LeaveFailed();
                }
            }
        }
    }
}
