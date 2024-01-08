namespace ProxyPattern
{
    /// <summary>
    /// 第三方 Library & Proxy 的共同 Interface
    /// </summary>
    public interface IThirdPartyTVLib
    {
        public List<Video> ListVideos();
        public Video? DownloadVideo(int id);
    }
}
