namespace Record_and_prediction
{
    partial class Main_menu
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
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Show_goods_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.AutoEllipsis = true;
            this.button4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Location = new System.Drawing.Point(3, 99);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(257, 50);
            this.button4.TabIndex = 7;
            this.button4.Text = "Статистика";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(3, 147);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(257, 50);
            this.button3.TabIndex = 6;
            this.button3.Text = "Отчёт";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.AutoEllipsis = true;
            this.button2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(3, 51);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(257, 50);
            this.button2.TabIndex = 5;
            this.button2.Text = "Прогнозирование";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Show_goods_button
            // 
            this.Show_goods_button.AutoEllipsis = true;
            this.Show_goods_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Show_goods_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_goods_button.Location = new System.Drawing.Point(3, 3);
            this.Show_goods_button.Name = "Show_goods_button";
            this.Show_goods_button.Size = new System.Drawing.Size(257, 50);
            this.Show_goods_button.TabIndex = 4;
            this.Show_goods_button.Text = "Товар";
            this.Show_goods_button.UseVisualStyleBackColor = true;
            // 
            // Main_menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Show_goods_button);
            this.Name = "Main_menu";
            this.Size = new System.Drawing.Size(263, 366);
            this.Load += new System.EventHandler(this.Main_menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button Show_goods_button;
    }
}
