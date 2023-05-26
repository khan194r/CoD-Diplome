using CoD.Forms.Cardss;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CoD.Forms
{
    public partial class FormUserView : Form
    {
        List<User> userse = new List<User>();

        #region Форма просмотра
        public FormUserView()
        {
            InitializeComponent();
            userse = dbcontext.db.User.ToList();
        }
        #endregion Форма просмотра

        #region Закрытие этой формы
        private void buttonCloseVIew_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion  Закрытие этой формы

        #region Генерация карточек пользователей циклом форейч
        public void GenerateUsersCard(List<User> user)
        {
            foreach (var wara in user)
            {
                UserViewCard carde = new UserViewCard();
                carde.UserGenerateCardik(wara);
                flowLayoutPanel1.Controls.Add(carde);
            }
        }
        #endregion Генерация карточек пользователей циклом форейч

        #region Загрузка формы
        private void FormUserView_Load(object sender, EventArgs e)
        {
            GenerateUsersCard(userse);

            var allroles = dbcontext.db.Role.Select(a => a.Role_Name).ToList();
            allroles.Insert(0, "Все роли");
            ROLEScombobox.DataSource = allroles;
            ROLEScombobox.SelectedIndex = 0;
        }
        #endregion Загрузка формы

        #region Метод поиска и сортировки
        private void SEARCH_AND_FIND()
        {
            List<User> newListUser = dbcontext.db.User.ToList();

            if (searchTextBoxmmm.Text != "Введите для поиска по фамилии..." && !String.IsNullOrWhiteSpace(searchTextBoxmmm.Text))
            {
                flowLayoutPanel1.Controls.Clear();
                newListUser = newListUser.Where(x =>
                    x.User_LastName.ToLower().Contains(searchTextBoxmmm.Text.ToLower()) ||
                    x.User_Name.ToLower().Contains(searchTextBoxmmm.Text.ToLower()) ||
                    x.User_MiddleName.ToLower().Contains(searchTextBoxmmm.Text.ToLower())
                ).ToList();
            }
            if (ROLEScombobox.SelectedIndex != 0)
            {
                flowLayoutPanel1.Controls.Clear();
                newListUser = newListUser.Where(x => x.RoleID == ROLEScombobox.SelectedIndex).ToList();
            }
            flowLayoutPanel1.Controls.Clear();
            GenerateUsersCard(newListUser);
        }
        #endregion Метод поиска и сортировки

        #region Комбо бокс изменение текста и индекса
        private void searchTextBoxmmm_TextChanged(object sender, EventArgs e)
        {
            SEARCH_AND_FIND();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SEARCH_AND_FIND();
        }
        #endregion Комбо бокс изменение текста и индекса

        #region Введите для поиска....ну крч текстбокс
        private void searchTextBoxmmm_Enter(object sender, EventArgs e)
        {
            if (searchTextBoxmmm.Text == "Введите для поиска по фамилии...")
            {
                searchTextBoxmmm.Text = null;
                searchTextBoxmmm.ForeColor = Color.Black;
            }
        }
            private void searchTextBoxmmm_Leave(object sender, EventArgs e)
            {
                if (String.IsNullOrWhiteSpace(searchTextBoxmmm.Text))
                {
                    searchTextBoxmmm.Text = "Введите для поиска по фамилии...";
                    searchTextBoxmmm.ForeColor = Color.Gray;
                }
            }
        }
    #endregion Введите для поиска....ну крч текстбокс
}
