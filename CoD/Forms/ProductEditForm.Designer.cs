namespace CoD.Forms
{
    partial class ProductEditForm
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
            System.Windows.Forms.Label product_IDLabel;
            System.Windows.Forms.Label product_ManufactureLabel;
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label quantity_in_stockLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label product_Discount_PercentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductEditForm));
            this.product_CostTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.product_IDTextBox = new System.Windows.Forms.TextBox();
            this.product_ManufactureTextBox = new System.Windows.Forms.TextBox();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.product_PhotoPictureBox = new System.Windows.Forms.PictureBox();
            this.product_RecipeCheckBox = new System.Windows.Forms.CheckBox();
            this.quantity_in_stockTextBox = new System.Windows.Forms.TextBox();
            this.saveEditButton = new System.Windows.Forms.Button();
            this.CancelEditt = new System.Windows.Forms.Button();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.categoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.product_Discount_PercentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            product_CostLabel = new System.Windows.Forms.Label();
            product_DescriptionLabel = new System.Windows.Forms.Label();
            product_IDLabel = new System.Windows.Forms.Label();
            product_ManufactureLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            quantity_in_stockLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            product_Discount_PercentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_PhotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Discount_PercentNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // product_CostLabel
            // 
            product_CostLabel.AutoSize = true;
            product_CostLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_CostLabel.Location = new System.Drawing.Point(11, 260);
            product_CostLabel.Name = "product_CostLabel";
            product_CostLabel.Size = new System.Drawing.Size(48, 19);
            product_CostLabel.TabIndex = 3;
            product_CostLabel.Text = "Цена:";
            // 
            // product_DescriptionLabel
            // 
            product_DescriptionLabel.AutoSize = true;
            product_DescriptionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_DescriptionLabel.Location = new System.Drawing.Point(13, 394);
            product_DescriptionLabel.Name = "product_DescriptionLabel";
            product_DescriptionLabel.Size = new System.Drawing.Size(82, 19);
            product_DescriptionLabel.TabIndex = 5;
            product_DescriptionLabel.Text = "Описание:";
            // 
            // product_IDLabel
            // 
            product_IDLabel.AutoSize = true;
            product_IDLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_IDLabel.Location = new System.Drawing.Point(11, 0);
            product_IDLabel.Name = "product_IDLabel";
            product_IDLabel.Size = new System.Drawing.Size(120, 19);
            product_IDLabel.TabIndex = 9;
            product_IDLabel.Text = "Идентификатор:";
            // 
            // product_ManufactureLabel
            // 
            product_ManufactureLabel.AutoSize = true;
            product_ManufactureLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_ManufactureLabel.Location = new System.Drawing.Point(11, 104);
            product_ManufactureLabel.Name = "product_ManufactureLabel";
            product_ManufactureLabel.Size = new System.Drawing.Size(119, 19);
            product_ManufactureLabel.TabIndex = 11;
            product_ManufactureLabel.Text = "Производитель:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_NameLabel.Location = new System.Drawing.Point(11, 52);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(118, 19);
            product_NameLabel.TabIndex = 13;
            product_NameLabel.Text = "Наименование:";
            // 
            // quantity_in_stockLabel
            // 
            quantity_in_stockLabel.AutoSize = true;
            quantity_in_stockLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            quantity_in_stockLabel.Location = new System.Drawing.Point(11, 156);
            quantity_in_stockLabel.Name = "quantity_in_stockLabel";
            quantity_in_stockLabel.Size = new System.Drawing.Size(86, 19);
            quantity_in_stockLabel.TabIndex = 21;
            quantity_in_stockLabel.Text = "В наличии:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            categoryIDLabel.Location = new System.Drawing.Point(8, 208);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(373, 19);
            categoryIDLabel.TabIndex = 31;
            categoryIDLabel.Text = "Категория (Или введите название новой категории):";
            // 
            // product_Discount_PercentLabel
            // 
            product_Discount_PercentLabel.AutoSize = true;
            product_Discount_PercentLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_Discount_PercentLabel.Location = new System.Drawing.Point(8, 312);
            product_Discount_PercentLabel.Name = "product_Discount_PercentLabel";
            product_Discount_PercentLabel.Size = new System.Drawing.Size(62, 19);
            product_Discount_PercentLabel.TabIndex = 33;
            product_Discount_PercentLabel.Text = "Скидка:";
            // 
            // product_CostTextBox
            // 
            this.product_CostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Cost", true));
            this.product_CostTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_CostTextBox.Location = new System.Drawing.Point(12, 282);
            this.product_CostTextBox.Name = "product_CostTextBox";
            this.product_CostTextBox.Size = new System.Drawing.Size(329, 27);
            this.product_CostTextBox.TabIndex = 4;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(CoD.Models.Product);
            // 
            // product_DescriptionTextBox
            // 
            this.product_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Description", true));
            this.product_DescriptionTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_DescriptionTextBox.Location = new System.Drawing.Point(12, 416);
            this.product_DescriptionTextBox.Multiline = true;
            this.product_DescriptionTextBox.Name = "product_DescriptionTextBox";
            this.product_DescriptionTextBox.Size = new System.Drawing.Size(663, 109);
            this.product_DescriptionTextBox.TabIndex = 6;
            // 
            // product_IDTextBox
            // 
            this.product_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_ID", true));
            this.product_IDTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_IDTextBox.Location = new System.Drawing.Point(12, 22);
            this.product_IDTextBox.Name = "product_IDTextBox";
            this.product_IDTextBox.ReadOnly = true;
            this.product_IDTextBox.Size = new System.Drawing.Size(329, 27);
            this.product_IDTextBox.TabIndex = 10;
            // 
            // product_ManufactureTextBox
            // 
            this.product_ManufactureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Manufacture", true));
            this.product_ManufactureTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_ManufactureTextBox.Location = new System.Drawing.Point(12, 126);
            this.product_ManufactureTextBox.Name = "product_ManufactureTextBox";
            this.product_ManufactureTextBox.Size = new System.Drawing.Size(329, 27);
            this.product_ManufactureTextBox.TabIndex = 12;
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Name", true));
            this.product_NameTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_NameTextBox.Location = new System.Drawing.Point(12, 74);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(329, 27);
            this.product_NameTextBox.TabIndex = 14;
            // 
            // product_PhotoPictureBox
            // 
            this.product_PhotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.productBindingSource, "Product_Photo", true));
            this.product_PhotoPictureBox.Image = global::CoD.Properties.Resources.ZAGLUSHKA;
            this.product_PhotoPictureBox.Location = new System.Drawing.Point(386, 243);
            this.product_PhotoPictureBox.Name = "product_PhotoPictureBox";
            this.product_PhotoPictureBox.Size = new System.Drawing.Size(250, 140);
            this.product_PhotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.product_PhotoPictureBox.TabIndex = 16;
            this.product_PhotoPictureBox.TabStop = false;
            // 
            // product_RecipeCheckBox
            // 
            this.product_RecipeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "Product_Recipe", true));
            this.product_RecipeCheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_RecipeCheckBox.Location = new System.Drawing.Point(12, 367);
            this.product_RecipeCheckBox.Name = "product_RecipeCheckBox";
            this.product_RecipeCheckBox.Size = new System.Drawing.Size(328, 24);
            this.product_RecipeCheckBox.TabIndex = 18;
            this.product_RecipeCheckBox.Text = "Нужен рецепт на изготовление?";
            this.product_RecipeCheckBox.UseVisualStyleBackColor = true;
            // 
            // quantity_in_stockTextBox
            // 
            this.quantity_in_stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Quantity_in_stock", true));
            this.quantity_in_stockTextBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantity_in_stockTextBox.Location = new System.Drawing.Point(12, 178);
            this.quantity_in_stockTextBox.Name = "quantity_in_stockTextBox";
            this.quantity_in_stockTextBox.Size = new System.Drawing.Size(329, 27);
            this.quantity_in_stockTextBox.TabIndex = 22;
            // 
            // saveEditButton
            // 
            this.saveEditButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveEditButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveEditButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveEditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveEditButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveEditButton.Location = new System.Drawing.Point(12, 531);
            this.saveEditButton.Name = "saveEditButton";
            this.saveEditButton.Size = new System.Drawing.Size(150, 50);
            this.saveEditButton.TabIndex = 27;
            this.saveEditButton.Text = "Сохранить изменения";
            this.saveEditButton.UseVisualStyleBackColor = true;
            this.saveEditButton.Click += new System.EventHandler(this.saveEditButton_Click);
            // 
            // CancelEditt
            // 
            this.CancelEditt.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CancelEditt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.CancelEditt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.CancelEditt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelEditt.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CancelEditt.Location = new System.Drawing.Point(525, 531);
            this.CancelEditt.Name = "CancelEditt";
            this.CancelEditt.Size = new System.Drawing.Size(150, 50);
            this.CancelEditt.TabIndex = 28;
            this.CancelEditt.Text = "Отменить изменения";
            this.CancelEditt.UseVisualStyleBackColor = true;
            this.CancelEditt.Click += new System.EventHandler(this.CancelEditt_Click);
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(CoD.Models.Category);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(266, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 50);
            this.button1.TabIndex = 30;
            this.button1.Text = "Сбросить изображение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoryIDComboBox
            // 
            this.categoryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "CategoryID", true));
            this.categoryIDComboBox.DataSource = this.categoryBindingSource;
            this.categoryIDComboBox.DisplayMember = "Category_Name";
            this.categoryIDComboBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryIDComboBox.FormattingEnabled = true;
            this.categoryIDComboBox.Location = new System.Drawing.Point(12, 230);
            this.categoryIDComboBox.Name = "categoryIDComboBox";
            this.categoryIDComboBox.Size = new System.Drawing.Size(328, 27);
            this.categoryIDComboBox.TabIndex = 32;
            this.categoryIDComboBox.ValueMember = "Category_ID";
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(386, 383);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(250, 27);
            this.button2.TabIndex = 33;
            this.button2.Text = "Выбрать новое изображение";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // product_Discount_PercentNumericUpDown
            // 
            this.product_Discount_PercentNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "Product_Discount_Percent", true));
            this.product_Discount_PercentNumericUpDown.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_Discount_PercentNumericUpDown.Location = new System.Drawing.Point(12, 334);
            this.product_Discount_PercentNumericUpDown.Name = "product_Discount_PercentNumericUpDown";
            this.product_Discount_PercentNumericUpDown.Size = new System.Drawing.Size(329, 27);
            this.product_Discount_PercentNumericUpDown.TabIndex = 34;
            // 
            // ProductEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(687, 601);
            this.ControlBox = false;
            this.Controls.Add(product_Discount_PercentLabel);
            this.Controls.Add(this.product_Discount_PercentNumericUpDown);
            this.Controls.Add(this.button2);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(this.categoryIDComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CancelEditt);
            this.Controls.Add(this.saveEditButton);
            this.Controls.Add(product_CostLabel);
            this.Controls.Add(this.product_CostTextBox);
            this.Controls.Add(product_DescriptionLabel);
            this.Controls.Add(this.product_DescriptionTextBox);
            this.Controls.Add(product_IDLabel);
            this.Controls.Add(this.product_IDTextBox);
            this.Controls.Add(product_ManufactureLabel);
            this.Controls.Add(this.product_ManufactureTextBox);
            this.Controls.Add(product_NameLabel);
            this.Controls.Add(this.product_NameTextBox);
            this.Controls.Add(this.product_PhotoPictureBox);
            this.Controls.Add(this.product_RecipeCheckBox);
            this.Controls.Add(quantity_in_stockLabel);
            this.Controls.Add(this.quantity_in_stockTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(703, 640);
            this.MinimumSize = new System.Drawing.Size(703, 640);
            this.Name = "ProductEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Center of Dentistry - Окно редактирования товаров";
            this.Load += new System.EventHandler(this.ProductEditForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_PhotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Discount_PercentNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox product_CostTextBox;
        private System.Windows.Forms.TextBox product_DescriptionTextBox;
        private System.Windows.Forms.TextBox product_IDTextBox;
        private System.Windows.Forms.TextBox product_ManufactureTextBox;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.PictureBox product_PhotoPictureBox;
        private System.Windows.Forms.CheckBox product_RecipeCheckBox;
        private System.Windows.Forms.TextBox quantity_in_stockTextBox;
        private System.Windows.Forms.Button saveEditButton;
        private System.Windows.Forms.Button CancelEditt;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox categoryIDComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown product_Discount_PercentNumericUpDown;
    }
}