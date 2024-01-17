namespace ChainOfResponsibilityPattern
{
    // 管理層 抽象
    public abstract class Leader
    {
        private Leader next;
        private string name;
        public Leader(string name)
        {
            this.name = name;
        }

        /// <summary>
        /// 設定責任鏈的下一個負責人
        /// </summary>
        /// <param name="next"></param>
        public void SetNext(Leader next)
        {
            this.next = next;
        }

        /// <summary>
        /// 取得責任鏈的下一個負責人
        /// </summary>
        /// <returns></returns>
        public Leader GetNext()
        {
            return next;
        }

        /// <summary>
        /// 核准請假
        /// </summary>
        /// <param name="LeaveDays"></param>
        public void LeaveSuccessed(int LeaveDays)
        {
            Console.WriteLine(this.name + " 核准 " + LeaveDays + " 天的休假.");
        }

        /// <summary>
        /// 駁回請假
        /// </summary>
        public void LeaveFailed()
        {
            Console.WriteLine("請假天數過多，請假單無人審批");
        }

        // 處理請求的方法
        public abstract void HandleRequest(int LeaveDays);
    }
}
