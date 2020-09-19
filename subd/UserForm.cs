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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void купитьПодпискуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BuySubscribeForm form1 = new BuySubscribeForm();
            form1.Show();

        }

        private void найтиКнигуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DB db = new DB();

        }
    }
}
