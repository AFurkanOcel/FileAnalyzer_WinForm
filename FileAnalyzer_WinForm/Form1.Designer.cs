namespace FileAnalyzer_WinForm
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
            this.FolderPictureBox = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SelectFolderButton = new System.Windows.Forms.Button();
            this.FolderPathText = new System.Windows.Forms.RichTextBox();
            this.AnalyzeButton = new System.Windows.Forms.Button();
            this.ExportButton = new System.Windows.Forms.Button();
            this.AnalyzeText = new System.Windows.Forms.RichTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCheckBox = new System.Windows.Forms.CheckBox();
            this.docxCheckBox = new System.Windows.Forms.CheckBox();
            this.pdfCheckBox = new System.Windows.Forms.CheckBox();
            this.FileTypeLabel = new System.Windows.Forms.Label();
            this.AnalyzeBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.FolderPictureBox)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // FolderPictureBox
            // 
            this.FolderPictureBox.Image = global::FileAnalyzer_WinForm.Properties.Resources.Folder;
            this.FolderPictureBox.Location = new System.Drawing.Point(26, 144);
            this.FolderPictureBox.Name = "FolderPictureBox";
            this.FolderPictureBox.Size = new System.Drawing.Size(40, 36);
            this.FolderPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.FolderPictureBox.TabIndex = 9;
            this.FolderPictureBox.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // SelectFolderButton
            // 
            this.SelectFolderButton.BackColor = System.Drawing.Color.Gainsboro;
            this.SelectFolderButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SelectFolderButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SelectFolderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SelectFolderButton.Location = new System.Drawing.Point(26, 88);
            this.SelectFolderButton.Name = "SelectFolderButton";
            this.SelectFolderButton.Size = new System.Drawing.Size(303, 46);
            this.SelectFolderButton.TabIndex = 10;
            this.SelectFolderButton.Text = "Select Folder";
            this.SelectFolderButton.UseVisualStyleBackColor = false;
            this.SelectFolderButton.Click += new System.EventHandler(this.SelectFolderButton_Click);
            // 
            // FolderPathText
            // 
            this.FolderPathText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FolderPathText.Location = new System.Drawing.Point(73, 148);
            this.FolderPathText.Name = "FolderPathText";
            this.FolderPathText.Size = new System.Drawing.Size(256, 32);
            this.FolderPathText.TabIndex = 0;
            this.FolderPathText.Text = "";
            // 
            // AnalyzeButton
            // 
            this.AnalyzeButton.BackColor = System.Drawing.Color.Gainsboro;
            this.AnalyzeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AnalyzeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.AnalyzeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AnalyzeButton.Location = new System.Drawing.Point(26, 197);
            this.AnalyzeButton.Name = "AnalyzeButton";
            this.AnalyzeButton.Size = new System.Drawing.Size(303, 46);
            this.AnalyzeButton.TabIndex = 11;
            this.AnalyzeButton.Text = "Analyze";
            this.AnalyzeButton.UseVisualStyleBackColor = false;
            this.AnalyzeButton.Click += new System.EventHandler(this.AnalyzeButton_Click);
            // 
            // ExportButton
            // 
            this.ExportButton.BackColor = System.Drawing.Color.Gainsboro;
            this.ExportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ExportButton.Location = new System.Drawing.Point(26, 419);
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.Size = new System.Drawing.Size(303, 46);
            this.ExportButton.TabIndex = 12;
            this.ExportButton.Text = "Export";
            this.ExportButton.UseVisualStyleBackColor = false;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // AnalyzeText
            // 
            this.AnalyzeText.Location = new System.Drawing.Point(-2, -2);
            this.AnalyzeText.Name = "AnalyzeText";
            this.AnalyzeText.Size = new System.Drawing.Size(303, 142);
            this.AnalyzeText.TabIndex = 0;
            this.AnalyzeText.Text = "";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Black;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.AnalyzeText);
            this.panel2.Location = new System.Drawing.Point(26, 259);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(303, 142);
            this.panel2.TabIndex = 1;
            // 
            // txtCheckBox
            // 
            this.txtCheckBox.AutoSize = true;
            this.txtCheckBox.Checked = true;
            this.txtCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.txtCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtCheckBox.Location = new System.Drawing.Point(26, 53);
            this.txtCheckBox.Name = "txtCheckBox";
            this.txtCheckBox.Size = new System.Drawing.Size(59, 29);
            this.txtCheckBox.TabIndex = 13;
            this.txtCheckBox.Text = ".txt";
            this.txtCheckBox.UseVisualStyleBackColor = true;
            // 
            // docxCheckBox
            // 
            this.docxCheckBox.AutoSize = true;
            this.docxCheckBox.Checked = true;
            this.docxCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.docxCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.docxCheckBox.Location = new System.Drawing.Point(91, 53);
            this.docxCheckBox.Name = "docxCheckBox";
            this.docxCheckBox.Size = new System.Drawing.Size(81, 29);
            this.docxCheckBox.TabIndex = 14;
            this.docxCheckBox.Text = ".docx";
            this.docxCheckBox.UseVisualStyleBackColor = true;
            // 
            // pdfCheckBox
            // 
            this.pdfCheckBox.AutoSize = true;
            this.pdfCheckBox.Checked = true;
            this.pdfCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.pdfCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.pdfCheckBox.Location = new System.Drawing.Point(178, 53);
            this.pdfCheckBox.Name = "pdfCheckBox";
            this.pdfCheckBox.Size = new System.Drawing.Size(66, 29);
            this.pdfCheckBox.TabIndex = 15;
            this.pdfCheckBox.Text = ".pdf";
            this.pdfCheckBox.UseVisualStyleBackColor = true;
            // 
            // FileTypeLabel
            // 
            this.FileTypeLabel.AutoSize = true;
            this.FileTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FileTypeLabel.Location = new System.Drawing.Point(20, 18);
            this.FileTypeLabel.Name = "FileTypeLabel";
            this.FileTypeLabel.Size = new System.Drawing.Size(131, 32);
            this.FileTypeLabel.TabIndex = 16;
            this.FileTypeLabel.Text = "File Type";
            // 
            // AnalyzeBar
            // 
            this.AnalyzeBar.BackColor = System.Drawing.Color.Gainsboro;
            this.AnalyzeBar.Location = new System.Drawing.Point(26, 233);
            this.AnalyzeBar.Name = "AnalyzeBar";
            this.AnalyzeBar.Size = new System.Drawing.Size(303, 10);
            this.AnalyzeBar.Step = 100;
            this.AnalyzeBar.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(341, 487);
            this.Controls.Add(this.AnalyzeBar);
            this.Controls.Add(this.FileTypeLabel);
            this.Controls.Add(this.pdfCheckBox);
            this.Controls.Add(this.docxCheckBox);
            this.Controls.Add(this.txtCheckBox);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.AnalyzeButton);
            this.Controls.Add(this.FolderPathText);
            this.Controls.Add(this.SelectFolderButton);
            this.Controls.Add(this.FolderPictureBox);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "File Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FolderPictureBox)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox FolderPictureBox;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button SelectFolderButton;
        private System.Windows.Forms.RichTextBox FolderPathText;
        private System.Windows.Forms.Button AnalyzeButton;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.RichTextBox AnalyzeText;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox txtCheckBox;
        private System.Windows.Forms.CheckBox docxCheckBox;
        private System.Windows.Forms.CheckBox pdfCheckBox;
        private System.Windows.Forms.Label FileTypeLabel;
        private System.Windows.Forms.ProgressBar AnalyzeBar;
    }
}

