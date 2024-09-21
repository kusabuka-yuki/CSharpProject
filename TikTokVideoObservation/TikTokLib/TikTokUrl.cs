using System.Diagnostics.CodeAnalysis;

namespace TikTokLib
{
    public class TikTokUrl : Uri
    {
        public TikTokUrl(string uriString) : base(uriString)
        {
        }
    }
}