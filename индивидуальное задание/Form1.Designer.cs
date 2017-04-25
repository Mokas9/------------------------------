namespace индивидуальное_задание
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.функцииToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.функцииToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.добавитьАбитуриентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактироватьАбитуриентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.выгнатьАбитуриентаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискПоКритериямToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.функцииToolStripMenuItem,
            this.функцииToolStripMenuItem1,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(712, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // функцииToolStripMenuItem
            // 
            this.функцииToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.открытьToolStripMenuItem});
            this.функцииToolStripMenuItem.Name = "функцииToolStripMenuItem";
            this.функцииToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.функцииToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.открытьToolStripMenuItem.Text = "Открыть";
            this.открытьToolStripMenuItem.Click += new System.EventHandler(this.открытьToolStripMenuItem_Click);
            // 
            // функцииToolStripMenuItem1
            // 
            this.функцииToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьАбитуриентаToolStripMenuItem,
            this.редактироватьАбитуриентаToolStripMenuItem,
            this.выгнатьАбитуриентаToolStripMenuItem,
            this.поискПоКритериямToolStripMenuItem});
            this.функцииToolStripMenuItem1.Name = "функцииToolStripMenuItem1";
            this.функцииToolStripMenuItem1.Size = new System.Drawing.Size(68, 20);
            this.функцииToolStripMenuItem1.Text = "Функции";
            // 
            // добавитьАбитуриентаToolStripMenuItem
            // 
            this.добавитьАбитуриентаToolStripMenuItem.Name = "добавитьАбитуриентаToolStripMenuItem";
            this.добавитьАбитуриентаToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.добавитьАбитуриентаToolStripMenuItem.Text = "Добавить абитуриента";
            this.добавитьАбитуриентаToolStripMenuItem.Click += new System.EventHandler(this.добавитьАбитуриентаToolStripMenuItem_Click);
            // 
            // редактироватьАбитуриентаToolStripMenuItem
            // 
            this.редактироватьАбитуриентаToolStripMenuItem.Name = "редактироватьАбитуриентаToolStripMenuItem";
            this.редактироватьАбитуриентаToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.редактироватьАбитуриентаToolStripMenuItem.Text = "Редактировать абитуриента";
            this.редактироватьАбитуриентаToolStripMenuItem.Click += new System.EventHandler(this.редактироватьАбитуриентаToolStripMenuItem_Click);
            // 
            // выгнатьАбитуриентаToolStripMenuItem
            // 
            this.выгнатьАбитуриентаToolStripMenuItem.Name = "выгнатьАбитуриентаToolStripMenuItem";
            this.выгнатьАбитуриентаToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.выгнатьАбитуриентаToolStripMenuItem.Text = "Выгнать абитуриента";
            this.выгнатьАбитуриентаToolStripMenuItem.Click += new System.EventHandler(this.выгнатьАбитуриентаToolStripMenuItem_Click);
            // 
            // поискПоКритериямToolStripMenuItem
            // 
            this.поискПоКритериямToolStripMenuItem.Name = "поискПоКритериямToolStripMenuItem";
            this.поискПоКритериямToolStripMenuItem.Size = new System.Drawing.Size(226, 22);
            this.поискПоКритериямToolStripMenuItem.Text = "Поиск по критериям";
            this.поискПоКритериямToolStripMenuItem.Click += new System.EventHandler(this.поискПоКритериямToolStripMenuItem_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SlateBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(89, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(623, 399);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Фамилия";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Имя";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Отчество";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Город";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Мат";
            this.Column5.Name = "Column5";
            this.Column5.Width = 45;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Физ";
            this.Column6.Name = "Column6";
            this.Column6.Width = 45;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Лит";
            this.Column7.Name = "Column7";
            this.Column7.Width = 45;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Средний балл";
            this.Column8.Name = "Column8";
            this.Column8.Width = 45;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "XML Files |*.xml";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "xml";
            this.saveFileDialog1.Filter = "XML Files |*.xml";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(712, 427);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Абитуриенты";
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem функцииToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem добавитьАбитуриентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактироватьАбитуриентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выгнатьАбитуриентаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискПоКритериямToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}

