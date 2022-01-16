namespace LearnWord
{
    partial class checkWords
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(checkWords));
            this.wordsDataGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.EnglishLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.NoMistakeLabel = new System.Windows.Forms.Label();
            this.DiduntillNowLabel = new System.Windows.Forms.Label();
            this.database41DataSet1 = new LearnWord.Database41DataSet();
            this.wordsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wordsTableAdapter1 = new LearnWord.Database41DataSetTableAdapters.wordsTableAdapter();
            this.tableAdapterManager1 = new LearnWord.Database41DataSetTableAdapters.TableAdapterManager();
            this.wordsDataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.englishDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hebrewDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalLabel = new System.Windows.Forms.Label();
            this.gradeLabel = new System.Windows.Forms.Label();
            this.correctLabel = new System.Windows.Forms.Label();
            this.wereStatusLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.skippedWordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database41DataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // wordsDataGridView
            // 
            this.wordsDataGridView.AllowUserToAddRows = false;
            this.wordsDataGridView.AllowUserToDeleteRows = false;
            this.wordsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordsDataGridView.Location = new System.Drawing.Point(12, 39);
            this.wordsDataGridView.Name = "wordsDataGridView";
            this.wordsDataGridView.ReadOnly = true;
            this.wordsDataGridView.Size = new System.Drawing.Size(10, 14);
            this.wordsDataGridView.TabIndex = 1;
            this.wordsDataGridView.Visible = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 251);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = ":באנגלית";
            // 
            // EnglishLabel
            // 
            this.EnglishLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EnglishLabel.AutoSize = true;
            this.EnglishLabel.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnglishLabel.Location = new System.Drawing.Point(500, 297);
            this.EnglishLabel.Name = "EnglishLabel";
            this.EnglishLabel.Size = new System.Drawing.Size(97, 34);
            this.EnglishLabel.TabIndex = 3;
            this.EnglishLabel.Text = "label2";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(556, 365);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = ":בעברית";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.textBox1.Location = new System.Drawing.Point(189, 400);
            this.textBox1.Name = "textBox1";
            this.textBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textBox1.Size = new System.Drawing.Size(629, 44);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // NoMistakeLabel
            // 
            this.NoMistakeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NoMistakeLabel.AutoSize = true;
            this.NoMistakeLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.NoMistakeLabel.Location = new System.Drawing.Point(340, 9);
            this.NoMistakeLabel.Name = "NoMistakeLabel";
            this.NoMistakeLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NoMistakeLabel.Size = new System.Drawing.Size(88, 24);
            this.NoMistakeLabel.TabIndex = 7;
            this.NoMistakeLabel.Text = ":באנגלית";
            // 
            // DiduntillNowLabel
            // 
            this.DiduntillNowLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DiduntillNowLabel.AutoSize = true;
            this.DiduntillNowLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.DiduntillNowLabel.Location = new System.Drawing.Point(340, 36);
            this.DiduntillNowLabel.Name = "DiduntillNowLabel";
            this.DiduntillNowLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.DiduntillNowLabel.Size = new System.Drawing.Size(88, 24);
            this.DiduntillNowLabel.TabIndex = 8;
            this.DiduntillNowLabel.Text = ":באנגלית";
            // 
            // database41DataSet1
            // 
            this.database41DataSet1.DataSetName = "Database41DataSet";
            this.database41DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // wordsBindingSource
            // 
            this.wordsBindingSource.DataMember = "Words";
            this.wordsBindingSource.DataSource = this.database41DataSet1;
            // 
            // wordsTableAdapter1
            // 
            this.wordsTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = LearnWord.Database41DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.wordsTableAdapter = this.wordsTableAdapter1;
            // 
            // wordsDataGridView1
            // 
            this.wordsDataGridView1.AllowUserToAddRows = false;
            this.wordsDataGridView1.AllowUserToDeleteRows = false;
            this.wordsDataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wordsDataGridView1.AutoGenerateColumns = false;
            this.wordsDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.wordsDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.englishDataGridViewTextBoxColumn,
            this.hebrewDataGridViewTextBoxColumn});
            this.wordsDataGridView1.DataSource = this.wordsBindingSource;
            this.wordsDataGridView1.Location = new System.Drawing.Point(21, 448);
            this.wordsDataGridView1.Name = "wordsDataGridView1";
            this.wordsDataGridView1.ReadOnly = true;
            this.wordsDataGridView1.Size = new System.Drawing.Size(66, 90);
            this.wordsDataGridView1.TabIndex = 9;
            this.wordsDataGridView1.Visible = false;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // englishDataGridViewTextBoxColumn
            // 
            this.englishDataGridViewTextBoxColumn.DataPropertyName = "english";
            this.englishDataGridViewTextBoxColumn.HeaderText = "english";
            this.englishDataGridViewTextBoxColumn.Name = "englishDataGridViewTextBoxColumn";
            this.englishDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hebrewDataGridViewTextBoxColumn
            // 
            this.hebrewDataGridViewTextBoxColumn.DataPropertyName = "hebrew";
            this.hebrewDataGridViewTextBoxColumn.HeaderText = "hebrew";
            this.hebrewDataGridViewTextBoxColumn.Name = "hebrewDataGridViewTextBoxColumn";
            this.hebrewDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalLabel
            // 
            this.totalLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.totalLabel.AutoSize = true;
            this.totalLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.totalLabel.Location = new System.Drawing.Point(340, 71);
            this.totalLabel.Name = "totalLabel";
            this.totalLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.totalLabel.Size = new System.Drawing.Size(88, 24);
            this.totalLabel.TabIndex = 10;
            this.totalLabel.Text = ":באנגלית";
            // 
            // gradeLabel
            // 
            this.gradeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gradeLabel.AutoSize = true;
            this.gradeLabel.Font = new System.Drawing.Font("Stencil", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gradeLabel.Location = new System.Drawing.Point(253, 251);
            this.gradeLabel.Name = "gradeLabel";
            this.gradeLabel.Size = new System.Drawing.Size(104, 114);
            this.gradeLabel.TabIndex = 11;
            this.gradeLabel.Text = "0";
            // 
            // correctLabel
            // 
            this.correctLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.correctLabel.AutoSize = true;
            this.correctLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.correctLabel.Location = new System.Drawing.Point(340, 109);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.correctLabel.Size = new System.Drawing.Size(88, 24);
            this.correctLabel.TabIndex = 12;
            this.correctLabel.Text = ":באנגלית";
            // 
            // wereStatusLabel
            // 
            this.wereStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.wereStatusLabel.AutoSize = true;
            this.wereStatusLabel.Font = new System.Drawing.Font("David", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wereStatusLabel.ForeColor = System.Drawing.Color.Blue;
            this.wereStatusLabel.Location = new System.Drawing.Point(560, 670);
            this.wereStatusLabel.Name = "wereStatusLabel";
            this.wereStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.wereStatusLabel.Size = new System.Drawing.Size(127, 32);
            this.wereStatusLabel.TabIndex = 13;
            this.wereStatusLabel.Text = ":באנגלית";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LearnWord.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 78);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // skippedWordLabel
            // 
            this.skippedWordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.skippedWordLabel.AutoSize = true;
            this.skippedWordLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.skippedWordLabel.Location = new System.Drawing.Point(340, 145);
            this.skippedWordLabel.Name = "skippedWordLabel";
            this.skippedWordLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.skippedWordLabel.Size = new System.Drawing.Size(144, 24);
            this.skippedWordLabel.TabIndex = 14;
            this.skippedWordLabel.Text = "מילים שדולגו: 0";
            // 
            // checkWords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1209, 711);
            this.Controls.Add(this.skippedWordLabel);
            this.Controls.Add(this.wereStatusLabel);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.gradeLabel);
            this.Controls.Add(this.totalLabel);
            this.Controls.Add(this.wordsDataGridView1);
            this.Controls.Add(this.DiduntillNowLabel);
            this.Controls.Add(this.NoMistakeLabel);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EnglishLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.wordsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "checkWords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database41DataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wordsDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Database41DataSet database41DataSet;
        private Database41DataSetTableAdapters.wordsTableAdapter wordsTableAdapter;
        private Database41DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView wordsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label EnglishLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label NoMistakeLabel;
        private System.Windows.Forms.Label DiduntillNowLabel;
        private Database41DataSet database41DataSet1;
        private System.Windows.Forms.BindingSource wordsBindingSource;
        private Database41DataSetTableAdapters.wordsTableAdapter wordsTableAdapter1;
        private Database41DataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView wordsDataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn englishDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hebrewDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label totalLabel;
        private System.Windows.Forms.Label gradeLabel;
        private System.Windows.Forms.Label correctLabel;
        private System.Windows.Forms.Label wereStatusLabel;
        private System.Windows.Forms.Label skippedWordLabel;
    }
}

