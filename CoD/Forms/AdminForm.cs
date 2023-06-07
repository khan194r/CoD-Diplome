using CoD.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoD.Forms
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProductForm productForm = new AddProductForm();
            productForm.product = new Product();
            productForm.ShowDialog();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormUserView userView = new FormUserView();
            userView.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MainForm mff = new MainForm();
            mff.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddUserForm registry = new AddUserForm();
            registry.user = new User();
            registry.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            OrderHistory orderHistory = new OrderHistory();
            orderHistory.Show();
        }
    }
}
