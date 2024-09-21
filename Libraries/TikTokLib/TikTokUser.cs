namespace TikTokLib
{
    public class TikTokUser
    {
        public IList<TikTokVideo> Videos { get; set; }
        public string Id { get; set; }
        public TikTokUser() 
        {
            Videos = new List<TikTokVideo>();
            Id = string.Empty;
        }
        public TikTokUser(string id)
        {
            Videos = new List<TikTokVideo>();
            Id = id;
        }
        public void AddVideo(string videoId) 
        {
            if(string.IsNullOrEmpty(videoId)) { throw new ArgumentNullException(nameof(videoId)); }
            Videos.Add(new TikTokVideo(this, videoId));
        }
    }
}
