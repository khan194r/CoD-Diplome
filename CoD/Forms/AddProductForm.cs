using CoD.Models;
using CoD.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace CoD.Forms
{
    public partial class AddProductForm : Form
    {
        Converter converter = new Converter();
        public Product product {  get; set; }
        public Category category { get; set; }

        #region Форма добавления
        public AddProductForm()
        {
            InitializeComponent();
        }
        #endregion Форма добавления

        #region Загрузка формы
        private void AddProductForm_Load(object sender, EventArgs e)
        {
            categoryBindingSource.DataSource = dbcontext.db.Category.ToList();
            productBindingSource.DataSource = product;
        }
        #endregion Загрузка формы

        #region Кнопка добавления товара
        private void addproductbutton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!dbcontext.db.Category.Any(a => a.Category_Name == categoryIDComboBox.Text))
                {
                    // Категория не существует, создаем новую и добавляем ее в базу данных
                    category = new Category();
                    category.Category_Name = categoryIDComboBox.Text;
                    dbcontext.db.Category.Add(category);
                    dbcontext.db.SaveChanges();
                }
                product.CategoryID = dbcontext.db.Category.First(a => a.Category_Name == categoryIDComboBox.Text).Category_ID;
                    dbcontext.db.Product.Add(product);
                    dbcontext.db.SaveChanges();
                    MessageBox.Show("Данные успешно сохранены");
                    DialogResult = DialogResult.OK;
                  //  Application.Restart();
                
                
            }
            catch (Exception)
            {
                MessageBox.Show("Неизвестная ошибка", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        #endregion Кнопка добавления товара

        #region Отмена продукта
        private void cancelproductbutton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Отменить?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion Отмена продукта

        #region КНОПКА ВЫБОРА ИЗОБРАЖЕНИЯ
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Изображения(*.bmp;*.jpg;*.png;*.JPEG)|*.BMP;*.JPG;*.PNG;*.JPEG";
            DialogResult dr = dialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string file = dialog.FileName;
                byte[] bytes = File.ReadAllBytes(file);
                product.Product_Photo = bytes;
                pictureBox1ProductView.Image = (Image)converter.ConvertFrom(product.Product_Photo);
                using (MemoryStream ms = new MemoryStream(product.Product_Photo))
                {
                    pictureBox1ProductView.Image = Image.FromStream(ms);
                }
            }
        }
        #endregion КНОПКА ВЫБОРА ИЗОБРАЖЕНИЯ

        #region Ввод цифр
        private void quantity_in_stockTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Только цифры
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && (e.KeyChar != '+'))
            {
                e.Handled = true;
            }
        }
        #endregion Ввод цифр

        #region Мусор
        private void categoryIDComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void categoryIDLabel_Click(object sender, EventArgs e)
        {

        }
        #endregion Мусор
    }
}
