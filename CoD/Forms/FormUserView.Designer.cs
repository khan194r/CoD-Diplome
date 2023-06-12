namespace CoD.Forms
{
    partial class FormUserView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUserView));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ROLEScombobox = new System.Windows.Forms.ComboBox();
            this.searchTextBoxmmm = new System.Windows.Forms.TextBox();
            this.buttonCloseVIew = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(122)))), ((int)(((byte)(189)))));
            this.panel1.Controls.Add(this.ROLEScombobox);
            this.panel1.Controls.Add(this.searchTextBoxmmm);
            this.panel1.Controls.Add(this.buttonCloseVIew);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(849, 100);
            this.panel1.TabIndex = 0;
            // 
            // ROLEScombobox
            // 
            this.ROLEScombobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ROLEScombobox.FormattingEnabled = true;
            this.ROLEScombobox.Location = new System.Drawing.Point(527, 72);
            this.ROLEScombobox.Name = "ROLEScombobox";
            this.ROLEScombobox.Size = new System.Drawing.Size(310, 21);
            this.ROLEScombobox.TabIndex = 17;
            this.ROLEScombobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // searchTextBoxmmm
            // 
            this.searchTextBoxmmm.Location = new System.Drawing.Point(12, 73);
            this.searchTextBoxmmm.Name = "searchTextBoxmmm";
            this.searchTextBoxmmm.Size = new System.Drawing.Size(509, 20);
            this.searchTextBoxmmm.TabIndex = 16;
            this.searchTextBoxmmm.Text = "Введите для поиска по фамилии...";
            this.searchTextBoxmmm.TextChanged += new System.EventHandler(this.searchTextBoxmmm_TextChanged);
            this.searchTextBoxmmm.Enter += new System.EventHandler(this.searchTextBoxmmm_Enter);
            this.searchTextBoxmmm.Leave += new System.EventHandler(this.searchTextBoxmmm_Leave);
            // 
            // buttonCloseVIew
            // 
            this.buttonCloseVIew.FlatAppearance.MouseDownBackColor = System.Drawing.Color.IndianRed;
            this.buttonCloseVIew.FlatAppearance.MouseOverBackColor = System.Drawing.Color.IndianRed;
            this.buttonCloseVIew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCloseVIew.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCloseVIew.Location = new System.Drawing.Point(691, 26);
            this.buttonCloseVIew.Name = "buttonCloseVIew";
            this.buttonCloseVIew.Size = new System.Drawing.Size(146, 40);
            this.buttonCloseVIew.TabIndex = 15;
            this.buttonCloseVIew.Text = "Закрыть";
            this.buttonCloseVIew.UseVisualStyleBackColor = true;
            this.buttonCloseVIew.Click += new System.EventHandler(this.buttonCloseVIew_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(849, 411);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // FormUserView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(849, 511);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(865, 550);
            this.MinimumSize = new System.Drawing.Size(865, 550);
            this.Name = "FormUserView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Center of Dentistry - Окно просмотра пользователей";
            this.Load += new System.EventHandler(this.FormUserView_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonCloseVIew;
        private System.Windows.Forms.ComboBox ROLEScombobox;
        private System.Windows.Forms.TextBox searchTextBoxmmm;
    }
}