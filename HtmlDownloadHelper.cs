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

            
            //request.UserAgent = "Mozilla/5.0 (Windows NT 6.1; WOW64; rv:2.0) Gecko/20100101 Firefox/4.0";
            //request.Accept = "text/html, application/xhtml+xml, application/xml;q=0.9, */*;q=0.8";
            //request.Headers.Set("Accept-Language", "ru-ru,ru;q=0.8,en-us;q=0.5,en;q=0.3");
            //request.Headers.Set("Accept-Charset", "windows-1251,utf-8;q=0.7,*;q=0.7");
            //request.KeepAlive = true;


            request.UserAgent = "Mozilla/5.0 (Windows; U; Windows NT 5.1; ru; rv:1.9.2) Gecko/20100115 Firefox/3.6 GTB7.1";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            request.Headers.Set("Accept-Language", "ru,en-us;q=0.7,en;q=0.3");
            request.Headers.Set("Accept-Charset", "windows-1251,utf-8;q=0.7,*;q=0.7");
            request.KeepAlive = true;


            HttpWebResponse response = request.GetResponse() as HttpWebResponse;

            StreamReader sr = new StreamReader(response.GetResponseStream());
            string html = sr.ReadToEnd();

            return html;
        }
    }
}
