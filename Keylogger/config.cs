using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class config
{
    public static string webhook_url = "";
    public static bool debug_mode = false;
    public static int delay = 5000; // ms

    public static List <string> keys = new List<string>();

    public static string sessionID = (new Random().Next().ToString());


}

