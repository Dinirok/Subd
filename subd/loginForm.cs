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
    public partial class loginForm : Form
    {   
        public loginForm()
        {
            InitializeComponent();
            this.passField.AutoSize = false;//отключили автоматическое подстраивание ширины и высоты 
            this.passField.Size = new Size(this.passField.Size.Width, 60);
        }

        private void loginForm_Load(object sender, EventArgs e)
        {

        }

        private void Авторизация_Click(object sender, EventArgs e)
        {

        }
        //закрытие приложения
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //при наведении курсора  на closebutton он становится красным
        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red;
        }
        //после того как убрали курсор с closeButton становится обратно белым
        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.White;
        }
        Point lastpoint; //метод для движения формы при зажатой ЛКМ
        private void panel1_MouseMove(object sender, MouseEventArgs e)
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
        //вход в приложение по логин паролю
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            String loginUser = loginField.Text;
            String passUser = passField.Text;
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL and `pass`=@uP", db.getConnection());
            command.Parameters.Add("@uL",MySqlDbType.VarChar).Value=loginUser; 
            command.Parameters.Add("@uP", MySqlDbType.VarChar).Value = passUser;

            adapter.SelectCommand = command; 
            adapter.Fill(table);     //вывод результата запроса
            
            if (table.Rows.Count > 0) //
            {   
                this.Hide();
                MainForm mainForm = new MainForm();
                            
                mainForm.Show();
            }
            else { MessageBox.Show("Неправильный логин или пароль "); }

        }
        
        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void loginField_TextChanged(object sender, EventArgs e)
        {
                
        }

        private void passField_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void RegisterLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void loginForm_Enter(object sender, EventArgs e)
        {
            
        }

        private void passField_KeyPress(object sender, KeyPressEventArgs e)
        {
           
        }
    }
}
