using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using AngleSharp;
using AngleSharp.Dom;
using AngleSharpLoader;
using OpenQA.Selenium;
using SeleniumControl;

namespace TikTokLib
{
    public class TikTokVideo
    {
        private const string RegVideoIdPattern = @"\/video\/(\w+)";

        public TikTokUser User { get; set; }
        public TikTokUrl UserVideoPage 
        { 
            get 
            { 
                return new TikTokUrl(TikTok.TopPage.ToString() +  "@" + User.Id);                ;
            }
        }
        public string Id { get; set; }

        public TikTokVideo() { }
        public TikTokVideo(TikTokUser user, string id)
        {
            Id = id;
            User = user;
        }
        public List<string> GetUserVideoIdListWithSeleinum()
        {
            if(User == null) { throw new Exception("ユーザーを指定してください。"); }
            // 画面が表示された時点でDOMに生成されたHTMLから取得。
            // すべての動画情報を得るにはスクロール機能と組み合わせる必要がある。
            try
            {
                using (var controller = new ChromeDriverController())
                {
                    controller.GotoUrl(UserVideoPage.ToString());
                    var nodes = controller.Driver.FindElements(By.XPath("//div[@data-e2e='user-post-item']"));
                    var links = nodes.Select(node => node.FindElement(By.TagName("a")).GetAttribute("href")).ToList();
                    return links.Select(link =>
                    {
                        if (string.IsNullOrEmpty(link)) { return string.Empty; }

                        var match = Regex.Match(link, RegVideoIdPattern);
                        if (!match.Success)
                        {
                            return string.Empty;
                        }
                        return match.Groups[1].Value;
                    }).ToList();
                }
            }
            catch
            {
                throw;
            }
        }
    }
}
