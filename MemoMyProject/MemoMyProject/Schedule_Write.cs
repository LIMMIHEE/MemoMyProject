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
    public partial class Schedule_Write : Form
    {
       

        public Schedule_Write()
        {
            InitializeComponent();
     
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Now_Schedule_Main schedule_Main = new Now_Schedule_Main();
            schedule_Main.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Schedule_Write_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\임미희\Documents\memo.mdf;Integrated Security=True;Connect Timeout=30");
            //SqlDataAdapter sda = new SqlDataAdapter("select * from memo", conn);
            SqlDataAdapter sda = new SqlDataAdapter("insert into memo(Schedule_name,Schedule_simple_info,Schedule_Details_info) value('" + textBox1.Text+ "','"+ textBox2.Text+ "','" + textBox3.Text + "')", conn);
            DataTable dataTable = new DataTable();

            sda.Update(dataTable);
            */
            //적용 안됨. MySql 사용.

            MySqlConnection conn = new MySqlConnection("Server=localhost;Database=memo;PORT=3308;Uid=root;Pwd=root;");
            String insertQuery = "insert into memo_table(Schedule_name,Schedule_simple_info,Schedule_Details_info) value('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
            conn.Open();
            MySqlCommand command = new MySqlCommand(insertQuery, conn);
            try
            {
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("정상입력");
                    this.Visible = false;
                    Now_Schedule_Main schedule_Main = new Now_Schedule_Main();
                    schedule_Main.ShowDialog();
                }
                else
                {
                    MessageBox.Show("비정상입력");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
