using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;

namespace ParserHTML
{
    public class HtmlDownloadHelper
    {
        public static string DownloadHtml(string uri)
        {
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;
            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            StreamReader sr = new StreamReader(response.GetResponseStream());
            string html = sr.ReadToEnd();

            return "";
        }
    }
}
