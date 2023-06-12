using CoD.Models;
using CoD.Utils;
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
    public partial class FormUserEdit : Form
    {
        public User userUpData { get; set; }
        public Role roleData { get; set; }

        public FormUserEdit()
        {
            InitializeComponent();
        }

        private void FormUserEdit_Load(object sender, EventArgs e)
        {
            userBindingSource.DataSource = userUpData;
            roleBindingSource.DataSource = dbcontext.db.Role.ToList();
        }

        private void saveUserbb_Click(object sender, EventArgs e)
        {
            try
            {                
                dbcontext.db.SaveChanges();
                MessageBox.Show("Данные успешно изменены");              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении данных: " + ex.Message);
            }
        }
    

        private void deleteUser_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить данный товар?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dbcontext.db.User.Remove(userUpData);
                dbcontext.db.SaveChanges();
                MessageBox.Show("Пользователь " + userUpData.User_LastName + " удален!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
