using System;

namespace KillProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("请输入进程名称：");
            var processName = Console.ReadLine();
            ProcessHelper.KillProcess(processName);
        }
    }
}
