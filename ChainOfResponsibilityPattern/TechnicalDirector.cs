namespace ChainOfResponsibilityPattern
{
    public class TechnicalDirector : Leader
    {
        public TechnicalDirector() : base("院長")
        {}

        /// <summary>
        /// 處理休假審核
        /// </summary>
        /// <param name="LeaveDays"></param>
        public override void HandleRequest(int LeaveDays)
        {
            if (LeaveDays <= 15)
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
