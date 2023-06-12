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

namespace CoD.Forms.Cardss
{
    public partial class UserViewCard : UserControl
    {
        public UserViewCard()
        {
            InitializeComponent();
        }
        #region GenerateCard
        public void UserGenerateCardik(User user)
        {
            label1.Text = user.User_ID.ToString();
            userIDLabel.Text = "Идентификатор пользователя: " + user.User_ID.ToString();
            userLastNameLabel.Text = "Фамилия пользователя: " + user.User_LastName;
            userNameLabel.Text = "Имя пользователя: " + user.User_Name;
            userMiddleNameLabel.Text = "Отчество пользователя: " + user.User_MiddleName;
            userLoginLabel.Text = "Логин пользователя: " + user.User_Login;
            userPasswordLabel.Text = "Пароль пользователя: " + user.User_Password;
            userBirhdayLabel.Text = "Дата рождения: " + user.User_DateBirthDay.ToString("dd.MM.yyyy");
            userRoleName.Text = "Роль пользователя: " + user.Role.Role_Name;
            userPhoneLabel.Text = "Телефон пользователя: " + user.User_Phone;
            userEmailLabel.Text = "Почта пользователя: " + user.User_Email;
            userDiscountLabel.Text = "Скидка пользователя: " + user.User_DiscountBonus.ToString() + "%";
        }
        #endregion GenerateCard

        #region MouseMove and Leave
        private void UserViewCard_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.LightGray;
        }

        private void UserViewCard_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
        #endregion MouseMove and Leave
    }
}
