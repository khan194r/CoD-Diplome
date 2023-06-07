namespace CoD
{
    partial class MainForm
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.administratorPanelButton = new System.Windows.Forms.Button();
            this.yourRole = new System.Windows.Forms.Label();
            this.personalDiscountLabel = new System.Windows.Forms.Label();
            this.buttonLogoutMain = new System.Windows.Forms.Button();
            this.FIOlabel = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.SORTcombobox = new System.Windows.Forms.ComboBox();
            this.CATEGORYcombobox = new System.Windows.Forms.ComboBox();
            this.searchTextBoxMAIN = new System.Windows.Forms.TextBox();
            this.registryButtonMain = new System.Windows.Forms.Button();
            this.AuthButtonMain = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.timer60sec = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.administratorPanelButton);
            this.panel1.Controls.Add(this.yourRole);
            this.panel1.Controls.Add(this.personalDiscountLabel);
            this.panel1.Controls.Add(this.buttonLogoutMain);
            this.panel1.Controls.Add(this.FIOlabel);
            this.panel1.Controls.Add(this.labelDate);
            this.panel1.Controls.Add(this.labelTime);
            this.panel1.Controls.Add(this.SORTcombobox);
            this.panel1.Controls.Add(this.CATEGORYcombobox);
            this.panel1.Controls.Add(this.searchTextBoxMAIN);
            this.panel1.Controls.Add(this.registryButtonMain);
            this.panel1.Controls.Add(this.AuthButtonMain);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1924, 196);
            this.panel1.TabIndex = 0;
            // 
            // administratorPanelButton
            // 
            this.administratorPanelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.administratorPanelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.administratorPanelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.administratorPanelButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.administratorPanelButton.Location = new System.Drawing.Point(1766, 12);
            this.administratorPanelButton.Name = "administratorPanelButton";
            this.administratorPanelButton.Size = new System.Drawing.Size(146, 40);
            this.administratorPanelButton.TabIndex = 15;
            this.administratorPanelButton.Text = "Панель администратора";
            this.administratorPanelButton.UseVisualStyleBackColor = true;
            this.administratorPanelButton.Visible = false;
            this.administratorPanelButton.Click += new System.EventHandler(this.administratorPanelButton_Click);
            // 
            // yourRole
            // 
            this.yourRole.AutoSize = true;
            this.yourRole.Font = new System.Drawing.Font("Calibri", 14.25F);
            this.yourRole.Location = new System.Drawing.Point(1130, 35);
            this.yourRole.Name = "yourRole";
            this.yourRole.Size = new System.Drawing.Size(49, 23);
            this.yourRole.TabIndex = 13;
            this.yourRole.Text = "Роль";
            this.yourRole.Visible = false;
            // 
            // personalDiscountLabel
            // 
            this.personalDiscountLabel.AutoSize = true;
            this.personalDiscountLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.personalDiscountLabel.Location = new System.Drawing.Point(1130, 58);
            this.personalDiscountLabel.Name = "personalDiscountLabel";
            this.personalDiscountLabel.Size = new System.Drawing.Size(145, 23);
            this.personalDiscountLabel.TabIndex = 10;
            this.personalDiscountLabel.Text = "PersonalDiscount";
            this.personalDiscountLabel.Visible = false;
            // 
            // buttonLogoutMain
            // 
            this.buttonLogoutMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.buttonLogoutMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.buttonLogoutMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogoutMain.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogoutMain.Location = new System.Drawing.Point(877, 12);
            this.buttonLogoutMain.Name = "buttonLogoutMain";
            this.buttonLogoutMain.Size = new System.Drawing.Size(247, 110);
            this.buttonLogoutMain.TabIndex = 9;
            this.buttonLogoutMain.Text = "Выход";
            this.buttonLogoutMain.UseVisualStyleBackColor = true;
            this.buttonLogoutMain.Visible = false;
            this.buttonLogoutMain.Click += new System.EventHandler(this.button3_Click);
            // 
            // FIOlabel
            // 
            this.FIOlabel.AutoSize = true;
            this.FIOlabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FIOlabel.Location = new System.Drawing.Point(1130, 12);
            this.FIOlabel.Name = "FIOlabel";
            this.FIOlabel.Size = new System.Drawing.Size(48, 23);
            this.FIOlabel.TabIndex = 8;
            this.FIOlabel.Text = "ФИО";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(3, 42);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(84, 33);
            this.labelDate.TabIndex = 7;
            this.labelDate.Text = "Число";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTime.Location = new System.Drawing.Point(3, 9);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(88, 33);
            this.labelTime.TabIndex = 6;
            this.labelTime.Text = "Время";
            // 
            // SORTcombobox
            // 
            this.SORTcombobox.BackColor = System.Drawing.Color.White;
            this.SORTcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SORTcombobox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SORTcombobox.FormattingEnabled = true;
            this.SORTcombobox.Items.AddRange(new object[] {
            "Без сортировки",
            "Сортировка от А до Я",
            "Сортировка от Я до А",
            "Стоимость по возрастанию",
            "Стоимость по убыванию"});
            this.SORTcombobox.Location = new System.Drawing.Point(1015, 152);
            this.SORTcombobox.Name = "SORTcombobox";
            this.SORTcombobox.Size = new System.Drawing.Size(500, 41);
            this.SORTcombobox.TabIndex = 5;
            this.SORTcombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // CATEGORYcombobox
            // 
            this.CATEGORYcombobox.BackColor = System.Drawing.Color.White;
            this.CATEGORYcombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CATEGORYcombobox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CATEGORYcombobox.FormattingEnabled = true;
            this.CATEGORYcombobox.Location = new System.Drawing.Point(509, 153);
            this.CATEGORYcombobox.Name = "CATEGORYcombobox";
            this.CATEGORYcombobox.Size = new System.Drawing.Size(500, 41);
            this.CATEGORYcombobox.TabIndex = 4;
            this.CATEGORYcombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // searchTextBoxMAIN
            // 
            this.searchTextBoxMAIN.BackColor = System.Drawing.Color.White;
            this.searchTextBoxMAIN.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.searchTextBoxMAIN.Location = new System.Drawing.Point(3, 153);
            this.searchTextBoxMAIN.Name = "searchTextBoxMAIN";
            this.searchTextBoxMAIN.Size = new System.Drawing.Size(500, 40);
            this.searchTextBoxMAIN.TabIndex = 3;
            this.searchTextBoxMAIN.Text = "Введите для поиска по наименованию...";
            this.searchTextBoxMAIN.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.searchTextBoxMAIN.Enter += new System.EventHandler(this.textBox1_Enter);
            this.searchTextBoxMAIN.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // registryButtonMain
            // 
            this.registryButtonMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PaleTurquoise;
            this.registryButtonMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.PaleTurquoise;
            this.registryButtonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registryButtonMain.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registryButtonMain.Location = new System.Drawing.Point(624, 12);
            this.registryButtonMain.Name = "registryButtonMain";
            this.registryButtonMain.Size = new System.Drawing.Size(247, 110);
            this.registryButtonMain.TabIndex = 1;
            this.registryButtonMain.Text = "Регистрация";
            this.registryButtonMain.UseVisualStyleBackColor = true;
            this.registryButtonMain.Click += new System.EventHandler(this.button2_Click);
            // 
            // AuthButtonMain
            // 
            this.AuthButtonMain.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AuthButtonMain.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.AuthButtonMain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AuthButtonMain.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AuthButtonMain.Location = new System.Drawing.Point(371, 12);
            this.AuthButtonMain.Name = "AuthButtonMain";
            this.AuthButtonMain.Size = new System.Drawing.Size(247, 110);
            this.AuthButtonMain.TabIndex = 0;
            this.AuthButtonMain.Text = "Авторизация";
            this.AuthButtonMain.UseVisualStyleBackColor = true;
            this.AuthButtonMain.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flowLayoutPanel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1924, 803);
            this.panel2.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1924, 803);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // timer60sec
            // 
            this.timer60sec.Enabled = true;
            this.timer60sec.Tick += new System.EventHandler(this.timer60sec_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 999);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1918, 1038);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Center of Dentistry - Главное окно товаров";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox SORTcombobox;
        private System.Windows.Forms.ComboBox CATEGORYcombobox;
        private System.Windows.Forms.TextBox searchTextBoxMAIN;
        private System.Windows.Forms.Button registryButtonMain;
        private System.Windows.Forms.Button AuthButtonMain;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Timer timer60sec;
        private System.Windows.Forms.Label FIOlabel;
        private System.Windows.Forms.Button buttonLogoutMain;
        private System.Windows.Forms.Label personalDiscountLabel;
        private System.Windows.Forms.Label yourRole;
        private System.Windows.Forms.Button administratorPanelButton;
    }
}

