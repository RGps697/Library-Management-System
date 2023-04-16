namespace UserInterfaceLibrary
{
    partial class EbookDisplayForm
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
            this.pdfRenderer = new PdfiumViewer.PdfRenderer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.labelNumberOfPages = new System.Windows.Forms.Label();
            this.textBoxCurrentPage = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfRenderer
            // 
            this.pdfRenderer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfRenderer.Location = new System.Drawing.Point(14, 42);
            this.pdfRenderer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pdfRenderer.Name = "pdfRenderer";
            this.pdfRenderer.Page = 0;
            this.pdfRenderer.Rotation = PdfiumViewer.PdfRotation.Rotate0;
            this.pdfRenderer.Size = new System.Drawing.Size(906, 504);
            this.pdfRenderer.TabIndex = 2;
            this.pdfRenderer.Text = "pdfRenderer1";
            this.pdfRenderer.ZoomMode = PdfiumViewer.PdfViewerZoomMode.FitHeight;
            this.pdfRenderer.Scroll += new System.Windows.Forms.ScrollEventHandler(this.pdfRenderer_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonNext);
            this.panel1.Controls.Add(this.buttonPrevious);
            this.panel1.Controls.Add(this.labelNumberOfPages);
            this.panel1.Controls.Add(this.textBoxCurrentPage);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(933, 36);
            this.panel1.TabIndex = 3;
            // 
            // buttonNext
            // 
            this.buttonNext.Location = new System.Drawing.Point(532, 0);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(27, 36);
            this.buttonNext.TabIndex = 3;
            this.buttonNext.Text = ">";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Location = new System.Drawing.Point(371, 0);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(27, 36);
            this.buttonPrevious.TabIndex = 2;
            this.buttonPrevious.Text = "<";
            this.buttonPrevious.UseVisualStyleBackColor = true;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // labelNumberOfPages
            // 
            this.labelNumberOfPages.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNumberOfPages.AutoSize = true;
            this.labelNumberOfPages.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNumberOfPages.Location = new System.Drawing.Point(476, 5);
            this.labelNumberOfPages.MinimumSize = new System.Drawing.Size(50, 0);
            this.labelNumberOfPages.Name = "labelNumberOfPages";
            this.labelNumberOfPages.Size = new System.Drawing.Size(50, 21);
            this.labelNumberOfPages.TabIndex = 1;
            // 
            // textBoxCurrentPage
            // 
            this.textBoxCurrentPage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxCurrentPage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBoxCurrentPage.Location = new System.Drawing.Point(405, 4);
            this.textBoxCurrentPage.MaxLength = 5;
            this.textBoxCurrentPage.Name = "textBoxCurrentPage";
            this.textBoxCurrentPage.Size = new System.Drawing.Size(65, 27);
            this.textBoxCurrentPage.TabIndex = 0;
            this.textBoxCurrentPage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxCurrentPage.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCurrentPage_KeyPress);
            // 
            // EbookDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(933, 560);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pdfRenderer);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "EbookDisplayForm";
            this.Text = "Czytnik E-book";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EbookDisplayForm_FormClosing);
            this.Resize += new System.EventHandler(this.EbookDisplayForm_Resize);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private PdfiumViewer.PdfRenderer pdfRenderer;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelNumberOfPages;
        private System.Windows.Forms.TextBox textBoxCurrentPage;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.Button buttonNext;
    }
}