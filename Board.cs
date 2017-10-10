using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
namespace Metropolitan
{
    public partial class Board : Form
    {

        private  bool f;
        private Tablo tablo;
        private int move;
        public Board()
        {
            InitializeComponent();
            tablo = new Tablo();
            tablo.FindTimeThisStation();
            move = 0;
            f = false;
            this.KeyUp += new KeyEventHandler(Sensor);
        }
        private void Sensor(object sender, KeyEventArgs e)
        {
            if(f == false)
            if(e.KeyCode == Keys.Space)
            {
                tablo.index++;
                f = true;
                TimerArrive.Stop();
                TimerString.Stop();
                ArriveTime.Text = "00 : 00";
                label1.Left = 210;
                label1.TextAlign = ContentAlignment.MiddleCenter;
                label1.Text = tablo.Message(true);
                tablo.SessionReaction(DateTime.Now, "Поїзд прибув");
            }
            if (f == true) 
             if (e.KeyCode == Keys.Back)
                {
                   tablo.RESULT_S = 0;
                    tablo.RESULT_M = 0;
                    TimerArrive.Start();
                    TimerString.Start();
                    f = false;
                    tablo.SessionReaction(DateTime.Now, "Поїзд відбув");
                }
            if (e.KeyCode == Keys.N)
                AddNewsRemote();
          
        }
        private void Board_Load(object sender, EventArgs e)
        {
            TimerArrive.Enabled = TimerNow.Enabled = true;
            TimerArrive.Interval = TimerNow.Interval = 1000;
            TimerString.Enabled = true;
            TimerString.Interval = 15;
        }
 
        private void TimerNow_Tick(object sender, EventArgs e)
        {
            this.NowTime.Text = tablo.FormatNowDate();
        }
        private void AddNewsRemote()
        {
            RemoteControl Rm = new RemoteControl();
            Rm.ShowDialog();
            if (Rm.DialogResult == System.Windows.Forms.DialogResult.OK)
                tablo.run.AddNew(Rm.data);
        }
        private void TimerDeparture_Tick(object sender, EventArgs e)
        {
            ArriveTime.Text = tablo.FormatDepartureDate();
                if (tablo.RESULT_S == 60)
                {
                    tablo.RESULT_M++;
                    if (tablo.RESULT_M == tablo.Diff)
                    {
                        tablo.index++;
                        TimerString.Enabled = false;
                        label1.Left = 210;
                        label1.TextAlign = ContentAlignment.MiddleCenter;
                        label1.Text = tablo.Message(false);
                        tablo.SessionReaction(DateTime.Now, "Поїзд запізнився");
                    }
                    tablo.RESULT_S = 0;
                }
            
        } 
        private void move_label(List<string> a)
        {
            if (label1.Left > -label1.Width)
            {
                label1.Left -= 5;
                if (move == a.Count) move = 0;
                label1.Text = a[move];
            }
            else
            {
                label1.Left = panel1.Width;
                if (move == a.Count) move = 0;
                label1.Text = a[move];
                move++;
            }
        }
        private void TimerString_Tick(object sender, EventArgs e)
        {
            move_label(tablo.run.NEWS);
        }
    }
}
