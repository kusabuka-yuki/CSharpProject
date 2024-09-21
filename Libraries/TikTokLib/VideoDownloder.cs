using PythonProcess;

namespace TikTokLib
{
    public class VideoDownloder
    {
        private const int MaxDownloadCount = 5;
        private const string videoUrlFormat = "{0}@{1}/video/{2}";
        private PythonProcess.PythonProcess Process;
        public List<TikTokVideo> Videos { get; set; }
        public List<string> VideoUrls
        {
            get
            {
                if (Videos == null || Videos.Count <= 0) { return new List<string>(); }
                return Videos.Select(video =>
                {
                    return string.Format(videoUrlFormat, TikTok.TopPage, video.User.Id, video.Id);
                }).ToList();
            }
        }
        public VideoDownloder(string interpreterPath, string scriptPath)
            : this(new List<TikTokVideo>(), interpreterPath, scriptPath)
        {
        }
        public VideoDownloder(List<TikTokVideo> videos, string interpreterPath, string scriptPath)
        {
            Videos = videos;
            Process = new PythonProcess.PythonProcess(interpreterPath, scriptPath);
        }

        public void DownLoad()
        {
            Process.StartProcess(String.Join(",", VideoUrls.Take(MaxDownloadCount)));
        }
    }
}
