using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metropolitan
{
    class Tablo
    {
        public static List<string> session { get; set; }
        TimeTable board;
        public RunningString run { get; set; }
        private int s_start, m_start, h_start, rez_m, rez_s, ss, mm, hh;
        public int index { get; set; }
        public Tablo()
        {
            board = new TimeTable();
            run = new RunningString();
            session = new List<string>();
            board.CreateFromFile();
            run.CreateNews();
        }
        public void FindTimeThisStation()
        {
            hh = DateTime.Now.Hour - board.TABLE.ElementAt(0).HOUR;
            mm = DateTime.Now.Minute - board.TABLE.ElementAt(0).MIN;
            ss = DateTime.Now.Second - board.TABLE.ElementAt(0).SEC;
            for (int i = 0; i < board.TABLE.Count; i++)
            {
                if (DateTime.Now.Hour - board.TABLE.ElementAt(i).HOUR >= 0 && DateTime.Now.Minute - board.TABLE.ElementAt(i).MIN >= 0)
                    if (DateTime.Now.Hour - board.TABLE.ElementAt(i).HOUR < hh && DateTime.Now.Minute - board.TABLE.ElementAt(i).MIN < mm)
                    {
                        
                        hh = board.TABLE.ElementAt(i + 1).HOUR;
                        mm = board.TABLE.ElementAt(i + 1).MIN;
                        ss = board.TABLE.ElementAt(i + 1).SEC;
                        h_start = board.TABLE.ElementAt(i).HOUR;
                        m_start = board.TABLE.ElementAt(i).MIN;
                        s_start = board.TABLE.ElementAt(i).SEC;
                        index = i;
                    }
            }
            rez_m = DateTime.Now.Minute - m_start;
            rez_s = DateTime.Now.Second - s_start;
        }
        public string FormatNowDate()
        {
            DateTime Today = DateTime.Now;
            string TodayData = Today.ToString("H : mm : ss");
            return TodayData;
        }
        public string FormatDepartureDate()
        {
            string time = "";
            if (RESULT_S / 10 > 0)
                time = "0" + RESULT_M.ToString() + " : " + RESULT_S.ToString();
            else
                time = "0" + RESULT_M.ToString() + " : " + "0" + RESULT_S.ToString();
            RESULT_S++;
            return time;
        }
        public string Message(bool f)
        {
            if (f == true)
                return "П О Ї З Д   П Р И Б У В";
            else
                return "П О Ї З Д   З А П І З Н Ю Є Т Ь С Я";
        }
        public void SessionReaction(DateTime date, string mess)
        {
            session.Add(date.ToString() + mess + Environment.NewLine);
        }
        public int RESULT_S
        {
            get { return rez_s; }
            set { rez_s = value; }
        }

        public int RESULT_M
        {
            get { return rez_m;  }
            set { rez_m = value; }
        }
        public int Diff
        {
            get
            {
                if (board.TABLE[index + 1].MIN < board.TABLE[index].MIN)
                {
                    return 60 + (board.TABLE[index + 1].MIN - board.TABLE[index].MIN);
                }
                else
                    return board.TABLE[index + 1].MIN - board.TABLE[index].MIN;
            }
        }
    }
}
