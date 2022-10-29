namespace Lab6.WinPrint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.PageSetupBtn = new System.Windows.Forms.Button();
            this.PrintBtn = new System.Windows.Forms.Button();
            this.PrintPreviewBtn = new System.Windows.Forms.Button();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // PageSetupBtn
            // 
            this.PageSetupBtn.Location = new System.Drawing.Point(648, 52);
            this.PageSetupBtn.Name = "PageSetupBtn";
            this.PageSetupBtn.Size = new System.Drawing.Size(110, 29);
            this.PageSetupBtn.TabIndex = 0;
            this.PageSetupBtn.Text = "Page Setup";
            this.PageSetupBtn.UseVisualStyleBackColor = true;
            this.PageSetupBtn.Click += new System.EventHandler(this.PageSetupBtn_Click);
            // 
            // PrintBtn
            // 
            this.PrintBtn.Location = new System.Drawing.Point(648, 116);
            this.PrintBtn.Name = "PrintBtn";
            this.PrintBtn.Size = new System.Drawing.Size(110, 29);
            this.PrintBtn.TabIndex = 1;
            this.PrintBtn.Text = "Print";
            this.PrintBtn.UseVisualStyleBackColor = true;
            this.PrintBtn.Click += new System.EventHandler(this.PrintBtn_Click);
            // 
            // PrintPreviewBtn
            // 
            this.PrintPreviewBtn.Location = new System.Drawing.Point(648, 187);
            this.PrintPreviewBtn.Name = "PrintPreviewBtn";
            this.PrintPreviewBtn.Size = new System.Drawing.Size(110, 29);
            this.PrintPreviewBtn.TabIndex = 2;
            this.PrintPreviewBtn.Text = "Print Preview";
            this.PrintPreviewBtn.UseVisualStyleBackColor = true;
            this.PrintPreviewBtn.Click += new System.EventHandler(this.PrintPreviewBtn_Click);
            // 
            // pageSetupDialog1
            // 
            this.pageSetupDialog1.Document = this.printDocument1;
            // 
            // printDialog1
            // 
            this.printDialog1.AllowSomePages = true;
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text Files | *.txt";
            // 
            // OpenFileBtn
            // 
            this.OpenFileBtn.Location = new System.Drawing.Point(653, 261);
            this.OpenFileBtn.Name = "OpenFileBtn";
            this.OpenFileBtn.Size = new System.Drawing.Size(94, 29);
            this.OpenFileBtn.TabIndex = 3;
            this.OpenFileBtn.Text = "Open File";
            this.OpenFileBtn.UseVisualStyleBackColor = true;
            this.OpenFileBtn.Click += new System.EventHandler(this.OpenFileBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.OpenFileBtn);
            this.Controls.Add(this.PrintPreviewBtn);
            this.Controls.Add(this.PrintBtn);
            this.Controls.Add(this.PageSetupBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button PageSetupBtn;
        private Button PrintBtn;
        private Button PrintPreviewBtn;
        private PageSetupDialog pageSetupDialog1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private OpenFileDialog openFileDialog1;
        private Button OpenFileBtn;
    }
}