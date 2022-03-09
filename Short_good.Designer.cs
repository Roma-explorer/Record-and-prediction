namespace Record_and_prediction
{
    partial class Short_good
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

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label9 = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.print_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.volume = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.article = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.work_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.measure = new System.Windows.Forms.ComboBox();
            this.save_button = new System.Windows.Forms.Button();
            this.prognose = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.buy = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.graphic = new LiveCharts.WinForms.CartesianChart();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(17, 290);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(152, 20);
            this.label9.TabIndex = 35;
            this.label9.Text = "Единица измерения:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(184, 268);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(170, 20);
            this.price.TabIndex = 34;
            this.price.WordWrap = false;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            this.price.Leave += new System.EventHandler(this.price_Leave);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(17, 264);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(152, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Цена товара:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // print_name
            // 
            this.print_name.Location = new System.Drawing.Point(184, 61);
            this.print_name.Name = "print_name";
            this.print_name.Size = new System.Drawing.Size(279, 20);
            this.print_name.TabIndex = 32;
            this.print_name.WordWrap = false;
            this.print_name.TextChanged += new System.EventHandler(this.print_name_TextChanged);
            this.print_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.print_name_KeyPress);
            this.print_name.Leave += new System.EventHandler(this.print_name_Leave);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(17, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Наименование для печати:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(17, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Категория товара:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(184, 240);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(170, 21);
            this.category.TabIndex = 29;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            this.category.Leave += new System.EventHandler(this.category_Leave);
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(184, 167);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(170, 20);
            this.volume.TabIndex = 28;
            this.volume.WordWrap = false;
            this.volume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.article_KeyPress);
            this.volume.Leave += new System.EventHandler(this.volume_Leave);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(17, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Объём продаж:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(184, 141);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(170, 20);
            this.amount.TabIndex = 26;
            this.amount.WordWrap = false;
            this.amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.article_KeyPress);
            this.amount.Leave += new System.EventHandler(this.amount_Leave);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(17, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Количество товара:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // article
            // 
            this.article.Location = new System.Drawing.Point(184, 115);
            this.article.Name = "article";
            this.article.Size = new System.Drawing.Size(170, 20);
            this.article.TabIndex = 24;
            this.article.WordWrap = false;
            this.article.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.article_KeyPress);
            this.article.Leave += new System.EventHandler(this.article_Leave);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(17, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "Артикул:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(184, 87);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(170, 20);
            this.code.TabIndex = 22;
            this.code.WordWrap = false;
            this.code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.print_name_KeyPress);
            this.code.Leave += new System.EventHandler(this.code_Leave);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(17, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Код:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // work_name
            // 
            this.work_name.Location = new System.Drawing.Point(184, 35);
            this.work_name.Name = "work_name";
            this.work_name.Size = new System.Drawing.Size(279, 20);
            this.work_name.TabIndex = 20;
            this.work_name.WordWrap = false;
            this.work_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.print_name_KeyPress);
            this.work_name.Leave += new System.EventHandler(this.work_name_Leave);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Рабочее наименование:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // measure
            // 
            this.measure.FormattingEnabled = true;
            this.measure.Location = new System.Drawing.Point(184, 294);
            this.measure.Name = "measure";
            this.measure.Size = new System.Drawing.Size(170, 21);
            this.measure.TabIndex = 37;
            this.measure.SelectedIndexChanged += new System.EventHandler(this.measure_SelectedIndexChanged);
            this.measure.Leave += new System.EventHandler(this.measure_Leave);
            // 
            // save_button
            // 
            this.save_button.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.save_button.Location = new System.Drawing.Point(0, 549);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(666, 40);
            this.save_button.TabIndex = 38;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // prognose
            // 
            this.prognose.Location = new System.Drawing.Point(184, 193);
            this.prognose.Name = "prognose";
            this.prognose.ReadOnly = true;
            this.prognose.Size = new System.Drawing.Size(170, 20);
            this.prognose.TabIndex = 40;
            this.prognose.WordWrap = false;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(17, 193);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 20);
            this.label10.TabIndex = 39;
            this.label10.Text = "Прогноз на следующий месяц:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buy
            // 
            this.buy.Location = new System.Drawing.Point(184, 217);
            this.buy.Name = "buy";
            this.buy.ReadOnly = true;
            this.buy.Size = new System.Drawing.Size(170, 20);
            this.buy.TabIndex = 42;
            this.buy.WordWrap = false;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(17, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(175, 20);
            this.label11.TabIndex = 41;
            this.label11.Text = "Планируемая закупка:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // graphic
            // 
            this.graphic.BackColor = System.Drawing.Color.DarkSlateGray;
            this.graphic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.graphic.Location = new System.Drawing.Point(0, 331);
            this.graphic.Name = "graphic";
            this.graphic.Size = new System.Drawing.Size(666, 218);
            this.graphic.TabIndex = 43;
            this.graphic.Text = "cartesianChart1";
            // 
            // Short_good
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.graphic);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.prognose);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.measure);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.price);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.print_name);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.category);
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
            this.Name = "Short_good";
            this.Size = new System.Drawing.Size(666, 589);
            this.Load += new System.EventHandler(this.Short_good_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox print_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.TextBox volume;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox article;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox work_name;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox measure;
        private System.Windows.Forms.Button save_button;
        private System.Windows.Forms.TextBox prognose;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox buy;
        private System.Windows.Forms.Label label11;
        private LiveCharts.WinForms.CartesianChart graphic;
    }
}
