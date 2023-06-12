namespace CoD.Forms
{
    partial class Registry
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registry));
            this.user_DateBirthDayDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.user_EmailTextBox = new System.Windows.Forms.TextBox();
            this.user_LastNameTextBox = new System.Windows.Forms.TextBox();
            this.user_LoginTextBox = new System.Windows.Forms.TextBox();
            this.user_MiddleNameTextBox = new System.Windows.Forms.TextBox();
            this.user_NameTextBox = new System.Windows.Forms.TextBox();
            this.user_PasswordTextBox = new System.Windows.Forms.TextBox();
            this.user_PhoneTextBox = new System.Windows.Forms.TextBox();
            this.Registrbutton = new System.Windows.Forms.Button();
            this.cancelRegistryButton = new System.Windows.Forms.Button();
            user_DateBirthDayLabel = new System.Windows.Forms.Label();
            user_EmailLabel = new System.Windows.Forms.Label();
            user_LastNameLabel = new System.Windows.Forms.Label();
            user_LoginLabel = new System.Windows.Forms.Label();
            user_MiddleNameLabel = new System.Windows.Forms.Label();
            user_NameLabel = new System.Windows.Forms.Label();
            user_PasswordLabel = new System.Windows.Forms.Label();
            user_PhoneLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // user_DateBirthDayLabel
            // 
            user_DateBirthDayLabel.AutoSize = true;
            user_DateBirthDayLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_DateBirthDayLabel.Location = new System.Drawing.Point(9, 303);
            user_DateBirthDayLabel.Name = "user_DateBirthDayLabel";
            user_DateBirthDayLabel.Size = new System.Drawing.Size(138, 23);
            user_DateBirthDayLabel.TabIndex = 1;
            user_DateBirthDayLabel.Text = "Дата рождения:";
            // 
            // user_EmailLabel
            // 
            user_EmailLabel.AutoSize = true;
            user_EmailLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_EmailLabel.Location = new System.Drawing.Point(9, 423);
            user_EmailLabel.Name = "user_EmailLabel";
            user_EmailLabel.Size = new System.Drawing.Size(202, 23);
            user_EmailLabel.TabIndex = 3;
            user_EmailLabel.Text = "Почта (не обязательно):";
            // 
            // user_LastNameLabel
            // 
            user_LastNameLabel.AutoSize = true;
            user_LastNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_LastNameLabel.Location = new System.Drawing.Point(8, 123);
            user_LastNameLabel.Name = "user_LastNameLabel";
            user_LastNameLabel.Size = new System.Drawing.Size(89, 23);
            user_LastNameLabel.TabIndex = 7;
            user_LastNameLabel.Text = "Фамилия:";
            // 
            // user_LoginLabel
            // 
            user_LoginLabel.AutoSize = true;
            user_LoginLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_LoginLabel.Location = new System.Drawing.Point(12, 3);
            user_LoginLabel.Name = "user_LoginLabel";
            user_LoginLabel.Size = new System.Drawing.Size(64, 23);
            user_LoginLabel.TabIndex = 9;
            user_LoginLabel.Text = "Логин:";
            // 
            // user_MiddleNameLabel
            // 
            user_MiddleNameLabel.AutoSize = true;
            user_MiddleNameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_MiddleNameLabel.Location = new System.Drawing.Point(9, 243);
            user_MiddleNameLabel.Name = "user_MiddleNameLabel";
            user_MiddleNameLabel.Size = new System.Drawing.Size(229, 23);
            user_MiddleNameLabel.TabIndex = 11;
            user_MiddleNameLabel.Text = "Отчество (Не обязательно):";
            // 
            // user_NameLabel
            // 
            user_NameLabel.AutoSize = true;
            user_NameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_NameLabel.Location = new System.Drawing.Point(12, 183);
            user_NameLabel.Name = "user_NameLabel";
            user_NameLabel.Size = new System.Drawing.Size(49, 23);
            user_NameLabel.TabIndex = 13;
            user_NameLabel.Text = "Имя:";
            // 
            // user_PasswordLabel
            // 
            user_PasswordLabel.AutoSize = true;
            user_PasswordLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_PasswordLabel.Location = new System.Drawing.Point(9, 63);
            user_PasswordLabel.Name = "user_PasswordLabel";
            user_PasswordLabel.Size = new System.Drawing.Size(75, 23);
            user_PasswordLabel.TabIndex = 15;
            user_PasswordLabel.Text = "Пароль:";
            // 
            // user_PhoneLabel
            // 
            user_PhoneLabel.AutoSize = true;
            user_PhoneLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            user_PhoneLabel.Location = new System.Drawing.Point(9, 363);
            user_PhoneLabel.Name = "user_PhoneLabel";
            user_PhoneLabel.Size = new System.Drawing.Size(288, 23);
            user_PhoneLabel.TabIndex = 17;
            user_PhoneLabel.Text = "Телефон (Формат: +79999999999):";
            // 
            // user_DateBirthDayDateTimePicker
            // 
            this.user_DateBirthDayDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.userBindingSource, "User_DateBirthDay", true));
            this.user_DateBirthDayDateTimePicker.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_DateBirthDayDateTimePicker.Location = new System.Drawing.Point(12, 329);
            this.user_DateBirthDayDateTimePicker.Name = "user_DateBirthDayDateTimePicker";
            this.user_DateBirthDayDateTimePicker.Size = new System.Drawing.Size(510, 31);
            this.user_DateBirthDayDateTimePicker.TabIndex = 2;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(CoD.Models.User);
            // 
            // user_EmailTextBox
            // 
            this.user_EmailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Email", true));
            this.user_EmailTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_EmailTextBox.Location = new System.Drawing.Point(12, 449);
            this.user_EmailTextBox.Name = "user_EmailTextBox";
            this.user_EmailTextBox.Size = new System.Drawing.Size(510, 31);
            this.user_EmailTextBox.TabIndex = 4;
            // 
            // user_LastNameTextBox
            // 
            this.user_LastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_LastName", true));
            this.user_LastNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_LastNameTextBox.Location = new System.Drawing.Point(12, 149);
            this.user_LastNameTextBox.Name = "user_LastNameTextBox";
            this.user_LastNameTextBox.Size = new System.Drawing.Size(510, 31);
            this.user_LastNameTextBox.TabIndex = 8;
            this.user_LastNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_LastNameTextBox_KeyPress);
            // 
            // user_LoginTextBox
            // 
            this.user_LoginTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Login", true));
            this.user_LoginTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_LoginTextBox.Location = new System.Drawing.Point(12, 29);
            this.user_LoginTextBox.Name = "user_LoginTextBox";
            this.user_LoginTextBox.Size = new System.Drawing.Size(510, 31);
            this.user_LoginTextBox.TabIndex = 10;
            // 
            // user_MiddleNameTextBox
            // 
            this.user_MiddleNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_MiddleName", true));
            this.user_MiddleNameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_MiddleNameTextBox.Location = new System.Drawing.Point(12, 269);
            this.user_MiddleNameTextBox.Name = "user_MiddleNameTextBox";
            this.user_MiddleNameTextBox.Size = new System.Drawing.Size(510, 31);
            this.user_MiddleNameTextBox.TabIndex = 12;
            this.user_MiddleNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_MiddleNameTextBox_KeyPress);
            // 
            // user_NameTextBox
            // 
            this.user_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Name", true));
            this.user_NameTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_NameTextBox.Location = new System.Drawing.Point(13, 209);
            this.user_NameTextBox.Name = "user_NameTextBox";
            this.user_NameTextBox.Size = new System.Drawing.Size(510, 31);
            this.user_NameTextBox.TabIndex = 14;
            this.user_NameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_NameTextBox_KeyPress);
            // 
            // user_PasswordTextBox
            // 
            this.user_PasswordTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Password", true));
            this.user_PasswordTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_PasswordTextBox.Location = new System.Drawing.Point(12, 89);
            this.user_PasswordTextBox.Name = "user_PasswordTextBox";
            this.user_PasswordTextBox.Size = new System.Drawing.Size(510, 31);
            this.user_PasswordTextBox.TabIndex = 16;
            // 
            // user_PhoneTextBox
            // 
            this.user_PhoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.userBindingSource, "User_Phone", true));
            this.user_PhoneTextBox.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.user_PhoneTextBox.Location = new System.Drawing.Point(12, 389);
            this.user_PhoneTextBox.MaxLength = 12;
            this.user_PhoneTextBox.Name = "user_PhoneTextBox";
            this.user_PhoneTextBox.Size = new System.Drawing.Size(510, 31);
            this.user_PhoneTextBox.TabIndex = 18;
            this.user_PhoneTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.user_PhoneTextBox_KeyPress);
            // 
            // Registrbutton
            // 
            this.Registrbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Registrbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Registrbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registrbutton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Registrbutton.Location = new System.Drawing.Point(13, 488);
            this.Registrbutton.Name = "Registrbutton";
            this.Registrbutton.Size = new System.Drawing.Size(200, 100);
            this.Registrbutton.TabIndex = 19;
            this.Registrbutton.Text = "Зарегистрироваться";
            this.Registrbutton.UseVisualStyleBackColor = true;
            this.Registrbutton.Click += new System.EventHandler(this.Registrbutton_Click);
            // 
            // cancelRegistryButton
            // 
            this.cancelRegistryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.cancelRegistryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.cancelRegistryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelRegistryButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cancelRegistryButton.Location = new System.Drawing.Point(322, 488);
            this.cancelRegistryButton.Name = "cancelRegistryButton";
            this.cancelRegistryButton.Size = new System.Drawing.Size(200, 100);
            this.cancelRegistryButton.TabIndex = 20;
            this.cancelRegistryButton.Text = "Отмена регистрации";
            this.cancelRegistryButton.UseVisualStyleBackColor = true;
            this.cancelRegistryButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // Registry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(534, 611);
            this.ControlBox = false;
            this.Controls.Add(this.cancelRegistryButton);
            this.Controls.Add(this.Registrbutton);
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
            this.MaximumSize = new System.Drawing.Size(550, 650);
            this.MinimumSize = new System.Drawing.Size(550, 650);
            this.Name = "Registry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Center of Dentistry - Форма регистрации";
            this.Load += new System.EventHandler(this.Registry_Load);
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
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
        private System.Windows.Forms.Button Registrbutton;
        private System.Windows.Forms.Button cancelRegistryButton;
    }
}