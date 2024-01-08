namespace ProxyPattern
{
    /// <summary>
    /// 用來提供 Video 資源的第三方 Library
    /// </summary>
    public class ThirdPartyTVClass : IThirdPartyTVLib
    {
        private readonly List<Video> _videos = new()
        {
            new Video()
            {
                Id = 1,
                FileName = "ABC 教學影片",
                Duration = new TimeSpan(0, 0, 30, 0),
                FileNameExtension = "mp4"
            },
            new Video()
            {
                Id = 2,
                FileName = "docker 教學影片",
                Duration = new TimeSpan(0, 2, 0, 0),
                FileNameExtension = "webm"
            },
            new Video()
            {
                Id = 3,
                FileName = "K8s 教學影片",
                Duration = new TimeSpan(0, 4, 0, 0),
                FileNameExtension = "mp4"
            }
        };

        public Video? DownloadVideo(int id)
        {
            Video? video = _videos.FirstOrDefault(x => x.Id.Equals(id));

            if (video != null)
            {
                return video;
            }

            return null;
        }

        public List<Video> ListVideos()
        {
            return _videos;
        }

        /// <summary>
        /// 讓第三方 Library 開發人員上傳新影片
        /// </summary>
        /// <param name="video"></param>
        /// <returns></returns>
        public void AddVideo(Video video)
        {
            _videos.Add(video);
            Console.WriteLine($"新影片 {video.FileName}.{video.FileNameExtension} 上傳成功");
        }
    }
}
