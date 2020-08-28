using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace subd
{
    public partial class BuySubscribeForm : Form
    {
        public BuySubscribeForm()
        {
            InitializeComponent();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Buysub();
            //DB db = new DB();
            //DataTable table = new DataTable();
            //MySqlDataAdapter adapter = new MySqlDataAdapter();
            //MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL", db.getConnection());
            //command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text;
            //adapter.SelectCommand = command;
            //adapter.Fill(table);     //вывод результата запроса
            //if (table.Rows.Count > 0)
            //{   MySqlCommand command2=new MySqlCommand("UPDATE `users` SET `subscription` = '1' WHERE `users`.`id` = 7",db.getConnection)
            //   // MySqlCommand command1 = new MySqlCommand("UPDATE `users` SET `subscription` = '1' WHERE `login` = @UL", db.getConnection());
            //   // command1.Parameters.Add("@UL", MySqlDbType.VarChar).Value = loginField.Text;
            //    adapter.SelectCommand = command2;
            //}
            //else { MessageBox.Show("Такого логина не существует"); }









        }

        private void loginBox_TextChanged(object sender, EventArgs e)
        {

        }
        Point lastpoint;
        private void BuySubscribeForm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void BuySubscribeForm_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
        private void Buysub()
        {
            DB db = new DB();
            db.openConnection();
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `subscription` = '1' WHERE `users`.`id` = 6", db.getConnection());
            db.closeConnection();
        }
    }
}
