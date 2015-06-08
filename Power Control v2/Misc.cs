using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Control_v2
{
    class Misc
    {
        public static StringBuilder builder = new StringBuilder();

        public static string Execute(string filename, string arguments)
        {
            builder.Clear();

            Process proc = new Process();
            proc.StartInfo.FileName = filename;
            proc.StartInfo.Arguments = arguments;
            proc.StartInfo.CreateNoWindow = true;
            proc.StartInfo.UseShellExecute = false;
            proc.StartInfo.RedirectStandardOutput = true;
            proc.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            proc.Start();
            proc.WaitForExit();

            while (!proc.StandardOutput.EndOfStream)
            {
                builder.AppendLine(proc.StandardOutput.ReadLine());
            }

            return builder.ToString();
        }

        public static string[] SplitIntoLines(string text)
        {
            string[] lines;

            if (text.Contains("\r\n"))
                lines = text.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            else
                lines = text.Split(new char[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);

            return lines;
        }
    }
}
