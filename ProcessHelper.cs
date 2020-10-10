using System;
using System.ComponentModel;
using System.Diagnostics;

namespace KillProcess
{
    public static class ProcessHelper
    {
        public static void KillProcess(string processName = "VBCSCompiler")
        {
            foreach (var process in Process.GetProcessesByName(processName))
            {
                try
                {
                    process.Kill();

                    //等待进程被杀掉，超时时间当前设置为3秒
                    process.WaitForExit(3000);
                }
                catch (Win32Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
