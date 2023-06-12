namespace CoD.Forms
{
    partial class ProductInfoFull
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label product_CostLabel;
            System.Windows.Forms.Label product_DescriptionLabel;
            System.Windows.Forms.Label product_Discount_PercentLabel;
            System.Windows.Forms.Label product_IDLabel;
            System.Windows.Forms.Label product_ManufactureLabel;
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label product_RecipeLabel;
            System.Windows.Forms.Label quantity_in_stockLabel;
            System.Windows.Forms.Label category_IDLabel;
            System.Windows.Forms.Label category_NameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductInfoFull));
            this.product_PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_CostLabel1 = new System.Windows.Forms.Label();
            this.product_DescriptionLabel1 = new System.Windows.Forms.Label();
            this.product_Discount_PercentLabel1 = new System.Windows.Forms.Label();
            this.product_IDLabel1 = new System.Windows.Forms.Label();
            this.product_ManufactureLabel1 = new System.Windows.Forms.Label();
            this.product_NameLabel1 = new System.Windows.Forms.Label();
            this.product_RecipeLabel1 = new System.Windows.Forms.Label();
            this.quantity_in_stockLabel1 = new System.Windows.Forms.Label();
            this.category_IDLabel1 = new System.Windows.Forms.Label();
            this.category_NameLabel1 = new System.Windows.Forms.Label();
            this.closeButtonPrdctView = new System.Windows.Forms.Button();
            this.editProductBUTTOn = new System.Windows.Forms.Button();
            this.deletePRODuctBUTTOn = new System.Windows.Forms.Button();
            product_CostLabel = new System.Windows.Forms.Label();
            product_DescriptionLabel = new System.Windows.Forms.Label();
            product_Discount_PercentLabel = new System.Windows.Forms.Label();
            product_IDLabel = new System.Windows.Forms.Label();
            product_ManufactureLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            product_RecipeLabel = new System.Windows.Forms.Label();
            quantity_in_stockLabel = new System.Windows.Forms.Label();
            category_IDLabel = new System.Windows.Forms.Label();
            category_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.product_PhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // product_CostLabel
            // 
            product_CostLabel.AutoSize = true;
            product_CostLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_CostLabel.Location = new System.Drawing.Point(12, 317);
            product_CostLabel.Name = "product_CostLabel";
            product_CostLabel.Size = new System.Drawing.Size(55, 23);
            product_CostLabel.TabIndex = 17;
            product_CostLabel.Text = "Цена:";
            // 
            // product_DescriptionLabel
            // 
            product_DescriptionLabel.AutoSize = true;
            product_DescriptionLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_DescriptionLabel.Location = new System.Drawing.Point(372, 179);
            product_DescriptionLabel.Name = "product_DescriptionLabel";
            product_DescriptionLabel.Size = new System.Drawing.Size(94, 23);
            product_DescriptionLabel.TabIndex = 19;
            product_DescriptionLabel.Text = "Описание:";
            // 
            // product_Discount_PercentLabel
            // 
            product_Discount_PercentLabel.AutoSize = true;
            product_Discount_PercentLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_Discount_PercentLabel.Location = new System.Drawing.Point(12, 363);
            product_Discount_PercentLabel.Name = "product_Discount_PercentLabel";
            product_Discount_PercentLabel.Size = new System.Drawing.Size(144, 23);
            product_Discount_PercentLabel.TabIndex = 21;
            product_Discount_PercentLabel.Text = "Процент скидки:";
            // 
            // product_IDLabel
            // 
            product_IDLabel.AutoSize = true;
            product_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_IDLabel.Location = new System.Drawing.Point(477, 36);
            product_IDLabel.Name = "product_IDLabel";
            product_IDLabel.Size = new System.Drawing.Size(128, 13);
            product_IDLabel.TabIndex = 23;
            product_IDLabel.Text = "Идентификатор товара:";
            product_IDLabel.Visible = false;
            // 
            // product_ManufactureLabel
            // 
            product_ManufactureLabel.AutoSize = true;
            product_ManufactureLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_ManufactureLabel.Location = new System.Drawing.Point(12, 271);
            product_ManufactureLabel.Name = "product_ManufactureLabel";
            product_ManufactureLabel.Size = new System.Drawing.Size(139, 23);
            product_ManufactureLabel.TabIndex = 25;
            product_ManufactureLabel.Text = "Производитель:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_NameLabel.Location = new System.Drawing.Point(12, 179);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(193, 23);
            product_NameLabel.TabIndex = 27;
            product_NameLabel.Text = "Наименование товара:";
            // 
            // product_RecipeLabel
            // 
            product_RecipeLabel.AutoSize = true;
            product_RecipeLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_RecipeLabel.Location = new System.Drawing.Point(13, 455);
            product_RecipeLabel.Name = "product_RecipeLabel";
            product_RecipeLabel.Size = new System.Drawing.Size(127, 23);
            product_RecipeLabel.TabIndex = 29;
            product_RecipeLabel.Text = "Нужен рецепт:";
            // 
            // quantity_in_stockLabel
            // 
            quantity_in_stockLabel.AutoSize = true;
            quantity_in_stockLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            quantity_in_stockLabel.Location = new System.Drawing.Point(13, 409);
            quantity_in_stockLabel.Name = "quantity_in_stockLabel";
            quantity_in_stockLabel.Size = new System.Drawing.Size(192, 23);
            quantity_in_stockLabel.TabIndex = 31;
            quantity_in_stockLabel.Text = "Количество в наличии:";
            // 
            // category_IDLabel
            // 
            category_IDLabel.AutoSize = true;
            category_IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            category_IDLabel.Location = new System.Drawing.Point(477, 9);
            category_IDLabel.Name = "category_IDLabel";
            category_IDLabel.Size = new System.Drawing.Size(145, 13);
            category_IDLabel.TabIndex = 32;
            category_IDLabel.Text = "Идентификатор категории:";
            category_IDLabel.Visible = false;
            // 
            // category_NameLabel
            // 
            category_NameLabel.AutoSize = true;
            category_NameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            category_NameLabel.Location = new System.Drawing.Point(12, 225);
            category_NameLabel.Name = "category_NameLabel";
            category_NameLabel.Size = new System.Drawing.Size(220, 23);
            category_NameLabel.TabIndex = 34;
            category_NameLabel.Text = "Наименование категории:";
            // 
            // product_PhotoPictureBox
            // 
            this.product_PhotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productBindingSource, "Product_Photo", true));
            this.product_PhotoPictureBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.product_PhotoPictureBox.Image = global::CoD.Properties.Resources.ZAGLUSHKA;
            this.product_PhotoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.product_PhotoPictureBox.Name = "product_PhotoPictureBox";
            this.product_PhotoPictureBox.Size = new System.Drawing.Size(634, 176);
            this.product_PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.product_PhotoPictureBox.TabIndex = 15;
            this.product_PhotoPictureBox.TabStop = false;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(CoD.Models.Product);
            // 
            // product_CostLabel1
            // 
            this.product_CostLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Cost", true));
            this.product_CostLabel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_CostLabel1.Location = new System.Drawing.Point(12, 340);
            this.product_CostLabel1.Name = "product_CostLabel1";
            this.product_CostLabel1.Size = new System.Drawing.Size(354, 23);
            this.product_CostLabel1.TabIndex = 18;
            this.product_CostLabel1.Text = "label1";
            // 
            // product_DescriptionLabel1
            // 
            this.product_DescriptionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Description", true));
            this.product_DescriptionLabel1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_DescriptionLabel1.Location = new System.Drawing.Point(372, 202);
            this.product_DescriptionLabel1.Name = "product_DescriptionLabel1";
            this.product_DescriptionLabel1.Size = new System.Drawing.Size(250, 333);
            this.product_DescriptionLabel1.TabIndex = 20;
            this.product_DescriptionLabel1.Text = "label1";
            // 
            // product_Discount_PercentLabel1
            // 
            this.product_Discount_PercentLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Discount_Percent", true));
            this.product_Discount_PercentLabel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_Discount_PercentLabel1.Location = new System.Drawing.Point(12, 386);
            this.product_Discount_PercentLabel1.Name = "product_Discount_PercentLabel1";
            this.product_Discount_PercentLabel1.Size = new System.Drawing.Size(354, 23);
            this.product_Discount_PercentLabel1.TabIndex = 22;
            this.product_Discount_PercentLabel1.Text = "label1";
            // 
            // product_IDLabel1
            // 
            this.product_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_ID", true));
            this.product_IDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_IDLabel1.Location = new System.Drawing.Point(477, 49);
            this.product_IDLabel1.Name = "product_IDLabel1";
            this.product_IDLabel1.Size = new System.Drawing.Size(128, 23);
            this.product_IDLabel1.TabIndex = 24;
            this.product_IDLabel1.Text = "label1";
            this.product_IDLabel1.Visible = false;
            // 
            // product_ManufactureLabel1
            // 
            this.product_ManufactureLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Manufacture", true));
            this.product_ManufactureLabel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_ManufactureLabel1.Location = new System.Drawing.Point(12, 294);
            this.product_ManufactureLabel1.Name = "product_ManufactureLabel1";
            this.product_ManufactureLabel1.Size = new System.Drawing.Size(354, 23);
            this.product_ManufactureLabel1.TabIndex = 26;
            this.product_ManufactureLabel1.Text = "label1";
            // 
            // product_NameLabel1
            // 
            this.product_NameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Name", true));
            this.product_NameLabel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_NameLabel1.Location = new System.Drawing.Point(12, 202);
            this.product_NameLabel1.Name = "product_NameLabel1";
            this.product_NameLabel1.Size = new System.Drawing.Size(354, 23);
            this.product_NameLabel1.TabIndex = 28;
            this.product_NameLabel1.Text = "label1";
            // 
            // product_RecipeLabel1
            // 
            this.product_RecipeLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Recipe", true));
            this.product_RecipeLabel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_RecipeLabel1.Location = new System.Drawing.Point(13, 478);
            this.product_RecipeLabel1.Name = "product_RecipeLabel1";
            this.product_RecipeLabel1.Size = new System.Drawing.Size(353, 23);
            this.product_RecipeLabel1.TabIndex = 30;
            this.product_RecipeLabel1.Text = "label1";
            // 
            // quantity_in_stockLabel1
            // 
            this.quantity_in_stockLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Quantity_in_stock", true));
            this.quantity_in_stockLabel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantity_in_stockLabel1.Location = new System.Drawing.Point(13, 432);
            this.quantity_in_stockLabel1.Name = "quantity_in_stockLabel1";
            this.quantity_in_stockLabel1.Size = new System.Drawing.Size(353, 23);
            this.quantity_in_stockLabel1.TabIndex = 32;
            this.quantity_in_stockLabel1.Text = "label1";
            // 
            // category_IDLabel1
            // 
            this.category_IDLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Category.Category_ID", true));
            this.category_IDLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.category_IDLabel1.Location = new System.Drawing.Point(477, 22);
            this.category_IDLabel1.Name = "category_IDLabel1";
            this.category_IDLabel1.Size = new System.Drawing.Size(145, 14);
            this.category_IDLabel1.TabIndex = 33;
            this.category_IDLabel1.Text = "label1";
            this.category_IDLabel1.Visible = false;
            // 
            // category_NameLabel1
            // 
            this.category_NameLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Category.Category_Name", true));
            this.category_NameLabel1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.category_NameLabel1.Location = new System.Drawing.Point(12, 248);
            this.category_NameLabel1.Name = "category_NameLabel1";
            this.category_NameLabel1.Size = new System.Drawing.Size(354, 23);
            this.category_NameLabel1.TabIndex = 35;
            this.category_NameLabel1.Text = "label1";
            // 
            // closeButtonPrdctView
            // 
            this.closeButtonPrdctView.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closeButtonPrdctView.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.closeButtonPrdctView.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.closeButtonPrdctView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeButtonPrdctView.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButtonPrdctView.Location = new System.Drawing.Point(12, 584);
            this.closeButtonPrdctView.Name = "closeButtonPrdctView";
            this.closeButtonPrdctView.Size = new System.Drawing.Size(610, 115);
            this.closeButtonPrdctView.TabIndex = 36;
            this.closeButtonPrdctView.Text = "Закрыть";
            this.closeButtonPrdctView.UseVisualStyleBackColor = true;
            this.closeButtonPrdctView.Click += new System.EventHandler(this.button1_Click);
            // 
            // editProductBUTTOn
            // 
            this.editProductBUTTOn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.editProductBUTTOn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.editProductBUTTOn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.editProductBUTTOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProductBUTTOn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editProductBUTTOn.Location = new System.Drawing.Point(316, 538);
            this.editProductBUTTOn.Name = "editProductBUTTOn";
            this.editProductBUTTOn.Size = new System.Drawing.Size(150, 40);
            this.editProductBUTTOn.TabIndex = 41;
            this.editProductBUTTOn.Text = "Изменить товар";
            this.editProductBUTTOn.UseVisualStyleBackColor = true;
            this.editProductBUTTOn.Visible = false;
            this.editProductBUTTOn.Click += new System.EventHandler(this.editProductBUTTOn_Click);
            // 
            // deletePRODuctBUTTOn
            // 
            this.deletePRODuctBUTTOn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deletePRODuctBUTTOn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.deletePRODuctBUTTOn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.deletePRODuctBUTTOn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deletePRODuctBUTTOn.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deletePRODuctBUTTOn.Location = new System.Drawing.Point(472, 538);
            this.deletePRODuctBUTTOn.Name = "deletePRODuctBUTTOn";
            this.deletePRODuctBUTTOn.Size = new System.Drawing.Size(150, 40);
            this.deletePRODuctBUTTOn.TabIndex = 42;
            this.deletePRODuctBUTTOn.Text = "Удалить товар";
            this.deletePRODuctBUTTOn.UseVisualStyleBackColor = true;
            this.deletePRODuctBUTTOn.Visible = false;
            this.deletePRODuctBUTTOn.Click += new System.EventHandler(this.deletePRODuctBUTTOn_Click);
            // 
            // ProductInfoFull
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(634, 711);
            this.ControlBox = false;
            this.Controls.Add(this.deletePRODuctBUTTOn);
            this.Controls.Add(this.editProductBUTTOn);
            this.Controls.Add(this.closeButtonPrdctView);
            this.Controls.Add(category_IDLabel);
            this.Controls.Add(this.category_IDLabel1);
            this.Controls.Add(category_NameLabel);
            this.Controls.Add(this.category_NameLabel1);
            this.Controls.Add(product_CostLabel);
            this.Controls.Add(this.product_CostLabel1);
            this.Controls.Add(product_DescriptionLabel);
            this.Controls.Add(this.product_DescriptionLabel1);
            this.Controls.Add(product_Discount_PercentLabel);
            this.Controls.Add(this.product_Discount_PercentLabel1);
            this.Controls.Add(product_IDLabel);
            this.Controls.Add(this.product_IDLabel1);
            this.Controls.Add(product_ManufactureLabel);
            this.Controls.Add(this.product_ManufactureLabel1);
            this.Controls.Add(product_NameLabel);
            this.Controls.Add(this.product_NameLabel1);
            this.Controls.Add(product_RecipeLabel);
            this.Controls.Add(this.product_RecipeLabel1);
            this.Controls.Add(quantity_in_stockLabel);
            this.Controls.Add(this.quantity_in_stockLabel1);
            this.Controls.Add(this.product_PhotoPictureBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(650, 750);
            this.MinimumSize = new System.Drawing.Size(650, 750);
            this.Name = "ProductInfoFull";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Center of Dentistry - Окно просмотра товара";
            this.Load += new System.EventHandler(this.ProductInfoFull_Load);
            ((System.ComponentModel.ISupportInitialize)(this.product_PhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.PictureBox product_PhotoPictureBox;
        private System.Windows.Forms.Label product_CostLabel1;
        private System.Windows.Forms.Label product_DescriptionLabel1;
        private System.Windows.Forms.Label product_Discount_PercentLabel1;
        private System.Windows.Forms.Label product_IDLabel1;
        private System.Windows.Forms.Label product_ManufactureLabel1;
        private System.Windows.Forms.Label product_NameLabel1;
        private System.Windows.Forms.Label product_RecipeLabel1;
        private System.Windows.Forms.Label quantity_in_stockLabel1;
        private System.Windows.Forms.Label category_IDLabel1;
        private System.Windows.Forms.Label category_NameLabel1;
        private System.Windows.Forms.Button closeButtonPrdctView;
        private System.Windows.Forms.Button editProductBUTTOn;
        private System.Windows.Forms.Button deletePRODuctBUTTOn;
    }
}