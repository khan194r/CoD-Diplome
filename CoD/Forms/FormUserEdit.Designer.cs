namespace CoD.Forms
{
    partial class FormUserEdit
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
            System.Windows.Forms.Label user_IDLabel;
            System.Windows.Forms.Label user_LastNameLabel;
            System.Windows.Forms.Label user_LoginLabel;
            System.Windows.Forms.Label user_MiddleNameLabel;
            System.Windows.Forms.Label user_NameLabel;
            System.Windows.Forms.Label user_PasswordLabel;
            System.Windows.Forms.Label user_PhoneLabel;
            System.Windows.Forms.Label roleIDLabel;
            System.Windows.Forms.Label user_DiscountBonusLabel;
            System.Windows.Forms.Label role_NameLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserEdit));
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_DateBirthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.user_EmailTextBox = new System.Windows.Forms.TextBox();
            this.user_IDTextBox = new System.Windows.Forms.TextBox();
            this.user_LastNameTextBox = new System.Windows.Forms.TextBox();
            this.user_LoginTextBox = new System.Windows.Forms.TextBox();
            this.user_MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.user_NameTextBox = new System.Windows.Forms.TextBox();
            this.user_PasswordTextBox = new System.Windows.Forms.TextBox();
            this.user_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.roleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteUser = new System.Windows.Forms.Button();
            this.saveUserbb = new System.Windows.Forms.Button();
            this.roleIDComboBox = new System.Windows.Forms.ComboBox();
            this.user_DiscountBonusNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.role_NameTextBox = new System.Windows.Forms.TextBox();
            this.closedformButton = new System.Windows.Forms.Button();
            user_DateBirthDayLabel = new System.Windows.Forms.Label();
            user_EmailLabel = new System.Windows.Forms.Label();
            user_IDLabel = new System.Windows.Forms.Label();
            user_LastNameLabel = new System.Windows.Forms.Label();
            user_LoginLabel = new System.Windows.Forms.Label();
            user_MiddleNameLabel = new System.Windows.Forms.Label();
            user_NameLabel = new System.Windows.Forms.Label();
            user_PasswordLabel = new System.Windows.Forms.Label();
            user_PhoneLabel = new System.Windows.Forms.Label();
            roleIDLabel = new System.Windows.Forms.Label();
            user_DiscountBonusLabel = new System.Windows.Forms.Label();
            role_NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_DiscountBonusNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // user_DateBirthDayLabel
            // 
            user_DateBirthDayLabel.AutoSize = true;
            user_DateBirthDayLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_DateBirthDayLabel.Location = new System.Drawing.Point(22, 251);
            user_DateBirthDayLabel.Name = "user_DateBirthDayLabel";
            user_DateBirthDayLabel.Size = new System.Drawing.Size(138, 23);
            user_DateBirthDayLabel.TabIndex = 3;
            user_DateBirthDayLabel.Text = "Дата рождения:";
            // 
            // user_EmailLabel
            // 
            user_EmailLabel.AutoSize = true;
            user_EmailLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_EmailLabel.Location = new System.Drawing.Point(38, 286);
            user_EmailLabel.Name = "user_EmailLabel";
            user_EmailLabel.Size = new System.Drawing.Size(62, 23);
            user_EmailLabel.TabIndex = 7;
            user_EmailLabel.Text = "Почта:";
            // 
            // user_IDLabel
            // 
            user_IDLabel.AutoSize = true;
            user_IDLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_IDLabel.Location = new System.Drawing.Point(12, 9);
            user_IDLabel.Name = "user_IDLabel";
            user_IDLabel.Size = new System.Drawing.Size(97, 15);
            user_IDLabel.TabIndex = 9;
            user_IDLabel.Text = "Идентификатор:";
            // 
            // user_LastNameLabel
            // 
            user_LastNameLabel.AutoSize = true;
            user_LastNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_LastNameLabel.Location = new System.Drawing.Point(11, 137);
            user_LastNameLabel.Name = "user_LastNameLabel";
            user_LastNameLabel.Size = new System.Drawing.Size(89, 23);
            user_LastNameLabel.TabIndex = 11;
            user_LastNameLabel.Text = "Фамилия:";
            // 
            // user_LoginLabel
            // 
            user_LoginLabel.AutoSize = true;
            user_LoginLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_LoginLabel.Location = new System.Drawing.Point(36, 363);
            user_LoginLabel.Name = "user_LoginLabel";
            user_LoginLabel.Size = new System.Drawing.Size(64, 23);
            user_LoginLabel.TabIndex = 13;
            user_LoginLabel.Text = "Логин:";
            // 
            // user_MiddleNameLabel
            // 
            user_MiddleNameLabel.AutoSize = true;
            user_MiddleNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_MiddleNameLabel.Location = new System.Drawing.Point(13, 211);
            user_MiddleNameLabel.Name = "user_MiddleNameLabel";
            user_MiddleNameLabel.Size = new System.Drawing.Size(87, 23);
            user_MiddleNameLabel.TabIndex = 15;
            user_MiddleNameLabel.Text = "Отчество:";
            // 
            // user_NameLabel
            // 
            user_NameLabel.AutoSize = true;
            user_NameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_NameLabel.Location = new System.Drawing.Point(51, 174);
            user_NameLabel.Name = "user_NameLabel";
            user_NameLabel.Size = new System.Drawing.Size(49, 23);
            user_NameLabel.TabIndex = 17;
            user_NameLabel.Text = "Имя:";
            // 
            // user_PasswordLabel
            // 
            user_PasswordLabel.AutoSize = true;
            user_PasswordLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_PasswordLabel.Location = new System.Drawing.Point(25, 400);
            user_PasswordLabel.Name = "user_PasswordLabel";
            user_PasswordLabel.Size = new System.Drawing.Size(75, 23);
            user_PasswordLabel.TabIndex = 19;
            user_PasswordLabel.Text = "Пароль:";
            // 
            // user_PhoneLabel
            // 
            user_PhoneLabel.AutoSize = true;
            user_PhoneLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_PhoneLabel.Location = new System.Drawing.Point(18, 326);
            user_PhoneLabel.Name = "user_PhoneLabel";
            user_PhoneLabel.Size = new System.Drawing.Size(82, 23);
            user_PhoneLabel.TabIndex = 21;
            user_PhoneLabel.Text = "Телефон:";
            // 
            // roleIDLabel
            // 
            roleIDLabel.AutoSize = true;
            roleIDLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            roleIDLabel.Location = new System.Drawing.Point(12, 67);
            roleIDLabel.Name = "roleIDLabel";
            roleIDLabel.Size = new System.Drawing.Size(97, 15);
            roleIDLabel.TabIndex = 31;
            roleIDLabel.Text = "Изменить роль: ";
            // 
            // user_DiscountBonusLabel
            // 
            user_DiscountBonusLabel.AutoSize = true;
            user_DiscountBonusLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_DiscountBonusLabel.Location = new System.Drawing.Point(52, 436);
            user_DiscountBonusLabel.Name = "user_DiscountBonusLabel";
            user_DiscountBonusLabel.Size = new System.Drawing.Size(108, 23);
            user_DiscountBonusLabel.TabIndex = 32;
            user_DiscountBonusLabel.Text = "Доп.скидка:";
            // 
            // role_NameLabel
            // 
            role_NameLabel.AutoSize = true;
            role_NameLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            role_NameLabel.Location = new System.Drawing.Point(23, 38);
            role_NameLabel.Name = "role_NameLabel";
            role_NameLabel.Size = new System.Drawing.Size(86, 15);
            role_NameLabel.TabIndex = 33;
            role_NameLabel.Text = "Текущая роль:";
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(CoD.Models.User);
            // 
            // user_DateBirthDayDateTimePicker
            // 
            this.user_DateBirthDayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "User_DateBirthDay", true));
            this.user_DateBirthDayDateTimePicker.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_DateBirthDayDateTimePicker.Location = new System.Drawing.Point(166, 245);
            this.user_DateBirthDayDateTimePicker.Name = "user_DateBirthDayDateTimePicker";
            this.user_DateBirthDayDateTimePicker.Size = new System.Drawing.Size(252, 31);
            this.user_DateBirthDayDateTimePicker.TabIndex = 4;
            // 
            // user_EmailTextBox
            // 
            this.user_EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Email", true));
            this.user_EmailTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_EmailTextBox.Location = new System.Drawing.Point(106, 283);
            this.user_EmailTextBox.Name = "user_EmailTextBox";
            this.user_EmailTextBox.Size = new System.Drawing.Size(312, 31);
            this.user_EmailTextBox.TabIndex = 8;
            // 
            // user_IDTextBox
            // 
            this.user_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_ID", true));
            this.user_IDTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_IDTextBox.Location = new System.Drawing.Point(115, 6);
            this.user_IDTextBox.Name = "user_IDTextBox";
            this.user_IDTextBox.ReadOnly = true;
            this.user_IDTextBox.Size = new System.Drawing.Size(303, 23);
            this.user_IDTextBox.TabIndex = 10;
            // 
            // user_LastNameTextBox
            // 
            this.user_LastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_LastName", true));
            this.user_LastNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_LastNameTextBox.Location = new System.Drawing.Point(106, 134);
            this.user_LastNameTextBox.Name = "user_LastNameTextBox";
            this.user_LastNameTextBox.Size = new System.Drawing.Size(312, 31);
            this.user_LastNameTextBox.TabIndex = 12;
            // 
            // user_LoginTextBox
            // 
            this.user_LoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Login", true));
            this.user_LoginTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_LoginTextBox.Location = new System.Drawing.Point(106, 360);
            this.user_LoginTextBox.Name = "user_LoginTextBox";
            this.user_LoginTextBox.Size = new System.Drawing.Size(312, 31);
            this.user_LoginTextBox.TabIndex = 14;
            // 
            // user_MiddleNameTextBox
            // 
            this.user_MiddleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_MiddleName", true));
            this.user_MiddleNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_MiddleNameTextBox.Location = new System.Drawing.Point(106, 208);
            this.user_MiddleNameTextBox.Name = "user_MiddleNameTextBox";
            this.user_MiddleNameTextBox.Size = new System.Drawing.Size(312, 31);
            this.user_MiddleNameTextBox.TabIndex = 16;
            // 
            // user_NameTextBox
            // 
            this.user_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Name", true));
            this.user_NameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_NameTextBox.Location = new System.Drawing.Point(106, 171);
            this.user_NameTextBox.Name = "user_NameTextBox";
            this.user_NameTextBox.Size = new System.Drawing.Size(312, 31);
            this.user_NameTextBox.TabIndex = 18;
            // 
            // user_PasswordTextBox
            // 
            this.user_PasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Password", true));
            this.user_PasswordTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_PasswordTextBox.Location = new System.Drawing.Point(106, 397);
            this.user_PasswordTextBox.Name = "user_PasswordTextBox";
            this.user_PasswordTextBox.Size = new System.Drawing.Size(312, 31);
            this.user_PasswordTextBox.TabIndex = 20;
            // 
            // user_PhoneTextBox
            // 
            this.user_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Phone", true));
            this.user_PhoneTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_PhoneTextBox.Location = new System.Drawing.Point(106, 323);
            this.user_PhoneTextBox.Name = "user_PhoneTextBox";
            this.user_PhoneTextBox.Size = new System.Drawing.Size(312, 31);
            this.user_PhoneTextBox.TabIndex = 22;
            // 
            // roleBindingSource
            // 
            this.roleBindingSource.DataSource = typeof(CoD.Models.Role);
            // 
            // deleteUser
            // 
            this.deleteUser.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.deleteUser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.deleteUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.deleteUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteUser.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteUser.Location = new System.Drawing.Point(218, 522);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(200, 65);
            this.deleteUser.TabIndex = 30;
            this.deleteUser.Text = "Удалить пользователя";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // saveUserbb
            // 
            this.saveUserbb.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.saveUserbb.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveUserbb.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.saveUserbb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveUserbb.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveUserbb.Location = new System.Drawing.Point(12, 522);
            this.saveUserbb.Name = "saveUserbb";
            this.saveUserbb.Size = new System.Drawing.Size(200, 65);
            this.saveUserbb.TabIndex = 31;
            this.saveUserbb.Text = "Сохранить изменения";
            this.saveUserbb.UseVisualStyleBackColor = true;
            this.saveUserbb.Click += new System.EventHandler(this.saveUserbb_Click);
            // 
            // roleIDComboBox
            // 
            this.roleIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "RoleID", true));
            this.roleIDComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.userBindingSource, "RoleID", true));
            this.roleIDComboBox.DataSource = this.roleBindingSource;
            this.roleIDComboBox.DisplayMember = "Role_Name";
            this.roleIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.roleIDComboBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.roleIDComboBox.FormattingEnabled = true;
            this.roleIDComboBox.Location = new System.Drawing.Point(115, 64);
            this.roleIDComboBox.Name = "roleIDComboBox";
            this.roleIDComboBox.Size = new System.Drawing.Size(303, 23);
            this.roleIDComboBox.TabIndex = 32;
            this.roleIDComboBox.ValueMember = "Role_ID";
            // 
            // user_DiscountBonusNumericUpDown
            // 
            this.user_DiscountBonusNumericUpDown.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "User_DiscountBonus", true));
            this.user_DiscountBonusNumericUpDown.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_DiscountBonusNumericUpDown.Location = new System.Drawing.Point(166, 434);
            this.user_DiscountBonusNumericUpDown.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.user_DiscountBonusNumericUpDown.Name = "user_DiscountBonusNumericUpDown";
            this.user_DiscountBonusNumericUpDown.Size = new System.Drawing.Size(252, 31);
            this.user_DiscountBonusNumericUpDown.TabIndex = 33;
            // 
            // role_NameTextBox
            // 
            this.role_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "Role.Role_Name", true));
            this.role_NameTextBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.role_NameTextBox.Location = new System.Drawing.Point(115, 35);
            this.role_NameTextBox.Name = "role_NameTextBox";
            this.role_NameTextBox.ReadOnly = true;
            this.role_NameTextBox.Size = new System.Drawing.Size(303, 23);
            this.role_NameTextBox.TabIndex = 37;
            // 
            // closedformButton
            // 
            this.closedformButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.closedformButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Brown;
            this.closedformButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Brown;
            this.closedformButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedformButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closedformButton.Location = new System.Drawing.Point(12, 593);
            this.closedformButton.Name = "closedformButton";
            this.closedformButton.Size = new System.Drawing.Size(406, 35);
            this.closedformButton.TabIndex = 38;
            this.closedformButton.Text = "Закрыть окно";
            this.closedformButton.UseVisualStyleBackColor = true;
            this.closedformButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(433, 640);
            this.ControlBox = false;
            this.Controls.Add(this.closedformButton);
            this.Controls.Add(this.role_NameTextBox);
            this.Controls.Add(role_NameLabel);
            this.Controls.Add(user_DiscountBonusLabel);
            this.Controls.Add(this.user_DiscountBonusNumericUpDown);
            this.Controls.Add(roleIDLabel);
            this.Controls.Add(this.roleIDComboBox);
            this.Controls.Add(this.saveUserbb);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(user_DateBirthDayLabel);
            this.Controls.Add(this.user_DateBirthDayDateTimePicker);
            this.Controls.Add(user_EmailLabel);
            this.Controls.Add(this.user_EmailTextBox);
            this.Controls.Add(user_IDLabel);
            this.Controls.Add(this.user_IDTextBox);
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
            this.MaximumSize = new System.Drawing.Size(449, 679);
            this.MinimumSize = new System.Drawing.Size(449, 679);
            this.Name = "FormUserEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Center of Dentistry - Окно редактирования пользователей";
            this.Load += new System.EventHandler(this.FormUserEdit_Load);
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
        private System.Windows.Forms.TextBox user_IDTextBox;
        private System.Windows.Forms.TextBox user_LastNameTextBox;
        private System.Windows.Forms.TextBox user_LoginTextBox;
        private System.Windows.Forms.TextBox user_MiddleNameTextBox;
        private System.Windows.Forms.TextBox user_NameTextBox;
        private System.Windows.Forms.TextBox user_PasswordTextBox;
        private System.Windows.Forms.TextBox user_PhoneTextBox;
        private System.Windows.Forms.BindingSource roleBindingSource;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button saveUserbb;
        private System.Windows.Forms.ComboBox roleIDComboBox;
        private System.Windows.Forms.NumericUpDown user_DiscountBonusNumericUpDown;
        private System.Windows.Forms.TextBox role_NameTextBox;
        private System.Windows.Forms.Button closedformButton;
    }
}