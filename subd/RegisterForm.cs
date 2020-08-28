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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
            userNameField.Text = "Введите имя";// делаем подсказку и меняем цвет
            userNameField.ForeColor = Color.Gray;
            userSurnameField.Text = "Введите фамилию";
            userSurnameField.ForeColor = Color.Gray;
            loginField.Text = "Введите логин";
            loginField.ForeColor = Color.Gray;
            
            
        }

        private void Авторизация_Click(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)//close form
        {
            Application.Exit();
        }
        Point lastpoint; //метод для движения формы при зажатой ЛКМ
        private void MainPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }


        }

        private void MainPanel_MouseDown(object sender, MouseEventArgs e) //
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void userNameField_Enter(object sender, EventArgs e) //добавляет подсказку в textbox
        {
            if(userNameField.Text=="Введите имя")
            {
                userNameField.Text = "";
                userNameField.ForeColor = Color.Black;
            }
        }

        private void userNameField_Leave(object sender, EventArgs e)
        {
            if (userNameField.Text == "")
            {
                userNameField.Text = "Введите имя";
                userNameField.ForeColor = Color.Gray;
            }
        }

        private void userSurnameField_Enter(object sender, EventArgs e) //добавляет подсказку в textbox для фамилии
        {
            if (userSurnameField.Text == "Введите фамилию")
            {
                userSurnameField.Text = "";
                userSurnameField.ForeColor = Color.Black;
            }
        }

        private void userSurnameField_Leave(object sender, EventArgs e)
        {
            if (userSurnameField.Text == "")
            {
                userSurnameField.Text = "Введите фамилию";
                userSurnameField.ForeColor = Color.Gray;
            }
        }

        private void passField_Leave(object sender, EventArgs e)
        {
         
        }

        private void loginField_Leave(object sender, EventArgs e)
        {
            if (loginField.Text == "")
            {
                loginField.Text = "Введите логин";
                loginField.ForeColor = Color.Gray;
            }
        }

        private void passField_Enter(object sender, EventArgs e)
        {
            
        }

        private void loginField_Enter(object sender, EventArgs e)
        {
            if (loginField.Text == "Введите логин")
            {
                loginField.Text = "";
                loginField.ForeColor = Color.Black;
            }
        }

        private void buttonRegister_Click(object sender, EventArgs e)//register new accaunt
        {   if (userNameField.Text == "Введите имя" || userSurnameField.Text=="Введите фамилию" || loginField.Text=="Введите логин" || passField.Text=="")
            {
                MessageBox.Show("Введите недостающие данные");
                return;
            }
            if (isUserExist())
            {
                return;
            }



            DB db = new DB();
            MySqlCommand command = new MySqlCommand("INSERT INTO `users` (`login`, `pass`, `subscription`, `name`, `surname`) VALUES ( @login, @pass, '0',@name, @surname)",db.getConnection());
            command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = passField.Text;
            command.Parameters.Add("@name", MySqlDbType.VarChar).Value = userNameField.Text;
            command.Parameters.Add("@login", MySqlDbType.VarChar).Value = loginField.Text;
            command.Parameters.Add("@surname", MySqlDbType.VarChar).Value = userSurnameField.Text;
            db.openConnection();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Аккаунт был создан"); 
            }
            else
            {
                MessageBox.Show("Аккаунт не был создан");
            }



            db.closeConnection();
        }

        private void userNameField_TextChanged(object sender, EventArgs e)
        {

        }
        public Boolean isUserExist()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `users` WHERE `login`=@uL", db.getConnection());
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = loginField.Text; 
             

            adapter.SelectCommand = command;
            adapter.Fill(table);     //вывод результата запроса
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже существует, введите другой ");
                return true;
            }
            else { return false; }


        }

        private void AuthorizationLabel_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.Show();
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
        
}
