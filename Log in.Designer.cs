namespace Record_and_prediction
{
    partial class Log_in
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
            this.password_box = new System.Windows.Forms.TextBox();
            this.login_box = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.enter = new System.Windows.Forms.Button();
            this.Show_password = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(138, 78);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(176, 20);
            this.password_box.TabIndex = 12;
            this.password_box.UseSystemPasswordChar = true;
            this.password_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_box_KeyPress);
            this.password_box.Leave += new System.EventHandler(this.password_box_Leave);
            // 
            // login_box
            // 
            this.login_box.Location = new System.Drawing.Point(138, 52);
            this.login_box.Name = "login_box";
            this.login_box.Size = new System.Drawing.Size(176, 20);
            this.login_box.TabIndex = 11;
            this.login_box.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.login_box_KeyPress);
            this.login_box.Leave += new System.EventHandler(this.login_box_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Пароль:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Логин:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вход";
            // 
            // enter
            // 
            this.enter.Location = new System.Drawing.Point(94, 130);
            this.enter.Name = "enter";
            this.enter.Size = new System.Drawing.Size(134, 23);
            this.enter.TabIndex = 13;
            this.enter.Text = "Войти";
            this.enter.UseVisualStyleBackColor = true;
            this.enter.Click += new System.EventHandler(this.enter_Click);
            // 
            // Show_password
            // 
            this.Show_password.AutoSize = true;
            this.Show_password.Location = new System.Drawing.Point(126, 107);
            this.Show_password.Name = "Show_password";
            this.Show_password.Size = new System.Drawing.Size(114, 17);
            this.Show_password.TabIndex = 14;
            this.Show_password.Text = "Показать пароль";
            this.Show_password.UseVisualStyleBackColor = true;
            this.Show_password.CheckedChanged += new System.EventHandler(this.Show_password_CheckedChanged);
            // 
            // Log_in
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 336);
            this.Controls.Add(this.Show_password);
            this.Controls.Add(this.enter);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.login_box);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Log_in";
            this.Text = "Вход";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_in_FormClosing);
            this.Load += new System.EventHandler(this.Log_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.TextBox login_box;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button enter;
        private System.Windows.Forms.CheckBox Show_password;
    }
}