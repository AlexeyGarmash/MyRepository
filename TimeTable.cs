using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Metropolitan
{
    class TimeTable
    {
        private List<string> stations;
        private List<Time> table;
        
        public TimeTable()
        {
            stations = new List<string>();
            table = new List<Time>();
        }
    
        public void CreateFromFile()
        {
            StreamReader reader;
            reader = new StreamReader("TimeTable.txt");
            string line;
            string[] time;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                time = line.Split(':');
                table.Add(new Time(Int32.Parse(time[0]), Int32.Parse(time[1]), Int32.Parse(time[2])));
            }
            reader.Close();
            reader = new StreamReader("Stations.txt");
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                stations.Add(line);
            }
            reader.Close();
        }

        public List<Time> TABLE
        {
            get { return table; }
            set { table = value; }
        }

        public List<string> STATIONS
        {
            get { return stations; }
            set { stations = value; }
        }
    }
}
