namespace WordCount
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOpenDir = new System.Windows.Forms.Button();
            this.lbListFiles = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbOrdeByQuantity = new System.Windows.Forms.RadioButton();
            this.rbOrdeByName = new System.Windows.Forms.RadioButton();
            this.lbWords = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOpenDir);
            this.groupBox1.Controls.Add(this.lbListFiles);
            this.groupBox1.Location = new System.Drawing.Point(22, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 275);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список текстовых файлов";
            // 
            // btnOpenDir
            // 
            this.btnOpenDir.Location = new System.Drawing.Point(6, 30);
            this.btnOpenDir.Name = "btnOpenDir";
            this.btnOpenDir.Size = new System.Drawing.Size(75, 23);
            this.btnOpenDir.TabIndex = 1;
            this.btnOpenDir.Text = "Папка";
            this.btnOpenDir.UseVisualStyleBackColor = true;
            this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
            // 
            // lbListFiles
            // 
            this.lbListFiles.FormattingEnabled = true;
            this.lbListFiles.Location = new System.Drawing.Point(6, 68);
            this.lbListFiles.Name = "lbListFiles";
            this.lbListFiles.Size = new System.Drawing.Size(209, 199);
            this.lbListFiles.TabIndex = 0;
            this.lbListFiles.DoubleClick += new System.EventHandler(this.lbListFiles_DoubleClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.rbOrdeByQuantity);
            this.groupBox2.Controls.Add(this.rbOrdeByName);
            this.groupBox2.Controls.Add(this.lbWords);
            this.groupBox2.Location = new System.Drawing.Point(277, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(285, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Список слов";
            // 
            // rbOrdeByQuantity
            // 
            this.rbOrdeByQuantity.AutoSize = true;
            this.rbOrdeByQuantity.Location = new System.Drawing.Point(6, 400);
            this.rbOrdeByQuantity.Name = "rbOrdeByQuantity";
            this.rbOrdeByQuantity.Size = new System.Drawing.Size(99, 17);
            this.rbOrdeByQuantity.TabIndex = 2;
            this.rbOrdeByQuantity.TabStop = true;
            this.rbOrdeByQuantity.Text = "По количеству";
            this.rbOrdeByQuantity.UseVisualStyleBackColor = true;
            this.rbOrdeByQuantity.CheckedChanged += new System.EventHandler(this.rbOrdeByQuantity_CheckedChanged);
            // 
            // rbOrdeByName
            // 
            this.rbOrdeByName.AutoSize = true;
            this.rbOrdeByName.Location = new System.Drawing.Point(6, 377);
            this.rbOrdeByName.Name = "rbOrdeByName";
            this.rbOrdeByName.Size = new System.Drawing.Size(90, 17);
            this.rbOrdeByName.TabIndex = 1;
            this.rbOrdeByName.TabStop = true;
            this.rbOrdeByName.Text = "По алфавиту";
            this.rbOrdeByName.UseVisualStyleBackColor = true;
            // 
            // lbWords
            // 
            this.lbWords.FormattingEnabled = true;
            this.lbWords.Location = new System.Drawing.Point(6, 16);
            this.lbWords.Name = "lbWords";
            this.lbWords.Size = new System.Drawing.Size(273, 355);
            this.lbWords.TabIndex = 0;
            this.lbWords.DoubleClick += new System.EventHandler(this.lbWords_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 400);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Количество слов: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOpenDir;
        private System.Windows.Forms.ListBox lbListFiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbOrdeByQuantity;
        private System.Windows.Forms.RadioButton rbOrdeByName;
        private System.Windows.Forms.ListBox lbWords;
        private System.Windows.Forms.Label label1;
    }
}

