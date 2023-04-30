using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace THA_W8_Alfred_W
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Form2 playerdata;
        Form3 matchdetails;

        private void playerDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            playerdata = new Form2();
            playerdata.TopLevel = false;
            playerdata.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(playerdata);
            playerdata.Show();
        }

        private void showMatchDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            matchdetails = new Form3();
            matchdetails.TopLevel = false;
            matchdetails.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(matchdetails);
            matchdetails.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
