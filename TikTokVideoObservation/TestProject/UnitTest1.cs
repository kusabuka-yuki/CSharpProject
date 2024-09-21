using NuGet.Frameworks;
using System.Diagnostics;
using TikTokLib;
using TikTokVideoObservation;

namespace TestProject
{
    public class UnitTest1
    {
        private const string PythonInterpreterPath = @"C:\Users\Yuki\AppData\Local\Programs\Python\Python39\python.exe";
        private const string PythonScriptPath = @"G:\マイドライブ\ドライブ\IT系\プログラミング\TikTok動画保存\TikTokVideoObservation\tiktok_video_downloader.py";
        private List<string> list;
        private string joinedList;

        [Fact]
        public void Test1()
        {
            //var Process = new PythonProcess.PythonProcess(PythonInterpreterPath, PythonScriptPath);

            //Assert.Equal(@"https://www.tiktok.com/@ikrooooo00/video/7414452979685805319,https://www.tiktok.com/@ikrooooo00/video/7413339479148137735,https://www.tiktok.com/@ikrooooo00/video/7411113868988108050", joinedList);


            var arguments = new List<string>
            {
                PythonScriptPath,
                joinedList
            };

            var process = new Process()
            {
                StartInfo = new ProcessStartInfo(PythonInterpreterPath)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    Arguments = string.Join(" ", arguments),
                },
            };
            Console.WriteLine(process.StartInfo.Arguments);
            process.Start();
            //var sr = process.StandardOutput;
            //var result = sr.ReadLine();

            process.WaitForExit();
            process.Close();

            //Console.WriteLine("Result is ... " + result);
            //Assert.Equal("aaaa", result);
            //Process.StartProcess(joinedList);
        }
        [Fact]
        public void TestVideoDownloadScript()
        {
            list = new List<string>
            {
                @"https://www.tiktok.com/@ikrooooo00/video/7414452979685805319",
                @"https://www.tiktok.com/@ikrooooo00/video/7413339479148137735",
                @"https://www.tiktok.com/@ikrooooo00/video/7411113868988108050",
            };
            joinedList = String.Join(",", list);
            var process = new PythonProcess.PythonProcess(PythonInterpreterPath, PythonScriptPath);
            process.StartProcess(joinedList);
        }
        //[Fact(DisplayName ="保存済み動画リストのファイルを作成")]
        //public void TestSavedVideoListFileCreate()
        //{
        //    var targetDirectry = @"G:\マイドライブ\ドライブ\IT系\プログラミング\TikTok動画保存\TikTokVideoObservation";
        //    var targetFile = "test.json";

        //    var targetFileFullPath = Path.Combine(targetDirectry, targetFile);

        //    FileInfo file = new FileInfo(targetFileFullPath);
        //    file.Delete();

        //    var app = new TikTokVideoObservation.Main();
        //    var testUsr = new TikTokUser("test");
        //    app.Current = new TikTok(testUsr);
        //    app.UserVideos.Add(new TikTokVideo(testUsr, "A23456789"));
        //    app.UserVideos.Add(new TikTokVideo(testUsr, "B23456789"));
        //    app.UserVideos.Add(new TikTokVideo(testUsr, "C23456789"));
        //    app.SavedVideos.Add(new TikTokVideo(testUsr, "B23456789"));
        //    app.SaveSavedVideoListFile();

        //    var section = app.GetConfFileSection(targetFileFullPath, "savedList", "json");
        //    var videoIdListSection = section.GetSection("videoIdList").GetChildren().ToList();
        //    var savedVideoList = videoIdListSection.Select(section =>
        //    {
        //        var id = section.GetSection("videoId").Value ?? null;
        //        return new TikTokVideo(testUsr, id);
        //    }).ToList();
        //    var savedUsr = section.Value;

        //    Assert.Equal(app.UserVideos, savedVideoList);
        //    Assert.Equal(testUsr.Id, savedUsr);
        //}
        //[Fact(DisplayName = "保存済み動画リストのファイルを上書き")]
        //public void TestSavedVideoListFileWrite()
        //{
        //    var targetDirectry = @"G:\マイドライブ\ドライブ\IT系\プログラミング\TikTok動画保存\TikTokVideoObservation";
        //    var targetFile = "test.json";

        //    var targetFileFullPath = Path.Combine(targetDirectry, targetFile);

        //    var app = new TikTokVideoObservation.Main();
        //    var testUsr = new TikTokUser("test");
        //    app.UserVideos.Add(new TikTokVideo(testUsr, "A23456789"));
        //    app.UserVideos.Add(new TikTokVideo(testUsr, "B23456789"));
        //    app.UserVideos.Add(new TikTokVideo(testUsr, "D23456789"));
        //    app.SavedVideos.Add(new TikTokVideo(testUsr, "B23456789"));
        //    app.SaveSavedVideoListFile();

        //    var section = app.GetConfFileSection(targetFileFullPath, "savedList", "json");
        //    var videoIdListSection = section.GetSection("videoIdList").GetChildren().ToList();
        //    var savedVideoList = videoIdListSection.Select(section =>
        //    {
        //        var id = section.GetSection("videoId").Value ?? null;
        //        return new TikTokVideo(testUsr, id);
        //    }).ToList();
        //    var savedUsr = section.Value;

        //    Assert.Equal(app.UserVideos, savedVideoList);
        //    Assert.Equal(testUsr.Id, savedUsr);
        //}
    }
}