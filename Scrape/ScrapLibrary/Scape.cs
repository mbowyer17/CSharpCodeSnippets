using System;
using System.IO;
using System.Net;

namespace ScrapeLibrary
{
    public class Scrape
    {

        public string ScrapeWebpage(string url)
        {

            return GetWebpage(url);

        }

        public string ScrapeWebpage(string url, string filepath)
        {
            string reply = GetWebpage(url);


            // Uses System.IO
            File.WriteAllText(filepath, reply);
            return reply;
        }

        // helper method
        private string GetWebpage(string url)
        {
            WebClient client = new WebClient();

            string content = client.DownloadString(url);
            content += "Thats all Folks";
            return content;
        }
    }
}
