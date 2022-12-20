namespace Record_and_prediction
{
    partial class Report
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.category_box = new System.Windows.Forms.ComboBox();
            this.table = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prognose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Buy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pure_profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.sort_box = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // category_box
            // 
            this.category_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.category_box.FormattingEnabled = true;
            this.category_box.Location = new System.Drawing.Point(172, 14);
            this.category_box.Margin = new System.Windows.Forms.Padding(4);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(276, 24);
            this.category_box.TabIndex = 0;
            this.category_box.SelectedIndexChanged += new System.EventHandler(this.category_box_SelectedIndexChanged);
            // 
            // table
            // 
            this.table.AllowUserToDeleteRows = false;
            this.table.AllowUserToOrderColumns = true;
            this.table.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.table.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Title, this.Article, this.Price, this.Amount, this.Volume, this.Cat, this.Prognose, this.Buy, this.Profit, this.pure_profit });
            this.table.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.table.Location = new System.Drawing.Point(0, 47);
            this.table.Margin = new System.Windows.Forms.Padding(4);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(1097, 572);
            this.table.TabIndex = 1;
            // 
            // Title
            // 
            this.Title.HeaderText = "Название";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Article
            // 
            this.Article.HeaderText = "Артикул";
            this.Article.Name = "Article";
            this.Article.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Остаток";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            // 
            // Volume
            // 
            this.Volume.HeaderText = "Продано за месяц";
            this.Volume.Name = "Volume";
            this.Volume.ReadOnly = true;
            // 
            // Cat
            // 
            this.Cat.HeaderText = "Категория";
            this.Cat.Name = "Cat";
            this.Cat.ReadOnly = true;
            // 
            // Prognose
            // 
            this.Prognose.HeaderText = "Прогноз";
            this.Prognose.Name = "Prognose";
            // 
            // Buy
            // 
            this.Buy.HeaderText = "Закупка";
            this.Buy.Name = "Buy";
            // 
            // Profit
            // 
            this.Profit.HeaderText = "Прибыль";
            this.Profit.Name = "Profit";
            // 
            // pure_profit
            // 
            this.pure_profit.HeaderText = "Чистая прибыль";
            this.pure_profit.Name = "pure_profit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Выберите категорию";
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.sort_box);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.category_box);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1097, 52);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Выберите сортировку";
            // 
            // sort_box
            // 
            this.sort_box.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.sort_box.FormattingEnabled = true;
            this.sort_box.Location = new System.Drawing.Point(700, 12);
            this.sort_box.Margin = new System.Windows.Forms.Padding(4);
            this.sort_box.Name = "sort_box";
            this.sort_box.Size = new System.Drawing.Size(276, 24);
            this.sort_box.TabIndex = 3;
            this.sort_box.SelectedIndexChanged += new System.EventHandler(this.sort_box_SelectedIndexChanged);
            // 
            // Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.table);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Report";
            this.Size = new System.Drawing.Size(1097, 619);
            this.Load += new System.EventHandler(this.Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.DataGridViewTextBoxColumn pure_profit;

        #endregion

        private System.Windows.Forms.ComboBox category_box;
        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prognose;
        private System.Windows.Forms.DataGridViewTextBoxColumn Buy;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sort_box;
        private System.Windows.Forms.DataGridViewTextBoxColumn Profit;
    }
}
