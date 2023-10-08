namespace Lab01
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabCoupon = new System.Windows.Forms.TabPage();
            this.buttonCoupon = new System.Windows.Forms.Button();
            this.dataGridViewCoupon = new System.Windows.Forms.DataGridView();
            this.tabOrder = new System.Windows.Forms.TabPage();
            this.buttonOrder = new System.Windows.Forms.Button();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.tabUser = new System.Windows.Forms.TabPage();
            this.dataGridViewUser = new System.Windows.Forms.DataGridView();
            this.tabFirm = new System.Windows.Forms.TabPage();
            this.dataGridViewFirm = new System.Windows.Forms.DataGridView();
            this.tabViborka = new System.Windows.Forms.TabPage();
            this.dataGridViewViborka = new System.Windows.Forms.DataGridView();
            this.Наименование = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonViborka = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabProcedura = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.dataGridViewProcedura = new System.Windows.Forms.DataGridView();
            this.buttonProcedura = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabCoupon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoupon)).BeginInit();
            this.tabOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.tabUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).BeginInit();
            this.tabFirm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirm)).BeginInit();
            this.tabViborka.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViborka)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabProcedura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedura)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabCoupon);
            this.tabControl1.Controls.Add(this.tabOrder);
            this.tabControl1.Controls.Add(this.tabUser);
            this.tabControl1.Controls.Add(this.tabFirm);
            this.tabControl1.Controls.Add(this.tabViborka);
            this.tabControl1.Controls.Add(this.tabProcedura);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(835, 500);
            this.tabControl1.TabIndex = 0;
            // 
            // tabCoupon
            // 
            this.tabCoupon.Controls.Add(this.buttonCoupon);
            this.tabCoupon.Controls.Add(this.dataGridViewCoupon);
            this.tabCoupon.Location = new System.Drawing.Point(4, 25);
            this.tabCoupon.Name = "tabCoupon";
            this.tabCoupon.Padding = new System.Windows.Forms.Padding(3);
            this.tabCoupon.Size = new System.Drawing.Size(827, 471);
            this.tabCoupon.TabIndex = 0;
            this.tabCoupon.Text = "Купон";
            this.tabCoupon.UseVisualStyleBackColor = true;
            // 
            // buttonCoupon
            // 
            this.buttonCoupon.Location = new System.Drawing.Point(6, 13);
            this.buttonCoupon.Name = "buttonCoupon";
            this.buttonCoupon.Size = new System.Drawing.Size(221, 23);
            this.buttonCoupon.TabIndex = 2;
            this.buttonCoupon.Text = "Save";
            this.buttonCoupon.UseVisualStyleBackColor = true;
            this.buttonCoupon.Click += new System.EventHandler(this.buttonCoupon_Click);
            // 
            // dataGridViewCoupon
            // 
            this.dataGridViewCoupon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCoupon.Location = new System.Drawing.Point(6, 42);
            this.dataGridViewCoupon.Name = "dataGridViewCoupon";
            this.dataGridViewCoupon.RowHeadersWidth = 51;
            this.dataGridViewCoupon.RowTemplate.Height = 24;
            this.dataGridViewCoupon.Size = new System.Drawing.Size(815, 423);
            this.dataGridViewCoupon.TabIndex = 1;
            // 
            // tabOrder
            // 
            this.tabOrder.Controls.Add(this.buttonOrder);
            this.tabOrder.Controls.Add(this.dataGridViewOrder);
            this.tabOrder.Location = new System.Drawing.Point(4, 25);
            this.tabOrder.Name = "tabOrder";
            this.tabOrder.Padding = new System.Windows.Forms.Padding(3);
            this.tabOrder.Size = new System.Drawing.Size(827, 471);
            this.tabOrder.TabIndex = 1;
            this.tabOrder.Text = "Покупка";
            this.tabOrder.UseVisualStyleBackColor = true;
            // 
            // buttonOrder
            // 
            this.buttonOrder.Location = new System.Drawing.Point(7, 4);
            this.buttonOrder.Name = "buttonOrder";
            this.buttonOrder.Size = new System.Drawing.Size(197, 23);
            this.buttonOrder.TabIndex = 1;
            this.buttonOrder.Text = "Save";
            this.buttonOrder.UseVisualStyleBackColor = true;
            this.buttonOrder.Click += new System.EventHandler(this.buttonOrder_Click);
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(6, 33);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(815, 432);
            this.dataGridViewOrder.TabIndex = 0;
            // 
            // tabUser
            // 
            this.tabUser.Controls.Add(this.dataGridViewUser);
            this.tabUser.Location = new System.Drawing.Point(4, 25);
            this.tabUser.Name = "tabUser";
            this.tabUser.Padding = new System.Windows.Forms.Padding(3);
            this.tabUser.Size = new System.Drawing.Size(827, 471);
            this.tabUser.TabIndex = 2;
            this.tabUser.Text = "Пользователь";
            this.tabUser.UseVisualStyleBackColor = true;
            // 
            // dataGridViewUser
            // 
            this.dataGridViewUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUser.Location = new System.Drawing.Point(6, 28);
            this.dataGridViewUser.Name = "dataGridViewUser";
            this.dataGridViewUser.RowHeadersWidth = 51;
            this.dataGridViewUser.RowTemplate.Height = 24;
            this.dataGridViewUser.Size = new System.Drawing.Size(815, 437);
            this.dataGridViewUser.TabIndex = 0;
            // 
            // tabFirm
            // 
            this.tabFirm.Controls.Add(this.dataGridViewFirm);
            this.tabFirm.Location = new System.Drawing.Point(4, 25);
            this.tabFirm.Name = "tabFirm";
            this.tabFirm.Padding = new System.Windows.Forms.Padding(3);
            this.tabFirm.Size = new System.Drawing.Size(827, 471);
            this.tabFirm.TabIndex = 3;
            this.tabFirm.Text = "Фирма";
            this.tabFirm.UseVisualStyleBackColor = true;
            // 
            // dataGridViewFirm
            // 
            this.dataGridViewFirm.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFirm.Location = new System.Drawing.Point(6, 36);
            this.dataGridViewFirm.Name = "dataGridViewFirm";
            this.dataGridViewFirm.RowHeadersWidth = 51;
            this.dataGridViewFirm.RowTemplate.Height = 24;
            this.dataGridViewFirm.Size = new System.Drawing.Size(815, 429);
            this.dataGridViewFirm.TabIndex = 0;
            // 
            // tabViborka
            // 
            this.tabViborka.Controls.Add(this.dataGridViewViborka);
            this.tabViborka.Controls.Add(this.groupBox1);
            this.tabViborka.Location = new System.Drawing.Point(4, 25);
            this.tabViborka.Name = "tabViborka";
            this.tabViborka.Padding = new System.Windows.Forms.Padding(3);
            this.tabViborka.Size = new System.Drawing.Size(827, 471);
            this.tabViborka.TabIndex = 4;
            this.tabViborka.Text = "Выборка";
            this.tabViborka.UseVisualStyleBackColor = true;
            // 
            // dataGridViewViborka
            // 
            this.dataGridViewViborka.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewViborka.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Наименование});
            this.dataGridViewViborka.Location = new System.Drawing.Point(6, 77);
            this.dataGridViewViborka.Name = "dataGridViewViborka";
            this.dataGridViewViborka.RowHeadersWidth = 51;
            this.dataGridViewViborka.RowTemplate.Height = 24;
            this.dataGridViewViborka.Size = new System.Drawing.Size(815, 377);
            this.dataGridViewViborka.TabIndex = 1;
            // 
            // Наименование
            // 
            this.Наименование.DataPropertyName = "Наименование";
            this.Наименование.HeaderText = "Наименование";
            this.Наименование.MinimumWidth = 6;
            this.Наименование.Name = "Наименование";
            this.Наименование.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonViborka);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(676, 65);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // buttonViborka
            // 
            this.buttonViborka.Location = new System.Drawing.Point(402, 22);
            this.buttonViborka.Name = "buttonViborka";
            this.buttonViborka.Size = new System.Drawing.Size(130, 23);
            this.buttonViborka.TabIndex = 2;
            this.buttonViborka.Text = "Найти";
            this.buttonViborka.UseVisualStyleBackColor = true;
            this.buttonViborka.Click += new System.EventHandler(this.buttonViborka_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Купон";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(128, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(226, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // tabProcedura
            // 
            this.tabProcedura.Controls.Add(this.buttonProcedura);
            this.tabProcedura.Controls.Add(this.label3);
            this.tabProcedura.Controls.Add(this.label2);
            this.tabProcedura.Controls.Add(this.numericUpDown2);
            this.tabProcedura.Controls.Add(this.numericUpDown1);
            this.tabProcedura.Controls.Add(this.dataGridViewProcedura);
            this.tabProcedura.Location = new System.Drawing.Point(4, 25);
            this.tabProcedura.Name = "tabProcedura";
            this.tabProcedura.Padding = new System.Windows.Forms.Padding(3);
            this.tabProcedura.Size = new System.Drawing.Size(827, 471);
            this.tabProcedura.TabIndex = 5;
            this.tabProcedura.Text = "Процедура";
            this.tabProcedura.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(297, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Месяц";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(117, 17);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown2.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(352, 17);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2025,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // dataGridViewProcedura
            // 
            this.dataGridViewProcedura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProcedura.Location = new System.Drawing.Point(9, 48);
            this.dataGridViewProcedura.Name = "dataGridViewProcedura";
            this.dataGridViewProcedura.RowHeadersWidth = 51;
            this.dataGridViewProcedura.Size = new System.Drawing.Size(812, 420);
            this.dataGridViewProcedura.TabIndex = 0;
            // 
            // buttonProcedura
            // 
            this.buttonProcedura.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.buttonProcedura.Location = new System.Drawing.Point(519, 16);
            this.buttonProcedura.Name = "buttonProcedura";
            this.buttonProcedura.Size = new System.Drawing.Size(140, 23);
            this.buttonProcedura.TabIndex = 5;
            this.buttonProcedura.Text = "Найти";
            this.buttonProcedura.UseVisualStyleBackColor = true;
            this.buttonProcedura.Click += new System.EventHandler(this.buttonProcedura_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 519);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabCoupon.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCoupon)).EndInit();
            this.tabOrder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.tabUser.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUser)).EndInit();
            this.tabFirm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFirm)).EndInit();
            this.tabViborka.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewViborka)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabProcedura.ResumeLayout(false);
            this.tabProcedura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProcedura)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabCoupon;
        private System.Windows.Forms.TabPage tabOrder;
        private System.Windows.Forms.TabPage tabUser;
        private System.Windows.Forms.TabPage tabFirm;
        private System.Windows.Forms.TabPage tabViborka;
        private System.Windows.Forms.DataGridView dataGridViewCoupon;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.DataGridView dataGridViewUser;
        private System.Windows.Forms.DataGridView dataGridViewFirm;
        private System.Windows.Forms.Button buttonCoupon;
        private System.Windows.Forms.Button buttonOrder;
        private System.Windows.Forms.TabPage tabProcedura;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridViewViborka;
        private System.Windows.Forms.Button buttonViborka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Наименование;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.DataGridView dataGridViewProcedura;
        private System.Windows.Forms.Button buttonProcedura;
    }
}

