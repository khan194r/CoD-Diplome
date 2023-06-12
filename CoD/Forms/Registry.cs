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
    public partial class Registry : Form
    {
        List<User> users = new List<User>();
        public User user { get; set; }

        #region Регистрация
        public Registry()
        {
            InitializeComponent();
            users = dbcontext.db.User.ToList();
        }
        #endregion Регистрация

        #region Кнопка, отвечающая за регистрацию
        private void Registrbutton_Click(object sender, EventArgs e)
        {           
            try
            {
                if (dbcontext.db.User.Any(a => a.User_Login == user_LoginTextBox.Text))
                {
                    MessageBox.Show("Такой логин уже есть");
                }
                else
                {
                    user.RoleID = 1;
                    user.User_DiscountBonus = 5;
                    dbcontext.db.User.Add(user);
                    dbcontext.db.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены");
                    DialogResult = DialogResult.OK;                 
                }              
            }
            catch (Exception)
            {
                MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion Кнопка, отвечающая за регистрацию

        #region Загрузка формы
        private void Registry_Load(object sender, EventArgs e)
        {          
            userBindingSource.DataSource = user;
        }
        #endregion Загрузка формы

        #region Кнопка отмены регистрации
        private void button2_Click(object sender, EventArgs e)
        {           
                this.Close();            
        }
        #endregion Кнопка отмены регистрации

        #region Запрет ввода букв или цифр
        private void user_LastNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ввод только букв
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void user_NameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ввод только букв
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void user_MiddleNameTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ввод только букв
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void user_PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Только цифры
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }
        #endregion Запрет ввода букв или цифр
    }
}
