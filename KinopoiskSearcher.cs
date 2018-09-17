using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParserHTML
{
    public class KinopoiskParserException : Exception
    {
        public KinopoiskParserException(string message) : base(message)
        {

        }
    }

    public class KinopoiskSearcher
    {
        private string _html;
        private Image _cover;
        private readonly string BaseUrl;

        public KinopoiskSearcher()
        {
            BaseUrl = @"https://www.kinopoisk.ru/index.php?first=yes&kp_query={0}";
        }

        public bool DownloadHTML(string moveName)
        {
            _cover = null;

            try
            {
                _html = HtmlDownloadHelper.DownloadHtml(string.Format(BaseUrl, moveName), Encoding.GetEncoding(1251));                
                return true;
            }
            catch
            {
                return false;
            }
           
        }

        public bool FindCover()
        {
            if (string.IsNullOrEmpty(_html))
                throw new KinopoiskParserException("Код html не был загружен. Сначала выполните DownloadHtml.");

           

            return false;
        }
    }
}
