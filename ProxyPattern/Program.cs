using ProxyPattern;

// 第三方 Library
ThirdPartyTVClass thirdPartyTVClass = new();
// Proxy 使用 第三方 Library 來為 TVManager 提供服務
CachedTVClass cachedTVClass = new(thirdPartyTVClass);
// TVManager 為 Client 提供 Video 服務
TVManager tvManager = new(cachedTVClass);

// 查詢 影片資訊 Id
int videoInfoId = 1;
// 播放 影片 Id
int videoPlayId = 2;

// 渲染 Video 列表 Page
tvManager.RenderListPanel();
// 渲染 Video 資訊 Page
tvManager.RenderVideoPage(videoInfoId);
// 播放 Video
tvManager.PlayVideo(videoPlayId);

// Proxy 開啟 重置快取模式 (可以取消註解 看是不是會重新 Download Video or 重新取得 List 而不是使用快取內的資源)
// cachedTVClass.NeedResetCache(true);

// 第三方套件管理員 加入新的 Video
thirdPartyTVClass.AddVideo(new Video
{
    Id = 4,
    FileName = "迷因大合集",
    Duration = new TimeSpan(0, 30, 0),
    FileNameExtension = "mp4"
});

videoInfoId = 1;
videoPlayId = 5;

// 重新 渲染 Video 列表 Page
tvManager.RenderListPanel();
// 重新 渲染 Video 資訊 Page
tvManager.RenderVideoPage(videoInfoId);
// 播放 其他 Video
tvManager.PlayVideo(videoPlayId);

Console.ReadLine();