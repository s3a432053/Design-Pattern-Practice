namespace ProxyPattern
{
    /// <summary>
    /// 影片實體
    /// </summary>
    public class Video
    {
        public int Id { get; set; }
        /// <summary>
        /// 檔名
        /// </summary>
        public string? FileName { get; set; }
        /// <summary>
        /// 影片時長
        /// </summary>
        public TimeSpan Duration { get; set; }
        /// <summary>
        /// 副檔名
        /// </summary>
        public string? FileNameExtension { get; set; }
    }
}
