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
    public partial class AddUserForm : Form
    {
        public User user { get; set; }

        #region Добавление сотрудника
        public AddUserForm()
        {
            InitializeComponent();
        }
        #endregion Добавление сотрудника

        #region Загрузка формы
        private void AddUserForm_Load(object sender, EventArgs e)
        {
            roleBindingSource.DataSource = dbcontext.db.Role.ToList();
            userBindingSource.DataSource = user;
        }
        #endregion Загрузка формы

        #region Отмена добавления
        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Отменить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion Отмена добавления

        #region Кнопка добавления пользователя (сотрудника)
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dbcontext.db.User.Any(a => a.User_Login == user_LoginTextBox.Text))
                {
                    MessageBox.Show("Такой логин уже существует");
                }
                else
                {
                    role_IDComboBox.SelectedIndex = 0;
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
        #endregion Кнопка добавления пользователя (сотрудника)

        #region ФИО ввод только БУКВ
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
        #endregion ФИО ввод только БУКВ

        #region ввод цифр
        private void user_PhoneTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Только цифры
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }
        #endregion ввод цифр
    }
}
