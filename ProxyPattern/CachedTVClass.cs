namespace ProxyPattern
{
    /// <summary>
    /// Proxy 負責代替 TV Manager 操作 ThirdPartyTVClass
    /// 並將存取過的資源存在自己的快取中 下次 TV Manager 要獲取資源就不需要再到 ThirdPartyTVClass 拿
    /// </summary>
    public class CachedTVClass : IThirdPartyTVLib
    {
        private readonly IThirdPartyTVLib _service;
        private List<Video>? _listCache;
        private List<Video>? _videosCache;
        private bool _needReset = false;

        public CachedTVClass(IThirdPartyTVLib service)
        {
            _service = service;
        }

        public List<Video> ListVideos()
        {
            if (_listCache == null || _needReset)
            {
                _listCache = new List<Video>(_service.ListVideos());
            }
            return _listCache;
        }

        /// <summary>
        /// 快取中 有 Video 就回傳快取中的 Video
        /// 快取中 沒有 Video 就回傳下載下來的 Video
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Video? DownloadVideo(int id)
        {
            Video? downloadVideo;

            // 快取重置模式 == true => 重置快取
            if (_needReset)
            {
                _videosCache = null;
            }

            if (_videosCache == null)
            {
                // 初始化
                _videosCache = new List<Video>();
            }
            else
            {
                // 查詢快取
                downloadVideo = _videosCache.FirstOrDefault(x => x.Id.Equals(id));

                // 快取中有指定 Video
                if (downloadVideo != null)
                {
                    return downloadVideo;
                }
            }

            // 快取中無指定 Video => 下載 Video
            downloadVideo = _service.DownloadVideo(id);

            if (downloadVideo != null)
            {
                // 將 Video 加入 Cache
                _videosCache.Add(downloadVideo);
            }

            return downloadVideo;
        }

        /// <summary>
        /// 是否開啟 重置快取模式
        /// </summary>
        /// <param name="needReset"></param>
        public void NeedResetCache(bool needReset)
        {
            _needReset = needReset;

            if (needReset)
            {
                Console.WriteLine($"開啟 Proxy 快取重置模式");
            }
            else
            {
                Console.WriteLine($"關閉 Proxy 快取重置模式");
            }
        }
    }
}
