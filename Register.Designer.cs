namespace Record_and_prediction
{
    partial class Register
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.login_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.org_name_box = new System.Windows.Forms.TextBox();
            this.choose_org_file = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.save_button = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.choose_data_file = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(39, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Логин:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(38, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Пароль:";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(404, 663);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(69, 25);
            this.linkLabel1.TabIndex = 3;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Войти";
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.White;
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(39, 299);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(291, 29);
            this.label4.TabIndex = 4;
            this.label4.Text = "Название организации:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(151, 663);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(241, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Уже зарегестрированы?";
            // 
            // login_box
            // 
            this.login_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.login_box.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.login_box.Location = new System.Drawing.Point(44, 119);
            this.login_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(505, 44);
            this.login_box.TabIndex = 6;
            this.login_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.org_name_box_KeyPress);
            this.login_box.Leave += new System.EventHandler(this.login_box_Leave);
            // 
            // password_box
            // 
            this.password_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.password_box.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.password_box.Location = new System.Drawing.Point(44, 229);
            this.password_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(505, 44);
            this.password_box.TabIndex = 7;
            this.password_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.org_name_box_KeyPress);
            this.password_box.Leave += new System.EventHandler(this.password_box_Leave);
            // 
            // org_name_box
            // 
            this.org_name_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.org_name_box.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.org_name_box.Location = new System.Drawing.Point(44, 338);
            this.org_name_box.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.org_name_box.Name = "org_name_box";
            this.org_name_box.Size = new System.Drawing.Size(505, 44);
            this.org_name_box.TabIndex = 8;
            this.org_name_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.org_name_box_KeyPress);
            this.org_name_box.Leave += new System.EventHandler(this.org_name_box_Leave);
            // 
            // choose_org_file
            // 
            this.choose_org_file.AutoEllipsis = true;
            this.choose_org_file.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.choose_org_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_org_file.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.choose_org_file.Location = new System.Drawing.Point(348, 414);
            this.choose_org_file.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.choose_org_file.Name = "choose_org_file";
            this.choose_org_file.Size = new System.Drawing.Size(201, 50);
            this.choose_org_file.TabIndex = 9;
            this.choose_org_file.Text = "Выберите файл";
            this.choose_org_file.UseVisualStyleBackColor = true;
            this.choose_org_file.Click += new System.EventHandler(this.choose_org_file_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(38, 414);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(225, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Данные о товарах:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // save_button
            // 
            this.save_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.save_button.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.save_button.Location = new System.Drawing.Point(44, 558);
            this.save_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(505, 84);
            this.save_button.TabIndex = 11;
            this.save_button.Text = "Зарегистрироваться";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(38, 485);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(247, 29);
            this.label7.TabIndex = 13;
            this.label7.Text = "Данные о продажах:";
            // 
            // choose_data_file
            // 
            this.choose_data_file.AutoEllipsis = true;
            this.choose_data_file.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.choose_data_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choose_data_file.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.choose_data_file.Location = new System.Drawing.Point(348, 484);
            this.choose_data_file.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.choose_data_file.Name = "choose_data_file";
            this.choose_data_file.Size = new System.Drawing.Size(201, 50);
            this.choose_data_file.TabIndex = 12;
            this.choose_data_file.Text = "Выберите файл";
            this.choose_data_file.UseVisualStyleBackColor = true;
            this.choose_data_file.Click += new System.EventHandler(this.choose_data_file_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(167, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(259, 46);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(594, 761);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.choose_data_file);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.choose_org_file);
            this.Controls.Add(this.org_name_box);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Register_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Register_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox org_name_box;
        private System.Windows.Forms.Button choose_org_file;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button choose_data_file;
        private System.Windows.Forms.Label label1;
    }
}