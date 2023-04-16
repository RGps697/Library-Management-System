using PdfiumViewer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLibrary
{
    public partial class EbookDisplayForm : Form
    {
        PdfDocument pdfDocument;
        Book Book { get; set; }
        int CurrentPage { get; set; }
        public EbookDisplayForm(Stream stream, Book book)
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
            pdfRenderer.MouseWheel += new MouseEventHandler(ScrollPage);
            Book = book;
            DisplayEbook(stream);
        }

        private void DisplayEbook(Stream stream)
        {
            pdfDocument = PdfDocument.Load(stream);
            pdfRenderer.Load(pdfDocument);
            pdfRenderer.Page = Book.LastPage;
            textBoxCurrentPage.Text = (Book.LastPage+1).ToString();
            labelNumberOfPages.Text = $"/ {pdfDocument.PageCount}";
        }

        private void textBoxCurrentPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                if (!((int.Parse(textBoxCurrentPage.Text) - 1) >= pdfDocument.PageCount))
                {
                    e.Handled = true;
                }
            }
            else if (e.KeyChar == 13)
            {
                if (int.Parse(textBoxCurrentPage.Text) > 0)
                {
                    pdfRenderer.Page = int.Parse(textBoxCurrentPage.Text) - 1;
                }
                else
                {
                    pdfRenderer.Page = 0;
                }
                e.Handled = true;
            }
        }

        private void EbookDisplayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Book.LastPage != pdfRenderer.Page)
            {
                Book.LastPage = pdfRenderer.Page;
                BookCRUD.UpdateBook(Book.Id, nameof(Book.LastPage), Book.LastPage);
            }
        }

        private void ScrollPage(object sender, MouseEventArgs e)
        {
            pdfRenderer_Scroll(this, null);
        }

        private void pdfRenderer_Scroll(object sender, ScrollEventArgs e)
        {
            textBoxCurrentPage.Text = (pdfRenderer.Page+1).ToString();
        }

        private void EbookDisplayForm_ResizeEnd(object sender, EventArgs e)
        {
            Screen myScreen = Screen.FromControl(this);
            Rectangle area = myScreen.WorkingArea;

            this.Top = (area.Height - this.Height) / 2;
            this.Left = (area.Width - this.Width) / 2;
        }

        private void EbookDisplayForm_Resize(object sender, EventArgs e)
        {
            textBoxCurrentPage.Left = ((this.ClientSize.Width - textBoxCurrentPage.Width) / 2) - textBoxCurrentPage.Width;

            labelNumberOfPages.Left = ((this.ClientSize.Width - labelNumberOfPages.Width) / 2);
            buttonNext.Left = ((this.ClientSize.Width - labelNumberOfPages.Width) / 2) + labelNumberOfPages.Width;
            buttonPrevious.Left = ((this.ClientSize.Width - labelNumberOfPages.Width) / 2) - buttonNext.Width - textBoxCurrentPage.Width - 10;
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            pdfRenderer.Page++;
            textBoxCurrentPage.Text = (pdfRenderer.Page+1).ToString();
        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            pdfRenderer.Page--;
            textBoxCurrentPage.Text = (pdfRenderer.Page + 1).ToString();
        }
    }
}
