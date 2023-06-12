using CoD.Models;
using CoD.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace CoD.Forms
{
    public partial class ProductEditForm : Form
    {
        Converter converter = new Converter();
        public Product productUpData { get; set; }
        public Category category { get; set; }
        public ProductEditForm()
        {
            InitializeComponent();
        }

        #region Загрузка формы
        private void ProductEditForm_Load(object sender, EventArgs e)
        {
            categoryBindingSource.DataSource = dbcontext.db.Category.ToList();
            productBindingSource.DataSource = productUpData;
            if (productUpData.Product_Photo == null)
                product_PhotoPictureBox.ImageLocation = "..\\..\\Resources\\ZAGLUSHKA.jpg";
            product_CostTextBox.Text = productUpData.Product_Cost.ToString();
            product_Discount_PercentNumericUpDown.Text = productUpData.Product_Discount_Percent.ToString();
            quantity_in_stockTextBox.Text = productUpData.Quantity_in_stock.ToString();
        }
        #endregion Загрузка формы

        #region Кнопка сохранения изменений
        private void saveEditButton_Click(object sender, EventArgs e)
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
                //if (productUpData.Product_Photo == null)
                //    product_PhotoPictureBox.ImageLocation = "..\\..\\Resources\\ZAGLUSHKA.jpg";
                dbcontext.db.SaveChanges();
                MessageBox.Show("Данные успешно изменены");
                this.Hide();
                MainForm ma = new MainForm();
                ma.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при изменении данных: " + ex.Message);
            }
        }
        #endregion Кнопка сохранения изменений

        #region Кнопка сброса изображений [НЕ РАБОТАЕТ, КНОПКА СКРЫТА]
        private void button1_Click(object sender, EventArgs e)
        {
            product_PhotoPictureBox.Image = null;
            //product_PhotoPictureBox.Image = Image.FromFile("..\\..\\Resources\\ZAGLUSHKA.jpg");
            dbcontext.db.SaveChanges();
            MessageBox.Show("Фото сброшено");
        }
        #endregion Кнопка сброса изображений [НЕ РАБОТАЕТ, КНОПКА СКРЫТА]

        #region Кнопка выбора изображений
        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Изображения(*.bmp;*.jpg;*.png;*.JPEG)|*.BMP;*.JPG;*.PNG;*.JPEG";
            DialogResult dr = dialog.ShowDialog();

            if (dr == DialogResult.OK)
            {
                string file = dialog.FileName;
                byte[] bytes = File.ReadAllBytes(file);
                productUpData.Product_Photo = bytes;
                product_PhotoPictureBox.Image = (Image)converter.ConvertFrom(productUpData.Product_Photo);
                using (MemoryStream ms = new MemoryStream(productUpData.Product_Photo))
                {
                    product_PhotoPictureBox.Image = Image.FromStream(ms);
                }
            }
        }
        #endregion Кнопка выбора изображений

        #region Кнопка отмены
        private void CancelEditt_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mnv = new MainForm();
            mnv.Show();
        }
        #endregion Кнопка отмены
    }
}