namespace ind
{
    partial class FMain
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
            this.Search = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnSortName = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.tbDir = new System.Windows.Forms.TextBox();
            this.btnSortSize = new System.Windows.Forms.Button();
            this.btnSortDate = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(12, 14);
            this.Search.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(425, 57);
            this.Search.TabIndex = 0;
            this.Search.Text = "Пошук";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalExtent = 1;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(12, 86);
            this.listBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(424, 324);
            this.listBox1.TabIndex = 1;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(689, 416);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(208, 26);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnSortName
            // 
            this.btnSortName.Location = new System.Drawing.Point(452, 14);
            this.btnSortName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSortName.Name = "btnSortName";
            this.btnSortName.Size = new System.Drawing.Size(132, 57);
            this.btnSortName.TabIndex = 5;
            this.btnSortName.Text = "За ім\'ям";
            this.btnSortName.UseVisualStyleBackColor = true;
            this.btnSortName.Click += new System.EventHandler(this.btnSortName_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(452, 86);
            this.listBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(444, 324);
            this.listBox2.TabIndex = 6;
            // 
            // tbDir
            // 
            this.tbDir.Location = new System.Drawing.Point(12, 417);
            this.tbDir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbDir.Name = "tbDir";
            this.tbDir.ReadOnly = true;
            this.tbDir.Size = new System.Drawing.Size(424, 22);
            this.tbDir.TabIndex = 7;
            this.tbDir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSortSize
            // 
            this.btnSortSize.Location = new System.Drawing.Point(592, 14);
            this.btnSortSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSortSize.Name = "btnSortSize";
            this.btnSortSize.Size = new System.Drawing.Size(153, 57);
            this.btnSortSize.TabIndex = 8;
            this.btnSortSize.Text = "За розміром";
            this.btnSortSize.UseVisualStyleBackColor = true;
            this.btnSortSize.Click += new System.EventHandler(this.btnSortSize_Click);
            // 
            // btnSortDate
            // 
            this.btnSortDate.Location = new System.Drawing.Point(753, 15);
            this.btnSortDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSortDate.Name = "btnSortDate";
            this.btnSortDate.Size = new System.Drawing.Size(144, 55);
            this.btnSortDate.TabIndex = 9;
            this.btnSortDate.Text = "За датою";
            this.btnSortDate.UseVisualStyleBackColor = true;
            this.btnSortDate.Click += new System.EventHandler(this.btnSortDate_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.Location = new System.Drawing.Point(452, 416);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(232, 26);
            this.btnAbout.TabIndex = 10;
            this.btnAbout.Text = "Про програму";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // FMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(928, 449);
            this.Controls.Add(this.btnAbout);
            this.Controls.Add(this.btnSortDate);
            this.Controls.Add(this.btnSortSize);
            this.Controls.Add(this.tbDir);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnSortName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.Search);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FMain";
            this.Text = "Індивідуальне завдання";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btnSortName;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.TextBox tbDir;
        private System.Windows.Forms.Button btnSortSize;
        private System.Windows.Forms.Button btnSortDate;
        private System.Windows.Forms.Button btnAbout;
    }
}

