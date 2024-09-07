using AngleSharp;

namespace AngleSharpLoader
{
    public class AngleSharpLoader
    {
        public string Address { get; set; }
        private IConfiguration config;
        public IBrowsingContext Context
        {
            get
            {
                return BrowsingContext.New(config);
            }
        }
        public AngleSharpLoader(string address)
        {
            config = Configuration.Default.WithDefaultLoader();
            Address = address;
        }
    }
}