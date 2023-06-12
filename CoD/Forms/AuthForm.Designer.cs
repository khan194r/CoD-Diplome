namespace CoD.Forms
{
    partial class AuthForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.logintextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.enterbutton = new System.Windows.Forms.Button();
            this.canselbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // logintextBox
            // 
            this.logintextBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logintextBox.Location = new System.Drawing.Point(12, 41);
            this.logintextBox.Name = "logintextBox";
            this.logintextBox.Size = new System.Drawing.Size(426, 40);
            this.logintextBox.TabIndex = 0;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordtextBox.Location = new System.Drawing.Point(12, 120);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(426, 40);
            this.passwordtextBox.TabIndex = 1;
            // 
            // enterbutton
            // 
            this.enterbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.enterbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.enterbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.enterbutton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.enterbutton.Location = new System.Drawing.Point(12, 166);
            this.enterbutton.Name = "enterbutton";
            this.enterbutton.Size = new System.Drawing.Size(210, 100);
            this.enterbutton.TabIndex = 2;
            this.enterbutton.Text = "Авторизоваться";
            this.enterbutton.UseVisualStyleBackColor = true;
            this.enterbutton.Click += new System.EventHandler(this.enterbutton_Click);
            // 
            // canselbutton
            // 
            this.canselbutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.canselbutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.canselbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.canselbutton.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.canselbutton.Location = new System.Drawing.Point(228, 166);
            this.canselbutton.Name = "canselbutton";
            this.canselbutton.Size = new System.Drawing.Size(210, 100);
            this.canselbutton.TabIndex = 3;
            this.canselbutton.Text = "Отмена авторизации";
            this.canselbutton.UseVisualStyleBackColor = true;
            this.canselbutton.Click += new System.EventHandler(this.canselbutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 33);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль:";
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 289);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.canselbutton);
            this.Controls.Add(this.enterbutton);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.logintextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(466, 328);
            this.MinimumSize = new System.Drawing.Size(466, 328);
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Center of Dentistry - Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logintextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Button enterbutton;
        private System.Windows.Forms.Button canselbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}