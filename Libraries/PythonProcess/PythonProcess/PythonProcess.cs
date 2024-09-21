using System.Diagnostics;

namespace PythonProcess
{
    public class PythonProcess
    {
        private Process process;

        public string PythonInterpreterPath { get; set; }
        public string PythonScriptPath { get; set; }
        public PythonProcess()
        {
        }
        public PythonProcess(string interpreterPath, string scriptPath)
        {
            this.PythonInterpreterPath = interpreterPath;
            this.PythonScriptPath = scriptPath;
        }
        public void StartProcess(List<string> arguments = null)
        {
            arguments.Insert(0, PythonScriptPath);

            using (var process = new Process())
            {
                process.StartInfo = new ProcessStartInfo(PythonInterpreterPath)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    RedirectStandardError = true,
                    Arguments = string.Join(" ", arguments),
                };
                Console.WriteLine(process.StartInfo.Arguments);

                process.Start();
                process.WaitForExit();


                var sr = process.StandardOutput;
                var result = sr.ReadLine();


                Console.WriteLine("Result is ... " + result);
            };
        }
        public void StartProcess(string param)
        {
            var arguments = new List<string>() { param };
            StartProcess(arguments); 
        }
        public void EndProcess()
        {
            process.Close();
        }
        public string GetStandardOutput(string newLine = "")
        {
            var text = string.Empty;
            var reText = string.Empty;
            while ((text = process.StandardOutput.ReadLine()) != null)
            {
                Console.WriteLine(text);
                reText = reText + text + newLine;
            }
            return reText;
        }
    }
}