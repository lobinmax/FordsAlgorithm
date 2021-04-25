namespace FordsAlgorithm
{
    partial class FormMain
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.buttonНайтиПуть = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.УправлениеГрафами = new FordsAlgorithm.UserControlНовыйГраф();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(555, 533);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(109, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(670, 533);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(102, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // buttonНайтиПуть
            // 
            this.buttonНайтиПуть.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonНайтиПуть.Location = new System.Drawing.Point(868, 527);
            this.buttonНайтиПуть.Name = "buttonНайтиПуть";
            this.buttonНайтиПуть.Size = new System.Drawing.Size(205, 27);
            this.buttonНайтиПуть.TabIndex = 12;
            this.buttonНайтиПуть.Text = "Найти кратчайший путь";
            this.buttonНайтиПуть.UseVisualStyleBackColor = true;
            this.buttonНайтиПуть.Click += new System.EventHandler(this.buttonНайтиПуть_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(3, 16);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.textBox1.ShowSelectionMargin = true;
            this.textBox1.Size = new System.Drawing.Size(518, 476);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(552, 517);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Начальная вершина:";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 517);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Конечная вершина:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(552, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 495);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Консоль выполнения";
            // 
            // УправлениеГрафами
            // 
            this.УправлениеГрафами.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.УправлениеГрафами.Location = new System.Drawing.Point(12, 12);
            this.УправлениеГрафами.MinimumSize = new System.Drawing.Size(534, 450);
            this.УправлениеГрафами.Name = "УправлениеГрафами";
            this.УправлениеГрафами.Size = new System.Drawing.Size(534, 542);
            this.УправлениеГрафами.TabIndex = 0;
            this.УправлениеГрафами.КоличествоРеберChanged += new System.EventHandler(this.УправлениеГрафами_КоличествоРеберChanged);
            this.УправлениеГрафами.МассивГрафовSelectionChanged += new System.EventHandler(this.УправлениеГрафами_МассивГрафовSelectionChanged);
            this.УправлениеГрафами.МассивГрафовДобавление += new System.EventHandler(this.УправлениеГрафами_МассивГрафовДобавление);
            this.УправлениеГрафами.МассивГрафовУдаление += new System.EventHandler(this.УправлениеГрафами_МассивГрафовУдаление);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 566);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.УправлениеГрафами);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonНайтиПуть);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "FormMain";
            this.Text = "Ford\'s Algorithm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button buttonНайтиПуть;
        private System.Windows.Forms.RichTextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private UserControlНовыйГраф УправлениеГрафами;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

