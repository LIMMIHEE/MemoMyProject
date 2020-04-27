using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MemoMyProject
{
    public partial class Now_Schedule_Main : Form
    {
      
        public Now_Schedule_Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Schedule_Write schedule_Write = new Schedule_Write();
            schedule_Write.ShowDialog();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Main_Form Main = new Main_Form();
            Main.ShowDialog();
        }

        private void Now_Schedule_Main_Load(object sender, EventArgs e)
        {
            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=memo;PORT=3308;Uid=root;Pwd=root;");
            string sql = "SELECT * FROM memo_table";

            using (conn)
            {
                conn.Open();

                // TSQL문장과 Connection 객체를 지정   
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                // 데이타는 서버에서 가져오도록 실행
                MySqlDataReader rdr = cmd.ExecuteReader();
                if (rdr == null)
                {
                    MessageBox.Show("값 없음");
                }
                else
                {
                    while (rdr.Read())
                    {
                        label1.Text = rdr["Schedule_name"].ToString();
                        textBox1.Text = rdr["Schedule_simple_info"].ToString();
                        //label1.Text = rdr["Schedule_Details_info"].ToString();
                    }
                }
                conn.Close();
            }
        }

        private void Now_Schedule_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
