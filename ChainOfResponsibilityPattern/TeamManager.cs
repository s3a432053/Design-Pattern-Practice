namespace ChainOfResponsibilityPattern
{
    public class TeamManager : Leader
    {
        public TeamManager() : base("團隊經理")
        {}

        /// <summary>
        /// 處理休假審核
        /// </summary>
        /// <param name="LeaveDays"></param>
        public override void HandleRequest(int LeaveDays)
        {
            if (LeaveDays <= 7)
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
