using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace subd
{
    public partial class AddBook : Form
    {
        public AddBook()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void BookAdd_Click(object sender, EventArgs e)
        {
            LoadBook();
        }
        private void LoadBook()
        {
            string BookName = nameOfBook.Text.ToString();
            string AuthorName = NameAuthor.Text.ToString();
            string bookGenre = BookGenre.Text.ToString();
            string opisanie = Opisanie.Text.ToString();
            DB db = new DB();
            db.openConnection();
            try
            {
                MySqlCommand command = new MySqlCommand("INSERT INTO stock( Nazvanie, Genre, Opisanie, Author)" +
                    "VALUES ( @BookName,@bookGenre,@opisanie,@AuthorName)", db.getConnection());
                command.Parameters.Add("@BookName", MySqlDbType.VarChar).Value = BookName;
                command.Parameters.Add("@bookGenre", MySqlDbType.VarChar).Value = bookGenre;
                command.Parameters.Add("@opisanie", MySqlDbType.VarChar).Value = opisanie;
                command.Parameters.Add("@AuthorName", MySqlDbType.VarChar).Value = AuthorName;
                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Книга добавлена");
                    db.closeConnection();
                }
                else
                {
                    MessageBox.Show("Книга не добавлена");
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
        }
    }
}
