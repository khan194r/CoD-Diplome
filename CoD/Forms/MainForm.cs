using CoD.Forms;
using CoD.Forms.Cardss;
using CoD.Models;
using CoD.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Drawing.Text;
using System.Globalization;
using System.Linq;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoD
{
    public partial class MainForm : Form
    {
        List<Product> products = new List<Product>();
        public int dent;
        public bool auto;

        #region Основная форма ч
        public MainForm()
        {
            InitializeComponent();
            labelTime.Text = "Время: " + $"{DateTime.Now.ToShortTimeString()}";
            labelDate.Text = "Дата: " + $"{DateTime.Now.ToString("dddd, d MMMM", CultureInfo.GetCultureInfo("ru-ru"))}";
            products = dbcontext.db.Product.ToList();
        }
        #endregion Основная форма ч

        #region Генерация карточек продукта циклом форейч
        public void GenerateProductCard(List<Product> product)
        {
            foreach (var productItem in product)
            {
                ProductCardd card = new ProductCardd();
                card.GenerateDataProductCard(productItem);
                flowLayoutPanel1.Controls.Add(card);
                card.Click += Card_Click;
            }
        }
        #endregion Генерация карточек продукта циклом форейч

        #region Событие нажатия на карточку товара
        private void Card_Click(object sender, EventArgs e)
        {
            ProductCardd card = (ProductCardd)sender;
            ProductInfoFull ab = new ProductInfoFull();
            ab.auto = auto;
            ab.dent = dent;
            var product = dbcontext.db.Product.FirstOrDefault(a => a.Product_ID.ToString() == card.IDlabel.Text);
            ab.productUpData = product;
            ab.ShowDialog();
            this.Hide();

        }
        #endregion Событие нажатия на карточку товара

        #region Загрузка формы MainForm
        private void MainForm_Load(object sender, EventArgs e)
        {
            FIOlabel.Text = "Здравствуйте, Гость";
            GenerateProductCard(products);
            searchTextBoxMAIN.ForeColor = Color.Gray;
            timer60sec.Interval = 1000;

            var alltipe = dbcontext.db.Category.Select(a => a.Category_Name).ToList();
            alltipe.Insert(0, "Все типы");
            CATEGORYcombobox.DataSource = alltipe;
            CATEGORYcombobox.SelectedIndex = 0;
            SORTcombobox.SelectedIndex = 0;
         
            if (dent == 1 && auto)
            {
                if (AuthForm.user.RoleID == 2)
                {
                    administratorPanelButton.Visible = true;
                }              
                personalDiscountLabel.Visible = true;
                personalDiscountLabel.Text = "Ваша персональная скидка: " + $"{AuthForm.user.User_DiscountBonus}" + "%";
                FIOlabel.Text = "Здравствуйте, " + $"{AuthForm.user.User_LastName} {AuthForm.user.User_Name} {AuthForm.user.User_MiddleName}";
                yourRole.Visible = true;
                yourRole.Text = "Ваша роль: " + $"{AuthForm.user.Role.Role_Name}";
                buttonLogoutMain.Visible = true;
                AuthButtonMain.Visible = false;
                registryButtonMain.Visible = false;
            }
        }
        #endregion Загрузка формы MainForm

        #region Таймер обновления системного времени
        private void timer60sec_Tick(object sender, EventArgs e)
        {
            labelTime.Text = "Время: " + $"{DateTime.Now.ToShortTimeString()}";
            labelDate.Text = "Дата: " + $"{DateTime.Now.ToString("dddd, d MMMM", CultureInfo.GetCultureInfo("ru-ru"))}";
        }
        #endregion Таймер обновления системного времени

        #region searchTextBox прекратить ввод
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(searchTextBoxMAIN.Text))
            {
                searchTextBoxMAIN.Text = "Введите для поиска по наименованию...";
                searchTextBoxMAIN.ForeColor = Color.Gray;
            }
        }
        #endregion searchTextBox прекратить ввод

        #region searchTextBox ввод текста
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (searchTextBoxMAIN.Text == "Введите для поиска по наименованию...")
            {
                searchTextBoxMAIN.Text = null;
                searchTextBoxMAIN.ForeColor = Color.Black;
            }
        }
        #endregion searchTextBox ввод текста

        #region Метод поиска, сортировки и фильтрации
        public void SearchAndFindAndMore()
        {
            List<Product> updatedList = dbcontext.db.Product.ToList();

            if (searchTextBoxMAIN.Text != "Введите для поиска по наименованию..." && searchTextBoxMAIN.Text != "")
            {
                flowLayoutPanel1.Controls.Clear();
                updatedList = updatedList.Where(x => x.Product_Name.ToLower().Contains(searchTextBoxMAIN.Text.ToLower())).ToList();
            }

            if (CATEGORYcombobox.SelectedIndex != 0)
            {
                flowLayoutPanel1.Controls.Clear();
                updatedList = updatedList.Where(x => x.CategoryID == CATEGORYcombobox.SelectedIndex).ToList();
            }

            switch (SORTcombobox.SelectedIndex)
            {
                case 1:
                    updatedList = updatedList.OrderBy(x => x.Product_Name).ToList();
                    break;
                case 2:
                    updatedList = updatedList.OrderByDescending(x => x.Product_Name).ToList();
                    break;
                case 3:
                    updatedList = updatedList.OrderBy(x => x.Product_Cost).ToList();
                    break;
                case 4:
                    updatedList = updatedList.OrderByDescending(x => x.Product_Cost).ToList();
                    break;
            }
            GenerateProductCard(updatedList);
        }
        #endregion Метод поиска, сортировки и фильтрации

        #region TextBox изменение текста
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
                flowLayoutPanel1.Controls.Clear();
                SearchAndFindAndMore();
            
        }
        #endregion TextBox изменение текста

        #region ComboBox смена индекса
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SearchAndFindAndMore();
        }
        #endregion ComboBox смена индекса

        #region ComboBox смена индекса_2
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            flowLayoutPanel1.Controls.Clear();
            SearchAndFindAndMore();
        }
        #endregion ComboBox смена индекса_2

        #region Кнопка авторизации
        private void button1_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.ShowDialog();
            this.Hide();
           
            if (dent == 1 && auto)
            {
                if (AuthForm.user.RoleID == 2)
                {
                    administratorPanelButton.Visible = true;
                }
                flowLayoutPanel1.Controls.Clear();
                SearchAndFindAndMore();
                personalDiscountLabel.Visible = true;
                personalDiscountLabel.Text = "Ваша персональная скидка: " + $"{AuthForm.user.User_DiscountBonus}" + "%";
                FIOlabel.Text = "Здравствуйте, " + $"{AuthForm.user.User_LastName} {AuthForm.user.User_Name} {AuthForm.user.User_MiddleName}";
                yourRole.Visible = true;
                yourRole.Text = "Ваша роль: " + $"{AuthForm.user.Role.Role_Name}";
                buttonLogoutMain.Visible = true;
                AuthButtonMain.Visible = false;
                registryButtonMain.Visible = false;
            }
        }
        #endregion Кнопка авторизации

        #region Кнопка деавторизации
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Вы действительно хотите выйти?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                Application.Restart();

                #region Не рабочий
                //dent = 0;
                //auto = false;
                //AuthForm.user = new User();
                //FIOlabel.Text = "Здравствуйте, Гость";
                //yourRole.Visible = false;
                //AuthButtonMain.Visible = true;
                //registryButtonMain.Visible = true;
                //buttonLogoutMain.Visible = false;
                //personalDiscountLabel.Visible = false;
                //administratorPanelButton.Visible = false;
                //flowLayoutPanel1.Controls.Clear();
                //SearchAndFindAndMore();
                #endregion Не рабочий
            }
        }
        #endregion Кнопка деавторизации

        #region Кнопка регистрации для клиентов
        private void button2_Click(object sender, EventArgs e)
        {
            Registry registry = new Registry();
            registry.user = new User();
            registry.ShowDialog();
        }
        #endregion Кнопка регистрации для клиентов

        #region Кнопка панели администраторов
        private void administratorPanelButton_Click(object sender, EventArgs e)
        {
            AdminForm admfrmm = new AdminForm();
            admfrmm.Show();
            this.Close();
        }
        #endregion Кнопка панели администраторов
    }
}