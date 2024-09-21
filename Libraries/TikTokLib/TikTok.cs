namespace TikTokLib
{
    public class TikTok
    {
        public static TikTokUrl TopPage = new TikTokUrl("https://www.tiktok.com");
        public TikTokUser? User { get; set; }
        public TikTok() { }
        public TikTok(TikTokUser user) 
        {
            User = user;
        }

        public void GetUserVideoList()
        {
            if(User == null) { throw new Exception("ユーザーを指定してください。"); }

            try
            {
                var videoIds = new TikTokVideo(User, string.Empty)
                    .GetUserVideoIdListWithSeleinum();
                foreach (var videoId in videoIds)
                {
                    User.Videos.Add(new TikTokVideo(User, videoId));
                }
            }
            catch 
            {
                throw;
            }
        }
    }
}
