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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            
            
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            
            Working working = new Working();
            working.Show();
        }
        Point lastpoint;
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            BuySubscribeForm buySubscribeForm = new BuySubscribeForm();
            buySubscribeForm.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e) //registerForm
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            AddBook addBook = new AddBook();
            addBook.Show();

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }
    }
}
