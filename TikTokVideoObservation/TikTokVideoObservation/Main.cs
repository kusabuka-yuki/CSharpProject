using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Reflection;
using TikTokLib;

namespace TikTokVideoObservation
{
    public class Main
    {
        private string PythonInterpreterPath = string.Empty;
        private string PythonScriptPath = string.Empty;
        private string TargetUserId = string.Empty;
        private string SavedVideoListFullPath = string.Empty;
        private TikTok Current;

        public IList<TikTokVideo> SavedVideos 
        { 
            get
            {
                return GetSavedVideoList();
            }
        }
        public IList<TikTokVideo> UserVideos 
        {
            get
            {
                return Current.User.Videos;
            }
        }
        public IList<TikTokVideo> SaveTargetVideos 
        {
            get
            {
                return UserVideos.Except(SavedVideos).ToList();
            }
        }

        public Main()
        {
        }
        /// <summary>
        /// プログラムを実行
        /// </summary>
        public void Start()
        {
            try
            {
                GetAppInfos(GetConfFileSection(Properties.Resources.AppInfosPath, "ItemGrourp", "xml"));
                if (!File.Exists(SavedVideoListFullPath)) { using (File.Create(SavedVideoListFullPath)) { }; }

                Current = new TikTok(new TikTokUser(TargetUserId));

                SetUserVideoList();
                // 対象リストの動画を保存する。
                var downloader = new VideoDownloder(SaveTargetVideos.ToList(), PythonInterpreterPath, PythonScriptPath);
                downloader.DownLoad();
                foreach (var video in SaveTargetVideos)
                {
                    if (Current.User.Videos.Contains(video)) { continue; }

                    Current.User.Videos.Add(video);
                };
                //対象リストの動画idを保存済み動画idリストのファイルに追加する。
                SaveSavedVideoListFile();
                Console.WriteLine("処理が正常に終了しました");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                
            }
        }
        /// <summary>
        /// 設定ファイルのセクションを取得
        /// </summary>
        private IConfigurationSection GetConfFileSection(string filePathOrName, string SectionName, string ext)
        {
            var builder = new ConfigurationBuilder();

            if(ext == "xml")
            {
                builder.AddXmlFile(filePathOrName);
            }
            else if(ext == "json")
            {
                builder.AddJsonFile(filePathOrName);
            }
            Microsoft.Extensions.Configuration.IConfiguration config = builder.Build();
            return config.GetSection(SectionName);
        }
        /// <summary>
        /// アプリケーション情報ファイルの設定値を取得
        /// </summary>
        private void GetAppInfos(IConfigurationSection section)
        {
            // 対象ユーザーのidを取得
            TargetUserId = section.GetSection("TargetUserId").Value;

            if (string.IsNullOrEmpty(TargetUserId)) { throw new Exception("処理中にエラーが発生しました。: TargetUserId not val"); }

            // 対象ユーザーの保存済み動画idリストディレクトリパス
            var savedVideoListPath = section.GetSection("SavedVideoListPath").Value;

            if (string.IsNullOrEmpty(savedVideoListPath)) { return; }

            SavedVideoListFullPath = Path.Combine(savedVideoListPath, TargetUserId) + ".json";

            PythonInterpreterPath = section.GetSection("PythonInterpreterPath").Value;
            if (string.IsNullOrEmpty(TargetUserId)) { throw new Exception("処理中にエラーが発生しました。: PythonInterpreterPath not val"); }
            PythonScriptPath = section.GetSection("pythonScriptPath").Value;
            if (string.IsNullOrEmpty(TargetUserId)) { throw new Exception("処理中にエラーが発生しました。: PythonScriptPath not val"); }
        }
        /// <summary>
        /// 保存済み動画idリストを設定
        /// </summary>
        private List<TikTokVideo> GetSavedVideoList()
        {
            var section = GetConfFileSection(SavedVideoListFullPath, "savedList", "json");
            if (section == null) { SaveSavedVideoListFile(); }

            var videoIdListSection = section.GetSection("videoIdList").GetChildren().ToList();

            if (videoIdListSection == null) { return new List<TikTokVideo>(); }

            return videoIdListSection.Select(section =>
            {
                var id = section.Value ?? null;
                return new TikTokVideo(Current.User, id);
            }).ToList();
        }
        private void SetUserVideoList()
        {
            Current.GetUserVideoList();
        }
        private void SaveSavedVideoListFile()
        {
            using (var sw = new StreamWriter(SavedVideoListFullPath, false, System.Text.Encoding.UTF8))
            {
                using(var jw = new JsonTextWriter(sw))
                {
                    var jsonObj = new JObject
                    {
                        ["savedList"] = new JObject
                        {
                            ["userId"] = Current.User.Id,
                            ["videoIdList"] = JArray.FromObject(Current.User.Videos.Select(x => x.Id))
                        }
                    };

                    jw.Formatting = Formatting.Indented;
                    jsonObj.WriteTo(jw);
                }
            }
        }
    }
}
