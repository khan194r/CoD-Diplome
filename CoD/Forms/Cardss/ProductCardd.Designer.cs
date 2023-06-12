namespace CoD.Forms.Cardss
{
    partial class ProductCardd
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductCardd));
            this.productName = new System.Windows.Forms.Label();
            this.productQuanInStock = new System.Windows.Forms.Label();
            this.productCost = new System.Windows.Forms.Label();
            this.productDiscount = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.productCategory = new System.Windows.Forms.Label();
            this.productCostDiscount = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.IDlabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // productName
            // 
            this.productName.AutoSize = true;
            this.productName.BackColor = System.Drawing.Color.Transparent;
            this.productName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productName.Location = new System.Drawing.Point(8, 246);
            this.productName.Name = "productName";
            this.productName.Size = new System.Drawing.Size(130, 26);
            this.productName.TabIndex = 1;
            this.productName.Text = "productName";
            // 
            // productQuanInStock
            // 
            this.productQuanInStock.AutoSize = true;
            this.productQuanInStock.BackColor = System.Drawing.Color.Transparent;
            this.productQuanInStock.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productQuanInStock.Location = new System.Drawing.Point(11, 447);
            this.productQuanInStock.Name = "productQuanInStock";
            this.productQuanInStock.Size = new System.Drawing.Size(188, 26);
            this.productQuanInStock.TabIndex = 4;
            this.productQuanInStock.Text = "productQuanInStock";
            // 
            // productCost
            // 
            this.productCost.AutoSize = true;
            this.productCost.BackColor = System.Drawing.Color.Transparent;
            this.productCost.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCost.ForeColor = System.Drawing.Color.Black;
            this.productCost.Location = new System.Drawing.Point(8, 298);
            this.productCost.Name = "productCost";
            this.productCost.Size = new System.Drawing.Size(116, 26);
            this.productCost.TabIndex = 5;
            this.productCost.Text = "productCost";
            // 
            // productDiscount
            // 
            this.productDiscount.AutoSize = true;
            this.productDiscount.BackColor = System.Drawing.Color.Transparent;
            this.productDiscount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productDiscount.Location = new System.Drawing.Point(8, 350);
            this.productDiscount.Name = "productDiscount";
            this.productDiscount.Size = new System.Drawing.Size(154, 26);
            this.productDiscount.TabIndex = 6;
            this.productDiscount.Text = "productDiscount";
            this.productDiscount.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(618, 240);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // productCategory
            // 
            this.productCategory.AutoSize = true;
            this.productCategory.BackColor = System.Drawing.Color.Transparent;
            this.productCategory.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCategory.Location = new System.Drawing.Point(8, 272);
            this.productCategory.Name = "productCategory";
            this.productCategory.Size = new System.Drawing.Size(155, 26);
            this.productCategory.TabIndex = 10;
            this.productCategory.Text = "productCategory";
            // 
            // productCostDiscount
            // 
            this.productCostDiscount.AutoSize = true;
            this.productCostDiscount.BackColor = System.Drawing.Color.Transparent;
            this.productCostDiscount.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.productCostDiscount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.productCostDiscount.Location = new System.Drawing.Point(8, 324);
            this.productCostDiscount.Name = "productCostDiscount";
            this.productCostDiscount.Size = new System.Drawing.Size(191, 26);
            this.productCostDiscount.TabIndex = 11;
            this.productCostDiscount.Text = "productCostDiscount";
            this.productCostDiscount.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 476);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(624, 2);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(622, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(2, 476);
            this.panel2.TabIndex = 13;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(2, 476);
            this.panel3.TabIndex = 14;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightGray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(2, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(620, 2);
            this.panel4.TabIndex = 13;
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.BackColor = System.Drawing.Color.Transparent;
            this.IDlabel.Enabled = false;
            this.IDlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IDlabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.IDlabel.Location = new System.Drawing.Point(552, 447);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(64, 26);
            this.IDlabel.TabIndex = 15;
            this.IDlabel.Text = "label1";
            this.IDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IDlabel.Visible = false;
            // 
            // ProductCardd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.productCostDiscount);
            this.Controls.Add(this.productCategory);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.productDiscount);
            this.Controls.Add(this.productCost);
            this.Controls.Add(this.productQuanInStock);
            this.Controls.Add(this.productName);
            this.Name = "ProductCardd";
            this.Size = new System.Drawing.Size(624, 478);
            this.MouseLeave += new System.EventHandler(this.ProductCardd_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ProductCardd_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label productName;
        private System.Windows.Forms.Label productQuanInStock;
        private System.Windows.Forms.Label productCost;
        private System.Windows.Forms.Label productDiscount;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label productCategory;
        private System.Windows.Forms.Label productCostDiscount;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.Label IDlabel;
    }
}
