using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


class helper
{
    public static void on_exit(object sender, EventArgs e)
    {
        // get this to work
        web.upload_text($"Client [{config.sessionID}] disconnected.");
        //Console.Beep(500, 100);
    }
}

