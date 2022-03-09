namespace Record_and_prediction
{
    partial class save_button
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
            this.label1 = new System.Windows.Forms.Label();
            this.work_name = new System.Windows.Forms.TextBox();
            this.code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.article = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.volume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button_save = new System.Windows.Forms.Button();
            this.category = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.print_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.measure = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Рабочее наименование:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // work_name
            // 
            this.work_name.Location = new System.Drawing.Point(176, 27);
            this.work_name.Name = "work_name";
            this.work_name.Size = new System.Drawing.Size(170, 20);
            this.work_name.TabIndex = 1;
            this.work_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.print_name_KeyPress);
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(176, 79);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(170, 20);
            this.code.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.Location = new System.Drawing.Point(29, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Код:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // article
            // 
            this.article.Location = new System.Drawing.Point(176, 107);
            this.article.Name = "article";
            this.article.Size = new System.Drawing.Size(170, 20);
            this.article.TabIndex = 5;
            this.article.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.article_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.Location = new System.Drawing.Point(29, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Артикул:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(176, 133);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(170, 20);
            this.amount.TabIndex = 7;
            this.amount.Leave += new System.EventHandler(this.amount_Leave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.Location = new System.Drawing.Point(29, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Количество товара:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(176, 159);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(170, 20);
            this.volume.TabIndex = 9;
            this.volume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.volume_KeyPress);
            this.volume.Leave += new System.EventHandler(this.volume_Leave);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.Location = new System.Drawing.Point(29, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Объём продаж:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(638, 405);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(150, 33);
            this.button_save.TabIndex = 10;
            this.button_save.Text = "Добавить";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.save_button_Click);
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(490, 28);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(164, 21);
            this.category.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.Location = new System.Drawing.Point(355, 34);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Категория товара:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // print_name
            // 
            this.print_name.Location = new System.Drawing.Point(176, 53);
            this.print_name.Name = "print_name";
            this.print_name.Size = new System.Drawing.Size(170, 20);
            this.print_name.TabIndex = 14;
            this.print_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.print_name_KeyPress);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.Location = new System.Drawing.Point(29, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 23);
            this.label7.TabIndex = 13;
            this.label7.Text = "Наименование для печати:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(490, 56);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(164, 20);
            this.price.TabIndex = 16;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            this.price.Leave += new System.EventHandler(this.price_Leave);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.Location = new System.Drawing.Point(355, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Цена товара:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.Location = new System.Drawing.Point(355, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 23);
            this.label9.TabIndex = 17;
            this.label9.Text = "Единица измерения:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // measure
            // 
            this.measure.FormattingEnabled = true;
            this.measure.Location = new System.Drawing.Point(490, 82);
            this.measure.Name = "measure";
            this.measure.Size = new System.Drawing.Size(164, 21);
            this.measure.TabIndex = 18;
            // 
            // save_button
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.measure);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.print_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.category);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.article);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.work_name);
            this.Controls.Add(this.label1);
            this.Name = "save_button";
            this.Text = "Добавить товар";
            this.Click += new System.EventHandler(this.save_button_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox work_name;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox article;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox volume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox print_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox measure;
    }
}