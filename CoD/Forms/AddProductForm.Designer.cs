namespace CoD.Forms
{
    partial class AddProductForm
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
            System.Windows.Forms.Label product_ManufactureLabel;
            System.Windows.Forms.Label product_NameLabel;
            System.Windows.Forms.Label quantity_in_stockLabel;
            System.Windows.Forms.Label categoryIDLabel;
            System.Windows.Forms.Label product_Discount_PercentLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProductForm));
            this.product_CostTextBox = new System.Windows.Forms.TextBox();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.product_DescriptionTextBox = new System.Windows.Forms.TextBox();
            this.product_ManufactureTextBox = new System.Windows.Forms.TextBox();
            this.product_NameTextBox = new System.Windows.Forms.TextBox();
            this.product_RecipeCheckBox = new System.Windows.Forms.CheckBox();
            this.quantity_in_stockTextBox = new System.Windows.Forms.TextBox();
            this.addproductbutton = new System.Windows.Forms.Button();
            this.cancelproductbutton = new System.Windows.Forms.Button();
            this.categoryIDComboBox = new System.Windows.Forms.ComboBox();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1ProductView = new System.Windows.Forms.PictureBox();
            this.ChooseImageButton = new System.Windows.Forms.Button();
            this.product_Discount_PercentNumericUpDown = new System.Windows.Forms.NumericUpDown();
            product_CostLabel = new System.Windows.Forms.Label();
            product_DescriptionLabel = new System.Windows.Forms.Label();
            product_ManufactureLabel = new System.Windows.Forms.Label();
            product_NameLabel = new System.Windows.Forms.Label();
            quantity_in_stockLabel = new System.Windows.Forms.Label();
            categoryIDLabel = new System.Windows.Forms.Label();
            product_Discount_PercentLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1ProductView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Discount_PercentNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // product_CostLabel
            // 
            product_CostLabel.AutoSize = true;
            product_CostLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_CostLabel.Location = new System.Drawing.Point(13, 229);
            product_CostLabel.Name = "product_CostLabel";
            product_CostLabel.Size = new System.Drawing.Size(38, 15);
            product_CostLabel.TabIndex = 3;
            product_CostLabel.Text = "Цена:";
            // 
            // product_DescriptionLabel
            // 
            product_DescriptionLabel.AutoSize = true;
            product_DescriptionLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_DescriptionLabel.Location = new System.Drawing.Point(13, 185);
            product_DescriptionLabel.Name = "product_DescriptionLabel";
            product_DescriptionLabel.Size = new System.Drawing.Size(66, 15);
            product_DescriptionLabel.TabIndex = 5;
            product_DescriptionLabel.Text = "Описание:";
            // 
            // product_ManufactureLabel
            // 
            product_ManufactureLabel.AutoSize = true;
            product_ManufactureLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_ManufactureLabel.Location = new System.Drawing.Point(12, 97);
            product_ManufactureLabel.Name = "product_ManufactureLabel";
            product_ManufactureLabel.Size = new System.Drawing.Size(96, 15);
            product_ManufactureLabel.TabIndex = 11;
            product_ManufactureLabel.Text = "Производитель:";
            // 
            // product_NameLabel
            // 
            product_NameLabel.AutoSize = true;
            product_NameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            product_NameLabel.Location = new System.Drawing.Point(12, 9);
            product_NameLabel.Name = "product_NameLabel";
            product_NameLabel.Size = new System.Drawing.Size(94, 15);
            product_NameLabel.TabIndex = 13;
            product_NameLabel.Text = "Наименование:";
            // 
            // quantity_in_stockLabel
            // 
            quantity_in_stockLabel.AutoSize = true;
            quantity_in_stockLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            quantity_in_stockLabel.Location = new System.Drawing.Point(12, 141);
            quantity_in_stockLabel.Name = "quantity_in_stockLabel";
            quantity_in_stockLabel.Size = new System.Drawing.Size(74, 15);
            quantity_in_stockLabel.TabIndex = 17;
            quantity_in_stockLabel.Text = "Количество:";
            // 
            // categoryIDLabel
            // 
            categoryIDLabel.AutoSize = true;
            categoryIDLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            categoryIDLabel.Location = new System.Drawing.Point(12, 53);
            categoryIDLabel.Name = "categoryIDLabel";
            categoryIDLabel.Size = new System.Drawing.Size(299, 15);
            categoryIDLabel.TabIndex = 24;
            categoryIDLabel.Text = "Категория (Или введите название новой категории):";
            // 
            // product_Discount_PercentLabel
            // 
            product_Discount_PercentLabel.AutoSize = true;
            product_Discount_PercentLabel.Location = new System.Drawing.Point(13, 273);
            product_Discount_PercentLabel.Name = "product_Discount_PercentLabel";
            product_Discount_PercentLabel.Size = new System.Drawing.Size(118, 13);
            product_Discount_PercentLabel.TabIndex = 27;
            product_Discount_PercentLabel.Text = "Скидка (В процентах):";
            // 
            // product_CostTextBox
            // 
            this.product_CostTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Cost", true));
            this.product_CostTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_CostTextBox.Location = new System.Drawing.Point(15, 247);
            this.product_CostTextBox.Name = "product_CostTextBox";
            this.product_CostTextBox.Size = new System.Drawing.Size(676, 23);
            this.product_CostTextBox.TabIndex = 4;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataSource = typeof(CoD.Models.Product);
            // 
            // product_DescriptionTextBox
            // 
            this.product_DescriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Description", true));
            this.product_DescriptionTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_DescriptionTextBox.Location = new System.Drawing.Point(15, 203);
            this.product_DescriptionTextBox.Name = "product_DescriptionTextBox";
            this.product_DescriptionTextBox.Size = new System.Drawing.Size(676, 23);
            this.product_DescriptionTextBox.TabIndex = 6;
            // 
            // product_ManufactureTextBox
            // 
            this.product_ManufactureTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Manufacture", true));
            this.product_ManufactureTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_ManufactureTextBox.Location = new System.Drawing.Point(15, 115);
            this.product_ManufactureTextBox.Name = "product_ManufactureTextBox";
            this.product_ManufactureTextBox.Size = new System.Drawing.Size(676, 23);
            this.product_ManufactureTextBox.TabIndex = 12;
            // 
            // product_NameTextBox
            // 
            this.product_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Product_Name", true));
            this.product_NameTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_NameTextBox.Location = new System.Drawing.Point(15, 27);
            this.product_NameTextBox.Name = "product_NameTextBox";
            this.product_NameTextBox.Size = new System.Drawing.Size(676, 23);
            this.product_NameTextBox.TabIndex = 14;
            // 
            // product_RecipeCheckBox
            // 
            this.product_RecipeCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.productBindingSource, "Product_Recipe", true));
            this.product_RecipeCheckBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.product_RecipeCheckBox.Location = new System.Drawing.Point(16, 315);
            this.product_RecipeCheckBox.Name = "product_RecipeCheckBox";
            this.product_RecipeCheckBox.Size = new System.Drawing.Size(127, 24);
            this.product_RecipeCheckBox.TabIndex = 16;
            this.product_RecipeCheckBox.Text = "Нужен рецепт";
            this.product_RecipeCheckBox.UseVisualStyleBackColor = true;
            // 
            // quantity_in_stockTextBox
            // 
            this.quantity_in_stockTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.productBindingSource, "Quantity_in_stock", true));
            this.quantity_in_stockTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quantity_in_stockTextBox.Location = new System.Drawing.Point(15, 159);
            this.quantity_in_stockTextBox.MaxLength = 3;
            this.quantity_in_stockTextBox.Name = "quantity_in_stockTextBox";
            this.quantity_in_stockTextBox.Size = new System.Drawing.Size(676, 23);
            this.quantity_in_stockTextBox.TabIndex = 18;
            this.quantity_in_stockTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantity_in_stockTextBox_KeyPress);
            // 
            // addproductbutton
            // 
            this.addproductbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addproductbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addproductbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addproductbutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addproductbutton.Location = new System.Drawing.Point(12, 536);
            this.addproductbutton.Name = "addproductbutton";
            this.addproductbutton.Size = new System.Drawing.Size(150, 75);
            this.addproductbutton.TabIndex = 23;
            this.addproductbutton.Text = "Добавить";
            this.addproductbutton.UseVisualStyleBackColor = true;
            this.addproductbutton.Click += new System.EventHandler(this.addproductbutton_Click);
            // 
            // cancelproductbutton
            // 
            this.cancelproductbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.cancelproductbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.cancelproductbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelproductbutton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelproductbutton.Location = new System.Drawing.Point(535, 536);
            this.cancelproductbutton.Name = "cancelproductbutton";
            this.cancelproductbutton.Size = new System.Drawing.Size(150, 75);
            this.cancelproductbutton.TabIndex = 24;
            this.cancelproductbutton.Text = "Отменить";
            this.cancelproductbutton.UseVisualStyleBackColor = true;
            this.cancelproductbutton.Click += new System.EventHandler(this.cancelproductbutton_Click);
            // 
            // categoryIDComboBox
            // 
            this.categoryIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.productBindingSource, "CategoryID", true));
            this.categoryIDComboBox.DataSource = this.categoryBindingSource;
            this.categoryIDComboBox.DisplayMember = "Category_Name";
            this.categoryIDComboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.categoryIDComboBox.FormattingEnabled = true;
            this.categoryIDComboBox.Location = new System.Drawing.Point(15, 71);
            this.categoryIDComboBox.Name = "categoryIDComboBox";
            this.categoryIDComboBox.Size = new System.Drawing.Size(676, 23);
            this.categoryIDComboBox.TabIndex = 25;
            this.categoryIDComboBox.ValueMember = "Category_ID";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(CoD.Models.Category);
            // 
            // pictureBox1ProductView
            // 
            this.pictureBox1ProductView.Image = global::CoD.Properties.Resources.ZAGLUSHKA;
            this.pictureBox1ProductView.Location = new System.Drawing.Point(231, 315);
            this.pictureBox1ProductView.Name = "pictureBox1ProductView";
            this.pictureBox1ProductView.Size = new System.Drawing.Size(225, 165);
            this.pictureBox1ProductView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1ProductView.TabIndex = 26;
            this.pictureBox1ProductView.TabStop = false;
            // 
            // ChooseImageButton
            // 
            this.ChooseImageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ChooseImageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ChooseImageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseImageButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChooseImageButton.Location = new System.Drawing.Point(231, 486);
            this.ChooseImageButton.Name = "ChooseImageButton";
            this.ChooseImageButton.Size = new System.Drawing.Size(225, 23);
            this.ChooseImageButton.TabIndex = 27;
            this.ChooseImageButton.Text = "Добавить фото";
            this.ChooseImageButton.UseVisualStyleBackColor = true;
            this.ChooseImageButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // product_Discount_PercentNumericUpDown
            // 
            this.product_Discount_PercentNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.productBindingSource, "Product_Discount_Percent", true));
            this.product_Discount_PercentNumericUpDown.Location = new System.Drawing.Point(16, 289);
            this.product_Discount_PercentNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.product_Discount_PercentNumericUpDown.Name = "product_Discount_PercentNumericUpDown";
            this.product_Discount_PercentNumericUpDown.Size = new System.Drawing.Size(675, 20);
            this.product_Discount_PercentNumericUpDown.TabIndex = 28;
            // 
            // AddProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(697, 623);
            this.Controls.Add(product_Discount_PercentLabel);
            this.Controls.Add(this.product_Discount_PercentNumericUpDown);
            this.Controls.Add(this.ChooseImageButton);
            this.Controls.Add(this.pictureBox1ProductView);
            this.Controls.Add(categoryIDLabel);
            this.Controls.Add(this.categoryIDComboBox);
            this.Controls.Add(this.cancelproductbutton);
            this.Controls.Add(this.addproductbutton);
            this.Controls.Add(product_CostLabel);
            this.Controls.Add(this.product_CostTextBox);
            this.Controls.Add(product_DescriptionLabel);
            this.Controls.Add(this.product_DescriptionTextBox);
            this.Controls.Add(product_ManufactureLabel);
            this.Controls.Add(this.product_ManufactureTextBox);
            this.Controls.Add(product_NameLabel);
            this.Controls.Add(this.product_NameTextBox);
            this.Controls.Add(this.product_RecipeCheckBox);
            this.Controls.Add(quantity_in_stockLabel);
            this.Controls.Add(this.quantity_in_stockTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(713, 662);
            this.MinimumSize = new System.Drawing.Size(713, 662);
            this.Name = "AddProductForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Center of Dentistry - Форма добавления товаров";
            this.Load += new System.EventHandler(this.AddProductForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1ProductView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.product_Discount_PercentNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource productBindingSource;
        private System.Windows.Forms.TextBox product_CostTextBox;
        private System.Windows.Forms.TextBox product_DescriptionTextBox;
        private System.Windows.Forms.TextBox product_ManufactureTextBox;
        private System.Windows.Forms.TextBox product_NameTextBox;
        private System.Windows.Forms.CheckBox product_RecipeCheckBox;
        private System.Windows.Forms.TextBox quantity_in_stockTextBox;
        private System.Windows.Forms.Button addproductbutton;
        private System.Windows.Forms.Button cancelproductbutton;
        private System.Windows.Forms.ComboBox categoryIDComboBox;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1ProductView;
        private System.Windows.Forms.Button ChooseImageButton;
        private System.Windows.Forms.NumericUpDown product_Discount_PercentNumericUpDown;
    }
}