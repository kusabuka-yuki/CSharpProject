using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputClipBoardImageDuringCharacter
{
    public class PythonProcess
    {
        public string PythonInterpreterPath { get; set; }
        public string PythonScriptPath { get; set; }
        public Process ExecuteProcess { get; set; }
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

            var process = new Process()
            {
                StartInfo = new ProcessStartInfo(PythonInterpreterPath)
                {
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow= true,
                    Arguments = string.Join(" ", arguments),
                },
            };
            Console.WriteLine(process.StartInfo.Arguments);


            ExecuteProcess = process;
            ExecuteProcess.Start();
        }
        public void EndProcess()
        {
            ExecuteProcess.Close();
        }
        public string GetStandardOutput(string newLine = "")
        {
            var text = string.Empty;
            var reText = string.Empty;
            while((text = ExecuteProcess.StandardOutput.ReadLine()) != null)
            {
                Console.WriteLine(text);
                reText = reText + text + newLine;
            }
            return reText;
        }
    }
}
