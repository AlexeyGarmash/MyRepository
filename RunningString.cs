using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Metropolitan
{
    class RunningString
    {
        private List<string> news;
        public RunningString()
        {
            news = new List<string>();
        }
        public void CreateNews()
        {
            StreamReader reader = new StreamReader("News.txt");
            string line;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                news.Add(line);
            }
            reader.Close();
        }
        public void AddNew(string news)
        {
            NEWS.Add(news);
        }
        public List<string> NEWS
        {
            get { return news; }
            set { news = value; }
        }
    }
}
