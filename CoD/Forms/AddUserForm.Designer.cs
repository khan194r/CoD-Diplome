namespace CoD.Forms
{
    partial class AddUserForm
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
            System.Windows.Forms.Label user_DateBirthDayLabel;
            System.Windows.Forms.Label user_EmailLabel;
            System.Windows.Forms.Label user_LastNameLabel;
            System.Windows.Forms.Label user_LoginLabel;
            System.Windows.Forms.Label user_MiddleNameLabel;
            System.Windows.Forms.Label user_NameLabel;
            System.Windows.Forms.Label user_PasswordLabel;
            System.Windows.Forms.Label user_PhoneLabel;
            System.Windows.Forms.Label role_IDLabel;
            System.Windows.Forms.Label user_DiscountBonusLabel1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.user_DateBirthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_EmailTextBox = new System.Windows.Forms.TextBox();
            this.user_LastNameTextBox = new System.Windows.Forms.TextBox();
            this.user_LoginTextBox = new System.Windows.Forms.TextBox();
            this.user_MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.user_NameTextBox = new System.Windows.Forms.TextBox();
            this.user_PasswordTextBox = new System.Windows.Forms.TextBox();
            this.user_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.registryButtonSotr = new System.Windows.Forms.Button();
            this.cancelRegistryButtonSotr = new System.Windows.Forms.Button();
            this.role_IDComboBox = new System.Windows.Forms.ComboBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_DiscountBonusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            user_DateBirthDayLabel = new System.Windows.Forms.Label();
            user_EmailLabel = new System.Windows.Forms.Label();
            user_LastNameLabel = new System.Windows.Forms.Label();
            user_LoginLabel = new System.Windows.Forms.Label();
            user_MiddleNameLabel = new System.Windows.Forms.Label();
            user_NameLabel = new System.Windows.Forms.Label();
            user_PasswordLabel = new System.Windows.Forms.Label();
            user_PhoneLabel = new System.Windows.Forms.Label();
            role_IDLabel = new System.Windows.Forms.Label();
            user_DiscountBonusLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_DiscountBonusNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // user_DateBirthDayLabel
            // 
            user_DateBirthDayLabel.AutoSize = true;
            user_DateBirthDayLabel.Location = new System.Drawing.Point(12, 204);
            user_DateBirthDayLabel.Name = "user_DateBirthDayLabel";
            user_DateBirthDayLabel.Size = new System.Drawing.Size(150, 13);
            user_DateBirthDayLabel.TabIndex = 2;
            user_DateBirthDayLabel.Text = "Дата рождения сотрудника:";
            // 
            // user_EmailLabel
            // 
            user_EmailLabel.AutoSize = true;
            user_EmailLabel.Location = new System.Drawing.Point(12, 322);
            user_EmailLabel.Name = "user_EmailLabel";
            user_EmailLabel.Size = new System.Drawing.Size(192, 13);
            user_EmailLabel.TabIndex = 6;
            user_EmailLabel.Text = "Почта сотрудника (Не обязательно):";
            // 
            // user_LastNameLabel
            // 
            user_LastNameLabel.AutoSize = true;
            user_LastNameLabel.Location = new System.Drawing.Point(12, 87);
            user_LastNameLabel.Name = "user_LastNameLabel";
            user_LastNameLabel.Size = new System.Drawing.Size(120, 13);
            user_LastNameLabel.TabIndex = 10;
            user_LastNameLabel.Text = "Фамилия сотрудника:";
            // 
            // user_LoginLabel
            // 
            user_LoginLabel.AutoSize = true;
            user_LoginLabel.Location = new System.Drawing.Point(12, 9);
            user_LoginLabel.Name = "user_LoginLabel";
            user_LoginLabel.Size = new System.Drawing.Size(102, 13);
            user_LoginLabel.TabIndex = 12;
            user_LoginLabel.Text = "Логин сотрудника:";
            // 
            // user_MiddleNameLabel
            // 
            user_MiddleNameLabel.AutoSize = true;
            user_MiddleNameLabel.Location = new System.Drawing.Point(12, 165);
            user_MiddleNameLabel.Name = "user_MiddleNameLabel";
            user_MiddleNameLabel.Size = new System.Drawing.Size(209, 13);
            user_MiddleNameLabel.TabIndex = 14;
            user_MiddleNameLabel.Text = "Отчество сотрудника (Не обязательно):";
            // 
            // user_NameLabel
            // 
            user_NameLabel.AutoSize = true;
            user_NameLabel.Location = new System.Drawing.Point(12, 126);
            user_NameLabel.Name = "user_NameLabel";
            user_NameLabel.Size = new System.Drawing.Size(93, 13);
            user_NameLabel.TabIndex = 16;
            user_NameLabel.Text = "Имя сотрудника:";
            // 
            // user_PasswordLabel
            // 
            user_PasswordLabel.AutoSize = true;
            user_PasswordLabel.Location = new System.Drawing.Point(12, 48);
            user_PasswordLabel.Name = "user_PasswordLabel";
            user_PasswordLabel.Size = new System.Drawing.Size(109, 13);
            user_PasswordLabel.TabIndex = 18;
            user_PasswordLabel.Text = "Пароль сотрудника:";
            // 
            // user_PhoneLabel
            // 
            user_PhoneLabel.AutoSize = true;
            user_PhoneLabel.Location = new System.Drawing.Point(12, 283);
            user_PhoneLabel.Name = "user_PhoneLabel";
            user_PhoneLabel.Size = new System.Drawing.Size(245, 13);
            user_PhoneLabel.TabIndex = 20;
            user_PhoneLabel.Text = "Телефон сотрудника (Формат: +79999999999):";
            // 
            // role_IDLabel
            // 
            role_IDLabel.AutoSize = true;
            role_IDLabel.Location = new System.Drawing.Point(12, 243);
            role_IDLabel.Name = "role_IDLabel";
            role_IDLabel.Size = new System.Drawing.Size(129, 13);
            role_IDLabel.TabIndex = 25;
            role_IDLabel.Text = "Должность сотрудника:";
            // 
            // user_DiscountBonusLabel1
            // 
            user_DiscountBonusLabel1.AutoSize = true;
            user_DiscountBonusLabel1.Location = new System.Drawing.Point(12, 361);
            user_DiscountBonusLabel1.Name = "user_DiscountBonusLabel1";
            user_DiscountBonusLabel1.Size = new System.Drawing.Size(255, 13);
            user_DiscountBonusLabel1.TabIndex = 26;
            user_DiscountBonusLabel1.Text = "Персональная скидка сотрудника (В процентах):";
            // 
            // user_DateBirthDayDateTimePicker
            // 
            this.user_DateBirthDayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "User_DateBirthDay", true));
            this.user_DateBirthDayDateTimePicker.Location = new System.Drawing.Point(15, 220);
            this.user_DateBirthDayDateTimePicker.Name = "user_DateBirthDayDateTimePicker";
            this.user_DateBirthDayDateTimePicker.Size = new System.Drawing.Size(343, 20);
            this.user_DateBirthDayDateTimePicker.TabIndex = 3;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(CoD.Models.User);
            // 
            // user_EmailTextBox
            // 
            this.user_EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Email", true));
            this.user_EmailTextBox.Location = new System.Drawing.Point(15, 338);
            this.user_EmailTextBox.Name = "user_EmailTextBox";
            this.user_EmailTextBox.Size = new System.Drawing.Size(343, 20);
            this.user_EmailTextBox.TabIndex = 7;
            // 
            // user_LastNameTextBox
            // 
            this.user_LastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_LastName", true));
            this.user_LastNameTextBox.Location = new System.Drawing.Point(15, 103);
            this.user_LastNameTextBox.Name = "user_LastNameTextBox";
            this.user_LastNameTextBox.Size = new System.Drawing.Size(343, 20);
            this.user_LastNameTextBox.TabIndex = 11;
            this.user_LastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_LastNameTextBox_KeyPress);
            // 
            // user_LoginTextBox
            // 
            this.user_LoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Login", true));
            this.user_LoginTextBox.Location = new System.Drawing.Point(15, 25);
            this.user_LoginTextBox.Name = "user_LoginTextBox";
            this.user_LoginTextBox.Size = new System.Drawing.Size(343, 20);
            this.user_LoginTextBox.TabIndex = 13;
            // 
            // user_MiddleNameTextBox
            // 
            this.user_MiddleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_MiddleName", true));
            this.user_MiddleNameTextBox.Location = new System.Drawing.Point(15, 181);
            this.user_MiddleNameTextBox.Name = "user_MiddleNameTextBox";
            this.user_MiddleNameTextBox.Size = new System.Drawing.Size(343, 20);
            this.user_MiddleNameTextBox.TabIndex = 15;
            this.user_MiddleNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_MiddleNameTextBox_KeyPress);
            // 
            // user_NameTextBox
            // 
            this.user_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Name", true));
            this.user_NameTextBox.Location = new System.Drawing.Point(15, 142);
            this.user_NameTextBox.Name = "user_NameTextBox";
            this.user_NameTextBox.Size = new System.Drawing.Size(343, 20);
            this.user_NameTextBox.TabIndex = 17;
            this.user_NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_NameTextBox_KeyPress);
            // 
            // user_PasswordTextBox
            // 
            this.user_PasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Password", true));
            this.user_PasswordTextBox.Location = new System.Drawing.Point(15, 64);
            this.user_PasswordTextBox.Name = "user_PasswordTextBox";
            this.user_PasswordTextBox.Size = new System.Drawing.Size(343, 20);
            this.user_PasswordTextBox.TabIndex = 19;
            // 
            // user_PhoneTextBox
            // 
            this.user_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Phone", true));
            this.user_PhoneTextBox.Location = new System.Drawing.Point(15, 299);
            this.user_PhoneTextBox.MaxLength = 12;
            this.user_PhoneTextBox.Name = "user_PhoneTextBox";
            this.user_PhoneTextBox.Size = new System.Drawing.Size(343, 20);
            this.user_PhoneTextBox.TabIndex = 21;
            this.user_PhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_PhoneTextBox_KeyPress);
            // 
            // registryButtonSotr
            // 
            this.registryButtonSotr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.registryButtonSotr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.registryButtonSotr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registryButtonSotr.Location = new System.Drawing.Point(15, 403);
            this.registryButtonSotr.Name = "registryButtonSotr";
            this.registryButtonSotr.Size = new System.Drawing.Size(140, 75);
            this.registryButtonSotr.TabIndex = 24;
            this.registryButtonSotr.Text = "Зарегистрировать сотрудника";
            this.registryButtonSotr.UseVisualStyleBackColor = true;
            this.registryButtonSotr.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelRegistryButtonSotr
            // 
            this.cancelRegistryButtonSotr.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.cancelRegistryButtonSotr.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.cancelRegistryButtonSotr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelRegistryButtonSotr.Location = new System.Drawing.Point(218, 403);
            this.cancelRegistryButtonSotr.Name = "cancelRegistryButtonSotr";
            this.cancelRegistryButtonSotr.Size = new System.Drawing.Size(140, 75);
            this.cancelRegistryButtonSotr.TabIndex = 25;
            this.cancelRegistryButtonSotr.Text = "Отмена регистрации сотрудника";
            this.cancelRegistryButtonSotr.UseVisualStyleBackColor = true;
            this.cancelRegistryButtonSotr.Click += new System.EventHandler(this.button2_Click);
            // 
            // role_IDComboBox
            // 
            this.role_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.roleBindingSource, "Role_ID", true));
            this.role_IDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "RoleID", true));
            this.role_IDComboBox.DataSource = this.roleBindingSource;
            this.role_IDComboBox.DisplayMember = "Role_Name";
            this.role_IDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.role_IDComboBox.FormattingEnabled = true;
            this.role_IDComboBox.Location = new System.Drawing.Point(15, 259);
            this.role_IDComboBox.Name = "role_IDComboBox";
            this.role_IDComboBox.Size = new System.Drawing.Size(343, 21);
            this.role_IDComboBox.TabIndex = 26;
            this.role_IDComboBox.ValueMember = "Role_ID";
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(CoD.Models.Role);
            // 
            // user_DiscountBonusNumericUpDown
            // 
            this.user_DiscountBonusNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "User_DiscountBonus", true));
            this.user_DiscountBonusNumericUpDown.Location = new System.Drawing.Point(15, 377);
            this.user_DiscountBonusNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.user_DiscountBonusNumericUpDown.Name = "user_DiscountBonusNumericUpDown";
            this.user_DiscountBonusNumericUpDown.Size = new System.Drawing.Size(343, 20);
            this.user_DiscountBonusNumericUpDown.TabIndex = 27;
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(370, 486);
            this.ControlBox = false;
            this.Controls.Add(user_DiscountBonusLabel1);
            this.Controls.Add(this.user_DiscountBonusNumericUpDown);
            this.Controls.Add(role_IDLabel);
            this.Controls.Add(this.role_IDComboBox);
            this.Controls.Add(this.cancelRegistryButtonSotr);
            this.Controls.Add(this.registryButtonSotr);
            this.Controls.Add(user_DateBirthDayLabel);
            this.Controls.Add(this.user_DateBirthDayDateTimePicker);
            this.Controls.Add(user_EmailLabel);
            this.Controls.Add(this.user_EmailTextBox);
            this.Controls.Add(user_LastNameLabel);
            this.Controls.Add(this.user_LastNameTextBox);
            this.Controls.Add(user_LoginLabel);
            this.Controls.Add(this.user_LoginTextBox);
            this.Controls.Add(user_MiddleNameLabel);
            this.Controls.Add(this.user_MiddleNameTextBox);
            this.Controls.Add(user_NameLabel);
            this.Controls.Add(this.user_NameTextBox);
            this.Controls.Add(user_PasswordLabel);
            this.Controls.Add(this.user_PasswordTextBox);
            this.Controls.Add(user_PhoneLabel);
            this.Controls.Add(this.user_PhoneTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(386, 525);
            this.MinimumSize = new System.Drawing.Size(386, 525);
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Center of Dentistry - Окно добавления сотрудника";
            this.Load += new System.EventHandler(this.AddUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_DiscountBonusNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.DateTimePicker user_DateBirthDayDateTimePicker;
        private System.Windows.Forms.TextBox user_EmailTextBox;
        private System.Windows.Forms.TextBox user_LastNameTextBox;
        private System.Windows.Forms.TextBox user_LoginTextBox;
        private System.Windows.Forms.TextBox user_MiddleNameTextBox;
        private System.Windows.Forms.TextBox user_NameTextBox;
        private System.Windows.Forms.TextBox user_PasswordTextBox;
        private System.Windows.Forms.TextBox user_PhoneTextBox;
        private System.Windows.Forms.Button registryButtonSotr;
        private System.Windows.Forms.Button cancelRegistryButtonSotr;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.ComboBox role_IDComboBox;
        private System.Windows.Forms.NumericUpDown user_DiscountBonusNumericUpDown;
    }
}