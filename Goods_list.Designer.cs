namespace Record_and_prediction
{
    partial class Goods_list
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
            this.add_product = new System.Windows.Forms.Button();
            this.download_goods = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // add_product
            // 
            this.add_product.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.add_product.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.add_product.Location = new System.Drawing.Point(0, 338);
            this.add_product.Name = "add_product";
            this.add_product.Size = new System.Drawing.Size(296, 23);
            this.add_product.TabIndex = 0;
            this.add_product.Text = "Добавить товар ";
            this.add_product.UseVisualStyleBackColor = true;
            this.add_product.Click += new System.EventHandler(this.add_product_Click);
            // 
            // download_goods
            // 
            this.download_goods.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.download_goods.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.download_goods.Location = new System.Drawing.Point(0, 315);
            this.download_goods.Name = "download_goods";
            this.download_goods.Size = new System.Drawing.Size(296, 23);
            this.download_goods.TabIndex = 1;
            this.download_goods.Text = "Загрузить товары ";
            this.download_goods.UseVisualStyleBackColor = true;
            this.download_goods.Click += new System.EventHandler(this.download_goods_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(296, 315);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // Goods_list
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.download_goods);
            this.Controls.Add(this.add_product);
            this.Name = "Goods_list";
            this.Size = new System.Drawing.Size(296, 361);
            this.Load += new System.EventHandler(this.Goods_list_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_product;
        private System.Windows.Forms.Button download_goods;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
