namespace Record_and_prediction
{
    partial class All_Report
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
            this.table = new System.Windows.Forms.DataGridView();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Article = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Volume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Прогноз = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Закупка = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.table)).BeginInit();
            this.SuspendLayout();
            // 
            // table
            // 
            this.table.AllowUserToOrderColumns = true;
            this.table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Title,
            this.Article,
            this.Price,
            this.Amount,
            this.Volume,
            this.Cat,
            this.Прогноз,
            this.Закупка});
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Name = "table";
            this.table.Size = new System.Drawing.Size(841, 394);
            this.table.TabIndex = 2;
            this.table.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_CellContentClick);
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
            // Прогноз
            // 
            this.Прогноз.HeaderText = "Прогноз";
            this.Прогноз.Name = "Прогноз";
            // 
            // Закупка
            // 
            this.Закупка.HeaderText = "Закупка";
            this.Закупка.Name = "Закупка";
            // 
            // All_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.table);
            this.Name = "All_Report";
            this.Size = new System.Drawing.Size(841, 394);
            this.Load += new System.EventHandler(this.All_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView table;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Article;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Volume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Прогноз;
        private System.Windows.Forms.DataGridViewTextBoxColumn Закупка;
    }
}
