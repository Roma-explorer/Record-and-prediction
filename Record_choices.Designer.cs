namespace Record_and_prediction
{
    partial class Record_choices
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
            this.All = new System.Windows.Forms.Button();
            this.Category = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // All
            // 
            this.All.AutoSize = true;
            this.All.Dock = System.Windows.Forms.DockStyle.Top;
            this.All.Location = new System.Drawing.Point(0, 0);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(114, 46);
            this.All.TabIndex = 0;
            this.All.Text = "Общее";
            this.All.UseVisualStyleBackColor = true;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // Category
            // 
            this.Category.AutoSize = true;
            this.Category.Dock = System.Windows.Forms.DockStyle.Top;
            this.Category.Location = new System.Drawing.Point(0, 46);
            this.Category.Name = "Category";
            this.Category.Size = new System.Drawing.Size(114, 46);
            this.Category.TabIndex = 1;
            this.Category.Text = "По категориям";
            this.Category.UseVisualStyleBackColor = true;
            this.Category.Click += new System.EventHandler(this.Category_Click);
            // 
            // Record_choices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.Controls.Add(this.Category);
            this.Controls.Add(this.All);
            this.Name = "Record_choices";
            this.Size = new System.Drawing.Size(114, 373);
            this.Load += new System.EventHandler(this.Record_choices_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button All;
        private System.Windows.Forms.Button Category;
    }
}
