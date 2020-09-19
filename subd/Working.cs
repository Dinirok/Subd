using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using MySql.Data.MySqlClient;
using Microsoft.VisualBasic;

namespace subd
{
    public partial class Working : Form
    {

        public Working()
        {
            InitializeComponent();
            dataGridView1.Hide();
            dataGridView2.Hide();

        }


        private void Working_Load(object sender, EventArgs e)
        {

        }
        private void LoadData() //выводит таблицу пользователей
        {
            dataGridView1.Show();
            string connectionString = "server = localhost; port = 3306; username = root; password = root; database = subdproject ";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            myConnection.Open();
            string query = "SELECT * FROM `users`";
            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[6]);
                //data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();
            myConnection.Close();
            foreach (string[] s in data)
            {
                dataGridView1.Rows.Add(s);
            }

        }


        private void тестToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //string con1=""
        }


        /*private void toolStripButton1_Click(object sender, EventArgs e)//dosnt work
        {
            string a = Microsoft.VisualBasic.Interaction.InputBox("Введите ваш логин");
            DB db = new DB();
            db.openConnection();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `subscription` = '1' WHERE `login`=@ul", db.getConnection());
            command.Parameters.Add("@ul", MySqlDbType.VarString).Value = a;
            adapter.SelectCommand = command;
            db.closeConnection();
        }*/

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)//выводит таблицу пользователей
        {
            LoadData();
        }

        private void Update_Click(object sender, EventArgs e)//обновляет таблицу пользователей
        {
            dataGridView1.Rows.Clear(); dataGridView2.Rows.Clear();
            LoadData(); LoadBook();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {

        }
        Point lastpoint;
        private void Working_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void Working_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void LoadBook()
        {
            dataGridView2.Show();
            string connectionString = "server = localhost; port = 3306; username = root; password = root; database = subdproject ";
            MySqlConnection myConnection = new MySqlConnection(connectionString);
            myConnection.Open();
            string query = "SELECT * FROM `stock`";
            MySqlCommand command = new MySqlCommand(query, myConnection);
            MySqlDataReader reader = command.ExecuteReader();
            List<string[]> data = new List<string[]>();
            while (reader.Read())
            {
                data.Add(new string[6]);
               // data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();

            }
            reader.Close();
            myConnection.Close();
            foreach (string[] s in data)
            {   
                dataGridView2.Rows.Add(s);
            }

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {

            LoadBook();//again appload to datagridview for changes


        }
    } 



        


}
