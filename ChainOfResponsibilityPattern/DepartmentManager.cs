namespace ChainOfResponsibilityPattern
{
    public class DepartmentManager : Leader
    {
        public DepartmentManager() : base("部門經理")
        {}

        /// <summary>
        /// 處理休假審核
        /// </summary>
        /// <param name="LeaveDays"></param>
        public override void HandleRequest(int LeaveDays)
        {
            if (LeaveDays <= 10)
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
