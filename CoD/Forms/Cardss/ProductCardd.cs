using CoD.Models;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace CoD.Forms.Cardss
{
    public partial class ProductCardd : UserControl
    {
        Converter converter = new Converter();
        public ProductCardd()
        {
            InitializeComponent();
        }
        #region Генерация карточек
        public void GenerateDataProductCard(Product product)
        {
            #region Заполнение данными
            IDlabel.Text = product.Product_ID.ToString();
            productCost.Text = $"Цена: {product.Product_Cost} рублей";
            productName.Text = "Наименование: " + product.Product_Name;
            productDiscount.Text = "Скидка: " + product.Product_Discount_Percent.ToString() + "%";
            if (product.Product_Photo != null)
            {
                using (MemoryStream ms = new MemoryStream(product.Product_Photo))
                {
                    pictureBox1.Image = Image.FromStream(ms);
                }
            }
            #endregion Заполнение данными

            #region if (product.Product_Discount_Percent > 0)
            if (product.Product_Discount_Percent > 0)
            {
                productDiscount.Visible = true;
                productCostDiscount.Visible = true;

                productCostDiscount.Text = $"Цена со скидкой: {product.Product_Cost - (product.Product_Cost * product.Product_Discount_Percent / 100)} рублей";
                Font font = new Font("Calibri", 16, FontStyle.Strikeout);
                productCost.Font = font;
            }
            productQuanInStock.Text = "Кол-во на складе: " + product.Quantity_in_stock.ToString();
            productCategory.Text = "Категория: " + product.Category.Category_Name;
            #endregion if (product.Product_Discount_Percent > 0)

            #region if (AuthForm.user.User_DiscountBonus != 0)
            if (AuthForm.user.User_DiscountBonus != 0)
            {
                productCostDiscount.Visible = true;
                productDiscount.Visible = true;

                productDiscount.Text = $"Скидка: {product.Product_Discount_Percent + AuthForm.user.User_DiscountBonus}%";
                decimal cost = product.Product_Cost - (product.Product_Cost * (product.Product_Discount_Percent + AuthForm.user.User_DiscountBonus) / 100);
                productCostDiscount.Text = "Цена со скидкой: " + cost.ToString() + " рублей";
                Font font = new Font("Calibri", 16, FontStyle.Strikeout);
                productCost.Font = font;
            }
        }
        #endregion #region if (AuthForm.user.User_DiscountBonus != 0)

        #endregion Генерация карточек

        #region MouseMove and Leave
        private void ProductCardd_MouseMove(object sender, MouseEventArgs e)
        {
            BackColor = Color.LightGray;

        }

        private void ProductCardd_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.White;
        }
        #endregion MouseMove and Leave
    }
}
