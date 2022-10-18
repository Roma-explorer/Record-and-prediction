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
            this.measure_label = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.TextBox();
            this.price_label = new System.Windows.Forms.Label();
            this.print_name = new System.Windows.Forms.TextBox();
            this.print_name_label = new System.Windows.Forms.Label();
            this.category_label = new System.Windows.Forms.Label();
            this.category = new System.Windows.Forms.ComboBox();
            this.volume = new System.Windows.Forms.TextBox();
            this.volume_label = new System.Windows.Forms.Label();
            this.amount = new System.Windows.Forms.TextBox();
            this.amount_label = new System.Windows.Forms.Label();
            this.article = new System.Windows.Forms.TextBox();
            this.article_label = new System.Windows.Forms.Label();
            this.code = new System.Windows.Forms.TextBox();
            this.code_label = new System.Windows.Forms.Label();
            this.work_name = new System.Windows.Forms.TextBox();
            this.work_name_label = new System.Windows.Forms.Label();
            this.measure = new System.Windows.Forms.ComboBox();
            this.prognose = new System.Windows.Forms.TextBox();
            this.prognose_label = new System.Windows.Forms.Label();
            this.buy = new System.Windows.Forms.TextBox();
            this.buy_label = new System.Windows.Forms.Label();
            this.graphic = new LiveCharts.WinForms.CartesianChart();
            this.edit_button = new System.Windows.Forms.Button();
            this.work_name_display_content = new System.Windows.Forms.Label();
            this.code_display_label = new System.Windows.Forms.Label();
            this.code_display_content = new System.Windows.Forms.Label();
            this.article_display_label = new System.Windows.Forms.Label();
            this.article_display_content = new System.Windows.Forms.Label();
            this.amount_display_label = new System.Windows.Forms.Label();
            this.volume_display_label = new System.Windows.Forms.Label();
            this.prognose_display_label = new System.Windows.Forms.Label();
            this.buy_display_label = new System.Windows.Forms.Label();
            this.category_display_label = new System.Windows.Forms.Label();
            this.price_display_label = new System.Windows.Forms.Label();
            this.category_display_content = new System.Windows.Forms.Label();
            this.amount_display_content = new System.Windows.Forms.Label();
            this.measure_display_content = new System.Windows.Forms.Label();
            this.price_display_content = new System.Windows.Forms.Label();
            this.volume_display_content = new System.Windows.Forms.Label();
            this.prognose_display_content = new System.Windows.Forms.Label();
            this.buy_display_content = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // measure_label
            // 
            this.measure_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.measure_label.ForeColor = System.Drawing.Color.White;
            this.measure_label.Location = new System.Drawing.Point(20, 277);
            this.measure_label.Name = "measure_label";
            this.measure_label.Size = new System.Drawing.Size(197, 20);
            this.measure_label.TabIndex = 35;
            this.measure_label.Text = "Единица измерения:";
            this.measure_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // price
            // 
            this.price.Location = new System.Drawing.Point(288, 255);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(308, 20);
            this.price.TabIndex = 34;
            this.price.WordWrap = false;
            this.price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.price_KeyPress);
            this.price.Leave += new System.EventHandler(this.price_Leave);
            // 
            // price_label
            // 
            this.price_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_label.ForeColor = System.Drawing.Color.White;
            this.price_label.Location = new System.Drawing.Point(20, 252);
            this.price_label.Name = "price_label";
            this.price_label.Size = new System.Drawing.Size(197, 20);
            this.price_label.TabIndex = 33;
            this.price_label.Text = "Цена товара:";
            this.price_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // print_name
            // 
            this.print_name.Location = new System.Drawing.Point(288, 54);
            this.print_name.Name = "print_name";
            this.print_name.Size = new System.Drawing.Size(308, 20);
            this.print_name.TabIndex = 32;
            this.print_name.WordWrap = false;
            this.print_name.TextChanged += new System.EventHandler(this.print_name_TextChanged);
            this.print_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.print_name_KeyPress);
            this.print_name.Leave += new System.EventHandler(this.print_name_Leave);
            // 
            // print_name_label
            // 
            this.print_name_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print_name_label.ForeColor = System.Drawing.Color.White;
            this.print_name_label.Location = new System.Drawing.Point(20, 52);
            this.print_name_label.Name = "print_name_label";
            this.print_name_label.Size = new System.Drawing.Size(197, 20);
            this.print_name_label.TabIndex = 31;
            this.print_name_label.Text = "Наименование для печати:";
            this.print_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // category_label
            // 
            this.category_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_label.ForeColor = System.Drawing.Color.White;
            this.category_label.Location = new System.Drawing.Point(20, 227);
            this.category_label.Name = "category_label";
            this.category_label.Size = new System.Drawing.Size(174, 20);
            this.category_label.TabIndex = 30;
            this.category_label.Text = "Категория товара:";
            this.category_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // category
            // 
            this.category.FormattingEnabled = true;
            this.category.Location = new System.Drawing.Point(288, 229);
            this.category.Name = "category";
            this.category.Size = new System.Drawing.Size(308, 21);
            this.category.TabIndex = 29;
            this.category.SelectedIndexChanged += new System.EventHandler(this.category_SelectedIndexChanged);
            this.category.Leave += new System.EventHandler(this.category_Leave);
            // 
            // volume
            // 
            this.volume.Location = new System.Drawing.Point(288, 154);
            this.volume.Name = "volume";
            this.volume.Size = new System.Drawing.Size(308, 20);
            this.volume.TabIndex = 28;
            this.volume.WordWrap = false;
            this.volume.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.article_KeyPress);
            this.volume.Leave += new System.EventHandler(this.volume_Leave);
            // 
            // volume_label
            // 
            this.volume_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume_label.ForeColor = System.Drawing.Color.White;
            this.volume_label.Location = new System.Drawing.Point(20, 152);
            this.volume_label.Name = "volume_label";
            this.volume_label.Size = new System.Drawing.Size(174, 20);
            this.volume_label.TabIndex = 27;
            this.volume_label.Text = "Объём продаж:";
            this.volume_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(288, 129);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(308, 20);
            this.amount.TabIndex = 26;
            this.amount.WordWrap = false;
            this.amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.article_KeyPress);
            this.amount.Leave += new System.EventHandler(this.amount_Leave);
            // 
            // amount_label
            // 
            this.amount_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_label.ForeColor = System.Drawing.Color.White;
            this.amount_label.Location = new System.Drawing.Point(20, 127);
            this.amount_label.Name = "amount_label";
            this.amount_label.Size = new System.Drawing.Size(174, 20);
            this.amount_label.TabIndex = 25;
            this.amount_label.Text = "Количество товара:";
            this.amount_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // article
            // 
            this.article.Location = new System.Drawing.Point(288, 104);
            this.article.Name = "article";
            this.article.Size = new System.Drawing.Size(308, 20);
            this.article.TabIndex = 24;
            this.article.WordWrap = false;
            this.article.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.article_KeyPress);
            this.article.Leave += new System.EventHandler(this.article_Leave);
            // 
            // article_label
            // 
            this.article_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.article_label.ForeColor = System.Drawing.Color.White;
            this.article_label.Location = new System.Drawing.Point(20, 102);
            this.article_label.Name = "article_label";
            this.article_label.Size = new System.Drawing.Size(174, 20);
            this.article_label.TabIndex = 23;
            this.article_label.Text = "Артикул:";
            this.article_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // code
            // 
            this.code.Location = new System.Drawing.Point(288, 79);
            this.code.Name = "code";
            this.code.Size = new System.Drawing.Size(308, 20);
            this.code.TabIndex = 22;
            this.code.WordWrap = false;
            this.code.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.print_name_KeyPress);
            this.code.Leave += new System.EventHandler(this.code_Leave);
            // 
            // code_label
            // 
            this.code_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_label.ForeColor = System.Drawing.Color.White;
            this.code_label.Location = new System.Drawing.Point(20, 77);
            this.code_label.Name = "code_label";
            this.code_label.Size = new System.Drawing.Size(174, 20);
            this.code_label.TabIndex = 21;
            this.code_label.Text = "Код:";
            this.code_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // work_name
            // 
            this.work_name.Location = new System.Drawing.Point(288, 29);
            this.work_name.Name = "work_name";
            this.work_name.Size = new System.Drawing.Size(308, 20);
            this.work_name.TabIndex = 20;
            this.work_name.Visible = false;
            this.work_name.WordWrap = false;
            this.work_name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.print_name_KeyPress);
            this.work_name.Leave += new System.EventHandler(this.work_name_Leave);
            // 
            // work_name_label
            // 
            this.work_name_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.work_name_label.ForeColor = System.Drawing.Color.White;
            this.work_name_label.Location = new System.Drawing.Point(20, 27);
            this.work_name_label.Name = "work_name_label";
            this.work_name_label.Size = new System.Drawing.Size(247, 20);
            this.work_name_label.TabIndex = 19;
            this.work_name_label.Text = "Рабочее наименование:";
            this.work_name_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.work_name_label.Visible = false;
            // 
            // measure
            // 
            this.measure.FormattingEnabled = true;
            this.measure.Location = new System.Drawing.Point(288, 280);
            this.measure.Name = "measure";
            this.measure.Size = new System.Drawing.Size(308, 21);
            this.measure.TabIndex = 37;
            this.measure.SelectedIndexChanged += new System.EventHandler(this.measure_SelectedIndexChanged);
            this.measure.Leave += new System.EventHandler(this.measure_Leave);
            // 
            // prognose
            // 
            this.prognose.Location = new System.Drawing.Point(288, 179);
            this.prognose.Name = "prognose";
            this.prognose.ReadOnly = true;
            this.prognose.Size = new System.Drawing.Size(308, 20);
            this.prognose.TabIndex = 40;
            this.prognose.WordWrap = false;
            // 
            // prognose_label
            // 
            this.prognose_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prognose_label.ForeColor = System.Drawing.Color.White;
            this.prognose_label.Location = new System.Drawing.Point(20, 177);
            this.prognose_label.Name = "prognose_label";
            this.prognose_label.Size = new System.Drawing.Size(247, 20);
            this.prognose_label.TabIndex = 39;
            this.prognose_label.Text = "Прогноз на следующий месяц:";
            this.prognose_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buy
            // 
            this.buy.Location = new System.Drawing.Point(288, 204);
            this.buy.Name = "buy";
            this.buy.ReadOnly = true;
            this.buy.Size = new System.Drawing.Size(308, 20);
            this.buy.TabIndex = 42;
            this.buy.WordWrap = false;
            // 
            // buy_label
            // 
            this.buy_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy_label.ForeColor = System.Drawing.Color.White;
            this.buy_label.Location = new System.Drawing.Point(20, 202);
            this.buy_label.Name = "buy_label";
            this.buy_label.Size = new System.Drawing.Size(220, 20);
            this.buy_label.TabIndex = 41;
            this.buy_label.Text = "Планируемая закупка:";
            this.buy_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // graphic
            // 
            this.graphic.BackColor = System.Drawing.Color.DarkSlateGray;
            this.graphic.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.graphic.Location = new System.Drawing.Point(0, 371);
            this.graphic.Name = "graphic";
            this.graphic.Size = new System.Drawing.Size(666, 218);
            this.graphic.TabIndex = 43;
            this.graphic.Text = "cartesianChart1";
            // 
            // edit_button
            // 
            this.edit_button.BackColor = System.Drawing.Color.Transparent;
            this.edit_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edit_button.Location = new System.Drawing.Point(24, 324);
            this.edit_button.Name = "edit_button";
            this.edit_button.Size = new System.Drawing.Size(170, 56);
            this.edit_button.TabIndex = 44;
            this.edit_button.Text = "Редактировать";
            this.edit_button.UseVisualStyleBackColor = false;
            this.edit_button.Click += new System.EventHandler(this.edit_button_Click);
            // 
            // work_name_display_content
            // 
            this.work_name_display_content.Font = new System.Drawing.Font("Arial Rounded MT Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.work_name_display_content.ForeColor = System.Drawing.Color.White;
            this.work_name_display_content.Location = new System.Drawing.Point(7, 371);
            this.work_name_display_content.Name = "work_name_display_content";
            this.work_name_display_content.Size = new System.Drawing.Size(632, 33);
            this.work_name_display_content.TabIndex = 45;
            this.work_name_display_content.Text = "Рабочее наименование";
            this.work_name_display_content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // code_display_label
            // 
            this.code_display_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.code_display_label.ForeColor = System.Drawing.Color.White;
            this.code_display_label.Location = new System.Drawing.Point(10, 413);
            this.code_display_label.Name = "code_display_label";
            this.code_display_label.Size = new System.Drawing.Size(45, 20);
            this.code_display_label.TabIndex = 46;
            this.code_display_label.Text = "Код:";
            this.code_display_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // code_display_content
            // 
            this.code_display_content.ForeColor = System.Drawing.Color.White;
            this.code_display_content.Location = new System.Drawing.Point(48, 414);
            this.code_display_content.Name = "code_display_content";
            this.code_display_content.Size = new System.Drawing.Size(64, 20);
            this.code_display_content.TabIndex = 47;
            this.code_display_content.Text = "79096905";
            this.code_display_content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // article_display_label
            // 
            this.article_display_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.article_display_label.ForeColor = System.Drawing.Color.White;
            this.article_display_label.Location = new System.Drawing.Point(114, 413);
            this.article_display_label.Name = "article_display_label";
            this.article_display_label.Size = new System.Drawing.Size(73, 20);
            this.article_display_label.TabIndex = 48;
            this.article_display_label.Text = "Артикул:";
            this.article_display_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // article_display_content
            // 
            this.article_display_content.ForeColor = System.Drawing.Color.White;
            this.article_display_content.Location = new System.Drawing.Point(179, 414);
            this.article_display_content.Name = "article_display_content";
            this.article_display_content.Size = new System.Drawing.Size(64, 20);
            this.article_display_content.TabIndex = 49;
            this.article_display_content.Text = "79096905";
            this.article_display_content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amount_display_label
            // 
            this.amount_display_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_display_label.ForeColor = System.Drawing.Color.White;
            this.amount_display_label.Location = new System.Drawing.Point(9, 445);
            this.amount_display_label.Name = "amount_display_label";
            this.amount_display_label.Size = new System.Drawing.Size(145, 20);
            this.amount_display_label.TabIndex = 50;
            this.amount_display_label.Text = "Количество товара:";
            this.amount_display_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // volume_display_label
            // 
            this.volume_display_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volume_display_label.ForeColor = System.Drawing.Color.White;
            this.volume_display_label.Location = new System.Drawing.Point(10, 471);
            this.volume_display_label.Name = "volume_display_label";
            this.volume_display_label.Size = new System.Drawing.Size(129, 20);
            this.volume_display_label.TabIndex = 51;
            this.volume_display_label.Text = "Объём продаж:";
            this.volume_display_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prognose_display_label
            // 
            this.prognose_display_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prognose_display_label.ForeColor = System.Drawing.Color.White;
            this.prognose_display_label.Location = new System.Drawing.Point(9, 497);
            this.prognose_display_label.Name = "prognose_display_label";
            this.prognose_display_label.Size = new System.Drawing.Size(213, 20);
            this.prognose_display_label.TabIndex = 39;
            this.prognose_display_label.Text = "Прогноз на следующий месяц:";
            this.prognose_display_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buy_display_label
            // 
            this.buy_display_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buy_display_label.ForeColor = System.Drawing.Color.White;
            this.buy_display_label.Location = new System.Drawing.Point(9, 521);
            this.buy_display_label.Name = "buy_display_label";
            this.buy_display_label.Size = new System.Drawing.Size(175, 20);
            this.buy_display_label.TabIndex = 41;
            this.buy_display_label.Text = "Планируемая закупка:";
            this.buy_display_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // category_display_label
            // 
            this.category_display_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_display_label.ForeColor = System.Drawing.Color.White;
            this.category_display_label.Location = new System.Drawing.Point(249, 414);
            this.category_display_label.Name = "category_display_label";
            this.category_display_label.Size = new System.Drawing.Size(94, 20);
            this.category_display_label.TabIndex = 30;
            this.category_display_label.Text = "Категория товара:";
            this.category_display_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // price_display_label
            // 
            this.price_display_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_display_label.ForeColor = System.Drawing.Color.White;
            this.price_display_label.Location = new System.Drawing.Point(249, 445);
            this.price_display_label.Name = "price_display_label";
            this.price_display_label.Size = new System.Drawing.Size(152, 20);
            this.price_display_label.TabIndex = 33;
            this.price_display_label.Text = "Цена товара:";
            this.price_display_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // category_display_content
            // 
            this.category_display_content.ForeColor = System.Drawing.Color.White;
            this.category_display_content.Location = new System.Drawing.Point(333, 412);
            this.category_display_content.Name = "category_display_content";
            this.category_display_content.Size = new System.Drawing.Size(223, 20);
            this.category_display_content.TabIndex = 52;
            this.category_display_content.Text = "79096905";
            this.category_display_content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // amount_display_content
            // 
            this.amount_display_content.ForeColor = System.Drawing.Color.White;
            this.amount_display_content.Location = new System.Drawing.Point(151, 445);
            this.amount_display_content.Name = "amount_display_content";
            this.amount_display_content.Size = new System.Drawing.Size(51, 20);
            this.amount_display_content.TabIndex = 53;
            this.amount_display_content.Text = "79096";
            this.amount_display_content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // measure_display_content
            // 
            this.measure_display_content.ForeColor = System.Drawing.Color.White;
            this.measure_display_content.Location = new System.Drawing.Point(189, 445);
            this.measure_display_content.Name = "measure_display_content";
            this.measure_display_content.Size = new System.Drawing.Size(42, 20);
            this.measure_display_content.TabIndex = 54;
            this.measure_display_content.Text = "sht";
            this.measure_display_content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // price_display_content
            // 
            this.price_display_content.ForeColor = System.Drawing.Color.White;
            this.price_display_content.Location = new System.Drawing.Point(350, 446);
            this.price_display_content.Name = "price_display_content";
            this.price_display_content.Size = new System.Drawing.Size(51, 20);
            this.price_display_content.TabIndex = 55;
            this.price_display_content.Text = "79096";
            this.price_display_content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // volume_display_content
            // 
            this.volume_display_content.ForeColor = System.Drawing.Color.White;
            this.volume_display_content.Location = new System.Drawing.Point(130, 471);
            this.volume_display_content.Name = "volume_display_content";
            this.volume_display_content.Size = new System.Drawing.Size(51, 20);
            this.volume_display_content.TabIndex = 56;
            this.volume_display_content.Text = "79096";
            this.volume_display_content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // prognose_display_content
            // 
            this.prognose_display_content.ForeColor = System.Drawing.Color.White;
            this.prognose_display_content.Location = new System.Drawing.Point(228, 498);
            this.prognose_display_content.Name = "prognose_display_content";
            this.prognose_display_content.Size = new System.Drawing.Size(51, 20);
            this.prognose_display_content.TabIndex = 57;
            this.prognose_display_content.Text = "79096";
            this.prognose_display_content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buy_display_content
            // 
            this.buy_display_content.ForeColor = System.Drawing.Color.White;
            this.buy_display_content.Location = new System.Drawing.Point(171, 522);
            this.buy_display_content.Name = "buy_display_content";
            this.buy_display_content.Size = new System.Drawing.Size(51, 20);
            this.buy_display_content.TabIndex = 58;
            this.buy_display_content.Text = "79096";
            this.buy_display_content.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Short_good
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.buy_display_content);
            this.Controls.Add(this.prognose_display_content);
            this.Controls.Add(this.volume_display_content);
            this.Controls.Add(this.price_display_content);
            this.Controls.Add(this.measure_display_content);
            this.Controls.Add(this.amount_display_content);
            this.Controls.Add(this.category_display_content);
            this.Controls.Add(this.volume_display_label);
            this.Controls.Add(this.amount_display_label);
            this.Controls.Add(this.article_display_content);
            this.Controls.Add(this.article_display_label);
            this.Controls.Add(this.code_display_content);
            this.Controls.Add(this.code_display_label);
            this.Controls.Add(this.edit_button);
            this.Controls.Add(this.buy);
            this.Controls.Add(this.buy_display_label);
            this.Controls.Add(this.buy_label);
            this.Controls.Add(this.prognose);
            this.Controls.Add(this.prognose_display_label);
            this.Controls.Add(this.prognose_label);
            this.Controls.Add(this.measure);
            this.Controls.Add(this.measure_label);
            this.Controls.Add(this.price);
            this.Controls.Add(this.price_display_label);
            this.Controls.Add(this.price_label);
            this.Controls.Add(this.print_name);
            this.Controls.Add(this.print_name_label);
            this.Controls.Add(this.category_display_label);
            this.Controls.Add(this.category_label);
            this.Controls.Add(this.category);
            this.Controls.Add(this.volume);
            this.Controls.Add(this.volume_label);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.amount_label);
            this.Controls.Add(this.article);
            this.Controls.Add(this.article_label);
            this.Controls.Add(this.code);
            this.Controls.Add(this.code_label);
            this.Controls.Add(this.work_name);
            this.Controls.Add(this.work_name_label);
            this.Controls.Add(this.work_name_display_content);
            this.Controls.Add(this.graphic);
            this.Name = "Short_good";
            this.Size = new System.Drawing.Size(666, 589);
            this.Load += new System.EventHandler(this.Short_good_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label measure_label;
        private System.Windows.Forms.TextBox price;
        private System.Windows.Forms.Label price_label;
        private System.Windows.Forms.TextBox print_name;
        private System.Windows.Forms.Label print_name_label;
        private System.Windows.Forms.Label category_label;
        private System.Windows.Forms.ComboBox category;
        private System.Windows.Forms.TextBox volume;
        private System.Windows.Forms.Label volume_label;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label amount_label;
        private System.Windows.Forms.TextBox article;
        private System.Windows.Forms.Label article_label;
        private System.Windows.Forms.TextBox code;
        private System.Windows.Forms.Label code_label;
        private System.Windows.Forms.TextBox work_name;
        private System.Windows.Forms.Label work_name_label;
        public System.Windows.Forms.ComboBox measure;
        private System.Windows.Forms.TextBox prognose;
        private System.Windows.Forms.Label prognose_label;
        private System.Windows.Forms.TextBox buy;
        private System.Windows.Forms.Label buy_label;
        private LiveCharts.WinForms.CartesianChart graphic;
        private System.Windows.Forms.Button edit_button;
        private System.Windows.Forms.Label work_name_display_content;
        private System.Windows.Forms.Label code_display_label;
        private System.Windows.Forms.Label code_display_content;
        private System.Windows.Forms.Label article_display_label;
        private System.Windows.Forms.Label article_display_content;
        private System.Windows.Forms.Label amount_display_label;
        private System.Windows.Forms.Label volume_display_label;
        private System.Windows.Forms.Label prognose_display_label;
        private System.Windows.Forms.Label buy_display_label;
        private System.Windows.Forms.Label category_display_label;
        private System.Windows.Forms.Label price_display_label;
        private System.Windows.Forms.Label category_display_content;
        private System.Windows.Forms.Label amount_display_content;
        private System.Windows.Forms.Label measure_display_content;
        private System.Windows.Forms.Label price_display_content;
        private System.Windows.Forms.Label volume_display_content;
        private System.Windows.Forms.Label prognose_display_content;
        private System.Windows.Forms.Label buy_display_content;
    }
}
