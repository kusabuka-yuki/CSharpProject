using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TikTokLib
{
    public class TikTokUser
    {
        public IList<TikTokVideo> Video { get; set; }
        public string UserId { get; set; }
        public TikTokUser() { }
    }
}
