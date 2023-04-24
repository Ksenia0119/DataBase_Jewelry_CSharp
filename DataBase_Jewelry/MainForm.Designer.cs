namespace DataBase_Jewelry
{
    partial class MainForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_add = new System.Windows.Forms.Button();
            this.button_alldelete = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сведенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оРазработчикеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jewerly_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.composition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьБазуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.инсToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.jewerly_name,
            this.type,
            this.composition,
            this.weight,
            this.price});
            this.dataGridView1.Location = new System.Drawing.Point(54, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(879, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(35, 49);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 28);
            this.button_add.TabIndex = 2;
            this.button_add.Text = "Добавить";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // button_alldelete
            // 
            this.button_alldelete.Location = new System.Drawing.Point(143, 49);
            this.button_alldelete.Margin = new System.Windows.Forms.Padding(4);
            this.button_alldelete.Name = "button_alldelete";
            this.button_alldelete.Size = new System.Drawing.Size(100, 28);
            this.button_alldelete.TabIndex = 5;
            this.button_alldelete.Text = "Удалить все";
            this.button_alldelete.UseVisualStyleBackColor = true;
            this.button_alldelete.Click += new System.EventHandler(this.button_alldelete_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.правкаToolStripMenuItem,
            this.сведенияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(945, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьБазуToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // сведенияToolStripMenuItem
            // 
            this.сведенияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.оРазработчикеToolStripMenuItem,
            this.инсToolStripMenuItem});
            this.сведенияToolStripMenuItem.Name = "сведенияToolStripMenuItem";
            this.сведенияToolStripMenuItem.Size = new System.Drawing.Size(90, 24);
            this.сведенияToolStripMenuItem.Text = "Сведения";
            // 
            // оРазработчикеToolStripMenuItem
            // 
            this.оРазработчикеToolStripMenuItem.Name = "оРазработчикеToolStripMenuItem";
            this.оРазработчикеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.оРазработчикеToolStripMenuItem.Text = "О разработчике";
            // 
            // jewerly_name
            // 
            this.jewerly_name.HeaderText = "Название";
            this.jewerly_name.MinimumWidth = 6;
            this.jewerly_name.Name = "jewerly_name";
            this.jewerly_name.Width = 125;
            // 
            // type
            // 
            this.type.HeaderText = "Тип изделия";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.Width = 125;
            // 
            // composition
            // 
            this.composition.HeaderText = "Состав";
            this.composition.MinimumWidth = 6;
            this.composition.Name = "composition";
            this.composition.Width = 125;
            // 
            // weight
            // 
            this.weight.HeaderText = "Вес(гр.)";
            this.weight.MinimumWidth = 6;
            this.weight.Name = "weight";
            this.weight.Width = 125;
            // 
            // price
            // 
            this.price.HeaderText = "Цена(руб.)";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // открытьБазуToolStripMenuItem
            // 
            this.открытьБазуToolStripMenuItem.Name = "открытьБазуToolStripMenuItem";
            this.открытьБазуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.открытьБазуToolStripMenuItem.Text = "Открыть базу";
            this.открытьБазуToolStripMenuItem.Click += new System.EventHandler(this.открытьБазуToolStripMenuItem_Click);
            // 
            // инсToolStripMenuItem
            // 
            this.инсToolStripMenuItem.Name = "инсToolStripMenuItem";
            this.инсToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.инсToolStripMenuItem.Text = "Инструкция";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 447);
            this.Controls.Add(this.button_alldelete);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "База данных ювелирных изделии";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Button button_alldelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn jewerly_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn composition;
        private System.Windows.Forms.DataGridViewTextBoxColumn weight;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сведенияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem оРазработчикеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьБазуToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem инсToolStripMenuItem;
    }
}

