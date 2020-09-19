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
  
            
            MySqlCommand command = new MySqlCommand("UPDATE `users` SET `subscription` = 'YES' WHERE `login` = @UL", db.getConnection());
            command.Parameters.Add("@UL", MySqlDbType.VarChar).Value = loginField.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Подписка куплена");
            }
            else
            {
                MessageBox.Show("Ошибка логина");
            }
            db.closeConnection();//
        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
