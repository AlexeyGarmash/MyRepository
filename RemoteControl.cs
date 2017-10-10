using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metropolitan
{
    public partial class RemoteControl : Form
    {
        public string data { get; set; }
        public RemoteControl()
        {
            InitializeComponent();
            OK.Enabled = false;
        }

        private void AddNews_TextChanged(object sender, EventArgs e)
        {
            if (AddNews.Text.Length < 1)
                OK.Enabled = false;
            else
                OK.Enabled = true;
        }

        private void OK_Click(object sender, EventArgs e)
        {
            DialogResult = System.Windows.Forms.DialogResult.OK;
            data = AddNews.Text;
           
        }
        private void Session()
        {
            Info.Clear();
            foreach (var t in Tablo.session)
            {
                Info.Text += t;
            }
        }

        private void GetReact_Click(object sender, EventArgs e)
        {
            Session();
        }

        private void RemoteControl_Load(object sender, EventArgs e)
        {
            Session();
        }
    }
}
