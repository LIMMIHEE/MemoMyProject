using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoMyProject
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Now_Schedule_Main now_Schedule_Main = new Now_Schedule_Main();
            now_Schedule_Main.ShowDialog();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Start_Form Main = new Start_Form();
            Main.ShowDialog();
        }

        private void Main_Form_Load(object sender, EventArgs e)
        {

        }

        private void Main_Form_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
