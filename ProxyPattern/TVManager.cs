namespace ProxyPattern
{
    /// <summary>
    /// TV 管理者 透過 Proxy 來操作第三方 Library
    /// </summary>
    public class TVManager
    {
        private readonly IThirdPartyTVLib _service;

        public TVManager(IThirdPartyTVLib service)
        {
            _service = service;
        }

        /// <summary>
        /// 渲染 影片資訊 Page
        /// </summary>
        /// <param name="id"></param>
        public void RenderVideoPage(int id)
        {
            Video? video = _service.DownloadVideo(id);

            if (video == null)
            {
                Console.WriteLine("找不到對應 Video 資訊");
            }
            else
            {
                Console.WriteLine($"渲染影片資訊頁面 => ID：{video.Id}、檔名：{video.FileName}、時長：{video.Duration:hh\\mm\\ss}、副檔名：{video.FileNameExtension}");
            }
        }

        /// <summary>
        /// 渲染 影片列表 Page
        /// </summary>
        public void RenderListPanel()
        {
            List<Video> videos = _service.ListVideos();

            if (videos == null)
            {
                Console.WriteLine("無影片列表資訊");
            }
            else
            {
                Console.WriteLine("影片列表：");
                foreach (Video video in videos)
                {
                    Console.WriteLine($"ID：{video.Id}、檔名：{video.FileName}、時長：{video.Duration:hh\\:mm\\:ss}、副檔名：{video.FileNameExtension}");
                }
            }
        }

        /// <summary>
        /// 播放影片
        /// </summary>
        /// <param name="id"></param>
        public void PlayVideo(int id)
        {
            Video? video = _service.DownloadVideo(id);

            if (video == null)
            {
                Console.WriteLine($"找不到可播放的 Video，ID：{id}");
            }
            else
            {
                Console.WriteLine($"正在播放 {video.FileName}.{video.FileNameExtension}，ID：{video.Id}、片長：{video.Duration:hh\\:mm\\:ss}");
            }
        }
    }
}
