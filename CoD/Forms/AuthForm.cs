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
    public partial class AuthForm : Form
    {
        public static User user { get; set; } = new User();
        public static Role role { get; set; }
        public int dent = 0;
        public bool auto = false;

        #region AuthFORMa
        public AuthForm()
        {
            InitializeComponent();
        }
        #endregion AuthFORMa

        #region Кнопка авторизации через Any
        private void enterbutton_Click(object sender, EventArgs e)
        {
            if (dbcontext.db.User.Any(a => a.User_Login == logintextBox.Text && a.User_Password == passwordtextBox.Text))
            {
                user = dbcontext.db.User.First(a => a.User_Login == logintextBox.Text);
                MessageBox.Show("Добро пожаловать!");
                dent = 1;
                auto = true;
                MainForm frm = new MainForm();
                frm.dent = dent;
                frm.auto = auto;
                frm.Show();
                this.Hide();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Неверно!");
            }
        }
        #endregion Кнопка авторизации через Any

        #region Кнопка отмены авторизации
        private void canselbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Отменить авторизацию?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dent = 0;
                DialogResult = DialogResult.Cancel;
            }
        }
        #endregion Кнопка отмены авторизации
    }
}
        