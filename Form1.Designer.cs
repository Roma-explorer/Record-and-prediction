using System.Drawing;

namespace Record_and_prediction
{
    partial class Form1
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

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.MenuDataSplit = new System.Windows.Forms.SplitContainer();
            this.Leave = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Show_goods_button = new System.Windows.Forms.Button();
            this.ProductDataSplit = new System.Windows.Forms.SplitContainer();
            ((System.ComponentModel.ISupportInitialize)(this.MenuDataSplit)).BeginInit();
            this.MenuDataSplit.Panel1.SuspendLayout();
            this.MenuDataSplit.Panel2.SuspendLayout();
            this.MenuDataSplit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataSplit)).BeginInit();
            this.ProductDataSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuDataSplit
            // 
            this.MenuDataSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MenuDataSplit.Location = new System.Drawing.Point(10, 10);
            this.MenuDataSplit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MenuDataSplit.Name = "MenuDataSplit";
            // 
            // MenuDataSplit.Panel1
            // 
            this.MenuDataSplit.Panel1.Controls.Add(this.Leave);
            this.MenuDataSplit.Panel1.Controls.Add(this.button3);
            this.MenuDataSplit.Panel1.Controls.Add(this.Show_goods_button);
            // 
            // MenuDataSplit.Panel2
            // 
            this.MenuDataSplit.Panel2.Controls.Add(this.ProductDataSplit);
            this.MenuDataSplit.Size = new System.Drawing.Size(1569, 865);
            this.MenuDataSplit.SplitterDistance = 300;
            this.MenuDataSplit.SplitterWidth = 6;
            this.MenuDataSplit.TabIndex = 0;
            // 
            // Leave
            // 
            this.Leave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Leave.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Leave.Location = new System.Drawing.Point(0, 811);
            this.Leave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Leave.Name = "Leave";
            this.Leave.Size = new System.Drawing.Size(253, 73);
            this.Leave.TabIndex = 11;
            this.Leave.Text = "Выйти";
            this.Leave.UseVisualStyleBackColor = true;
            this.Leave.ForeColor = Color.DarkSlateGray;
            this.Leave.Font = new Font("Microsoft Sans Serif", 14);
            this.Leave.Click += new System.EventHandler(this.Leave_Click);
            // 
            // button3
            // 
            this.button3.AutoEllipsis = true;
            this.button3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 77);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(253, 73);
            this.button3.TabIndex = 10;
            this.button3.Text = "Отчёт";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.ForeColor = Color.DarkSlateGray;
            this.button3.Font = new Font("Microsoft Sans Serif", 14);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Show_goods_button
            // 
            this.Show_goods_button.AutoEllipsis = true;
            this.Show_goods_button.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Show_goods_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Show_goods_button.Dock = System.Windows.Forms.DockStyle.Top;
            this.Show_goods_button.Location = new System.Drawing.Point(0, 0);
            this.Show_goods_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Show_goods_button.Name = "Show_goods_button";
            this.Show_goods_button.Size = new System.Drawing.Size(253, 73);
            this.Show_goods_button.TabIndex = 8;
            this.Show_goods_button.Text = "Товар";
            this.Show_goods_button.UseVisualStyleBackColor = true;
            this.Show_goods_button.ForeColor = Color.DarkSlateGray;
            this.Show_goods_button.Font = new Font("Microsoft Sans Serif", 14);
            this.Show_goods_button.Click += new System.EventHandler(this.Show_goods_button_Click);
            // 
            // ProductDataSplit
            // 
            this.ProductDataSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductDataSplit.Location = new System.Drawing.Point(0, 0);
            this.ProductDataSplit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ProductDataSplit.Name = "ProductDataSplit";
            this.ProductDataSplit.Size = new System.Drawing.Size(1310, 865);
            this.ProductDataSplit.SplitterDistance = 339;
            this.ProductDataSplit.SplitterWidth = 6;
            this.ProductDataSplit.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.CancelButton = this.Leave;
            this.ClientSize = new System.Drawing.Size(1569, 865);
            this.Controls.Add(this.MenuDataSplit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MenuDataSplit.Panel1.ResumeLayout(false);
            this.MenuDataSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MenuDataSplit)).EndInit();
            this.MenuDataSplit.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductDataSplit)).EndInit();
            this.ProductDataSplit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer MenuDataSplit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Show_goods_button;
        private System.Windows.Forms.Button Leave;
        public System.Windows.Forms.SplitContainer ProductDataSplit;
    }
}

