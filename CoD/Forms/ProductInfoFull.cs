using CoD.Forms.Cardss;
using CoD.Models;
using CoD.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace CoD.Forms
{
    public partial class ProductInfoFull : Form
    {
        public Product productUpData {  get; set; }
        public int dent;
        public bool auto;

        #region Информация
        public ProductInfoFull()
        {
            InitializeComponent();
        }
        #endregion Информация

        #region Загрузка формы
        private void ProductInfoFull_Load(object sender, EventArgs e)
        {



            if (AuthForm.user.RoleID == 2)
            {
                editProductBUTTOn.Visible = true;
                deletePRODuctBUTTOn.Visible = true;
            }

            productBindingSource.DataSource = productUpData;
            product_RecipeLabel1.Text = productUpData.Product_Recipe_Str;
            if (productUpData.Product_Photo == null)
            product_PhotoPictureBox.ImageLocation = "..\\..\\Resources\\ZAGLUSHKA.jpg";
            product_CostLabel1.Text = productUpData.Product_Cost.ToString() + " рублей";
            product_Discount_PercentLabel1.Text = productUpData.Product_Discount_Percent.ToString() + "%";
            quantity_in_stockLabel1.Text = productUpData.Quantity_in_stock.ToString() + " шт.";
        }
        #endregion Загрузка формы

        #region Кнопка закрытия формы
        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mff = new MainForm();
            mff.auto = auto;
            mff.dent = dent;
            mff.Show();
            this.Hide();
            
        }
        #endregion Кнопка закрытия формы

        #region Кнопка удаления
        private void deletePRODuctBUTTOn_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Удалить данный товар?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                dbcontext.db.Product.Remove(productUpData);
                dbcontext.db.SaveChanges();
                MessageBox.Show("Товар " + productUpData.Product_Name + " удален!");
                this.Close();
                MainForm mf = new MainForm();
                mf.dent = 1;
                mf.Show();
               
            }
        }
        #endregion Кнопка удаления
    }
}
