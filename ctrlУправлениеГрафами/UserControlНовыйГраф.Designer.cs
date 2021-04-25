namespace FordsAlgorithm
{
    partial class UserControlНовыйГраф
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonОткрытьГраф = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.gridViewМассивГрафов = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridViewМатрицаСмежности = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonУдалитьРебро = new System.Windows.Forms.Button();
            this.numericВесРебра = new System.Windows.Forms.NumericUpDown();
            this.buttonДобавитьРебро = new System.Windows.Forms.Button();
            this.buttonСоздатьГраф = new System.Windows.Forms.Button();
            this.buttonНовыйГраф = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxИмяГрафа = new System.Windows.Forms.TextBox();
            this.buttonСохранитьКак = new System.Windows.Forms.Button();
            this.buttonУдалитьГраф = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.numericКоличествоВершин = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewМассивГрафов)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewМатрицаСмежности)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericВесРебра)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericКоличествоВершин)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.buttonОткрытьГраф);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.buttonСоздатьГраф);
            this.groupBox1.Controls.Add(this.buttonНовыйГраф);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.textBoxИмяГрафа);
            this.groupBox1.Controls.Add(this.buttonСохранитьКак);
            this.groupBox1.Controls.Add(this.buttonУдалитьГраф);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.numericКоличествоВершин);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(648, 590);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Параметры графа";
            // 
            // buttonОткрытьГраф
            // 
            this.buttonОткрытьГраф.Location = new System.Drawing.Point(18, 18);
            this.buttonОткрытьГраф.Name = "buttonОткрытьГраф";
            this.buttonОткрытьГраф.Size = new System.Drawing.Size(61, 22);
            this.buttonОткрытьГраф.TabIndex = 45;
            this.buttonОткрытьГраф.Text = "Файл ...";
            this.buttonОткрытьГраф.UseVisualStyleBackColor = true;
            this.buttonОткрытьГраф.Click += new System.EventHandler(this.buttonОткрытьГраф_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.gridViewМассивГрафов);
            this.groupBox3.Location = new System.Drawing.Point(18, 85);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(614, 199);
            this.groupBox3.TabIndex = 44;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Массив графов (0 шт.)";
            // 
            // gridViewМассивГрафов
            // 
            this.gridViewМассивГрафов.AllowUserToAddRows = false;
            this.gridViewМассивГрафов.AllowUserToDeleteRows = false;
            this.gridViewМассивГрафов.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewМассивГрафов.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewМассивГрафов.ColumnHeadersHeight = 20;
            this.gridViewМассивГрафов.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewМассивГрафов.Location = new System.Drawing.Point(6, 19);
            this.gridViewМассивГрафов.MultiSelect = false;
            this.gridViewМассивГрафов.Name = "gridViewМассивГрафов";
            this.gridViewМассивГрафов.ReadOnly = true;
            this.gridViewМассивГрафов.RowHeadersWidth = 25;
            this.gridViewМассивГрафов.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewМассивГрафов.RowTemplate.Height = 18;
            this.gridViewМассивГрафов.RowTemplate.ReadOnly = true;
            this.gridViewМассивГрафов.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewМассивГрафов.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridViewМассивГрафов.Size = new System.Drawing.Size(602, 174);
            this.gridViewМассивГрафов.TabIndex = 38;
            this.gridViewМассивГрафов.DataSourceChanged += new System.EventHandler(this.gridViewМассивГрафов_SelectionChanged);
            this.gridViewМассивГрафов.SelectionChanged += new System.EventHandler(this.gridViewМассивГрафов_SelectionChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.gridViewМатрицаСмежности);
            this.groupBox2.Controls.Add(this.panel2);
            this.groupBox2.Location = new System.Drawing.Point(18, 290);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(614, 287);
            this.groupBox2.TabIndex = 43;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Матрица смежности";
            // 
            // gridViewМатрицаСмежности
            // 
            this.gridViewМатрицаСмежности.AllowUserToAddRows = false;
            this.gridViewМатрицаСмежности.AllowUserToDeleteRows = false;
            this.gridViewМатрицаСмежности.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridViewМатрицаСмежности.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.gridViewМатрицаСмежности.ColumnHeadersHeight = 20;
            this.gridViewМатрицаСмежности.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridViewМатрицаСмежности.Location = new System.Drawing.Point(6, 19);
            this.gridViewМатрицаСмежности.MultiSelect = false;
            this.gridViewМатрицаСмежности.Name = "gridViewМатрицаСмежности";
            this.gridViewМатрицаСмежности.RowHeadersWidth = 25;
            this.gridViewМатрицаСмежности.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridViewМатрицаСмежности.RowTemplate.Height = 18;
            this.gridViewМатрицаСмежности.RowTemplate.ReadOnly = true;
            this.gridViewМатрицаСмежности.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.gridViewМатрицаСмежности.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.gridViewМатрицаСмежности.ShowCellErrors = false;
            this.gridViewМатрицаСмежности.ShowCellToolTips = false;
            this.gridViewМатрицаСмежности.ShowEditingIcon = false;
            this.gridViewМатрицаСмежности.ShowRowErrors = false;
            this.gridViewМатрицаСмежности.Size = new System.Drawing.Size(602, 223);
            this.gridViewМатрицаСмежности.TabIndex = 41;
            this.gridViewМатрицаСмежности.DataSourceChanged += new System.EventHandler(this.gridViewМатрицаСмежности_DataSourceChanged);
            this.gridViewМатрицаСмежности.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridViewМатрицаСмежности_CellClick);
            this.gridViewМатрицаСмежности.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.gridViewМатрицаСмежности_ColumnAdded);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.buttonУдалитьРебро);
            this.panel2.Controls.Add(this.numericВесРебра);
            this.panel2.Controls.Add(this.buttonДобавитьРебро);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(6, 248);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(398, 33);
            this.panel2.TabIndex = 42;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 41;
            this.label1.Text = "Вес ребра:";
            // 
            // buttonУдалитьРебро
            // 
            this.buttonУдалитьРебро.Enabled = false;
            this.buttonУдалитьРебро.Location = new System.Drawing.Point(326, 6);
            this.buttonУдалитьРебро.Name = "buttonУдалитьРебро";
            this.buttonУдалитьРебро.Size = new System.Drawing.Size(62, 22);
            this.buttonУдалитьРебро.TabIndex = 40;
            this.buttonУдалитьРебро.Text = "Удалить";
            this.buttonУдалитьРебро.UseVisualStyleBackColor = true;
            this.buttonУдалитьРебро.Click += new System.EventHandler(this.buttonУдалитьРебро_Click);
            // 
            // numericВесРебра
            // 
            this.numericВесРебра.Location = new System.Drawing.Point(74, 6);
            this.numericВесРебра.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericВесРебра.Name = "numericВесРебра";
            this.numericВесРебра.Size = new System.Drawing.Size(80, 20);
            this.numericВесРебра.TabIndex = 36;
            // 
            // buttonДобавитьРебро
            // 
            this.buttonДобавитьРебро.Location = new System.Drawing.Point(160, 6);
            this.buttonДобавитьРебро.Name = "buttonДобавитьРебро";
            this.buttonДобавитьРебро.Size = new System.Drawing.Size(160, 22);
            this.buttonДобавитьРебро.TabIndex = 30;
            this.buttonДобавитьРебро.Text = "Добавить ребро";
            this.buttonДобавитьРебро.UseVisualStyleBackColor = true;
            this.buttonДобавитьРебро.Click += new System.EventHandler(this.buttonДобавитьРебро_Click);
            // 
            // buttonСоздатьГраф
            // 
            this.buttonСоздатьГраф.Enabled = false;
            this.buttonСоздатьГраф.Location = new System.Drawing.Point(211, 57);
            this.buttonСоздатьГраф.Name = "buttonСоздатьГраф";
            this.buttonСоздатьГраф.Size = new System.Drawing.Size(88, 22);
            this.buttonСоздатьГраф.TabIndex = 39;
            this.buttonСоздатьГраф.Text = "Создать граф";
            this.buttonСоздатьГраф.UseVisualStyleBackColor = true;
            this.buttonСоздатьГраф.Click += new System.EventHandler(this.buttonСоздатьГраф_Click);
            // 
            // buttonНовыйГраф
            // 
            this.buttonНовыйГраф.Location = new System.Drawing.Point(85, 18);
            this.buttonНовыйГраф.Name = "buttonНовыйГраф";
            this.buttonНовыйГраф.Size = new System.Drawing.Size(34, 22);
            this.buttonНовыйГраф.TabIndex = 34;
            this.buttonНовыйГраф.Text = "+";
            this.buttonНовыйГраф.UseVisualStyleBackColor = true;
            this.buttonНовыйГраф.Click += new System.EventHandler(this.buttonНовыйГраф_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(125, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(66, 13);
            this.label10.TabIndex = 31;
            this.label10.Text = "Имя графа:";
            // 
            // textBoxИмяГрафа
            // 
            this.textBoxИмяГрафа.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxИмяГрафа.Enabled = false;
            this.textBoxИмяГрафа.Location = new System.Drawing.Point(197, 20);
            this.textBoxИмяГрафа.Name = "textBoxИмяГрафа";
            this.textBoxИмяГрафа.Size = new System.Drawing.Size(435, 20);
            this.textBoxИмяГрафа.TabIndex = 25;
            // 
            // buttonСохранитьКак
            // 
            this.buttonСохранитьКак.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonСохранитьКак.Location = new System.Drawing.Point(525, 57);
            this.buttonСохранитьКак.Name = "buttonСохранитьКак";
            this.buttonСохранитьКак.Size = new System.Drawing.Size(107, 22);
            this.buttonСохранитьКак.TabIndex = 30;
            this.buttonСохранитьКак.Text = "Сохранить как ...";
            this.buttonСохранитьКак.UseVisualStyleBackColor = true;
            this.buttonСохранитьКак.Click += new System.EventHandler(this.buttonСохранитьКак_Click);
            // 
            // buttonУдалитьГраф
            // 
            this.buttonУдалитьГраф.Location = new System.Drawing.Point(305, 57);
            this.buttonУдалитьГраф.Name = "buttonУдалитьГраф";
            this.buttonУдалитьГраф.Size = new System.Drawing.Size(86, 22);
            this.buttonУдалитьГраф.TabIndex = 22;
            this.buttonУдалитьГраф.Text = "Удалить граф";
            this.buttonУдалитьГраф.UseVisualStyleBackColor = true;
            this.buttonУдалитьГраф.Click += new System.EventHandler(this.buttonУдалитьГраф_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Кол-во вершин графа:";
            // 
            // numericКоличествоВершин
            // 
            this.numericКоличествоВершин.Enabled = false;
            this.numericКоличествоВершин.Location = new System.Drawing.Point(140, 59);
            this.numericКоличествоВершин.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericКоличествоВершин.Name = "numericКоличествоВершин";
            this.numericКоличествоВершин.Size = new System.Drawing.Size(57, 20);
            this.numericКоличествоВершин.TabIndex = 20;
            this.numericКоличествоВершин.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // UserControlНовыйГраф
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.MinimumSize = new System.Drawing.Size(534, 450);
            this.Name = "UserControlНовыйГраф";
            this.Size = new System.Drawing.Size(665, 606);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewМассивГрафов)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewМатрицаСмежности)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericВесРебра)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericКоличествоВершин)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxИмяГрафа;
        private System.Windows.Forms.Button buttonДобавитьРебро;
        private System.Windows.Forms.Button buttonСохранитьКак;
        private System.Windows.Forms.Button buttonУдалитьГраф;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numericКоличествоВершин;
        private System.Windows.Forms.Button buttonНовыйГраф;
        private System.Windows.Forms.NumericUpDown numericВесРебра;
        private System.Windows.Forms.DataGridView gridViewМассивГрафов;
        private System.Windows.Forms.Button buttonСоздатьГраф;
        private System.Windows.Forms.DataGridView gridViewМатрицаСмежности;
        private System.Windows.Forms.Button buttonУдалитьРебро;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonОткрытьГраф;
        private System.Windows.Forms.Label label1;
    }
}
