using MongoDB.Bson;
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
    public partial class BookViewerForm : Form
    {
        private Book Book { get ; set; }

        public BookViewerForm(Book book)
        {
            InitializeComponent();
            Book = book;
            OutputEbook.Text = book.IsEbook ? "[Ebook]" : null;
            if(book.Id != BsonObjectId.Empty)
                OutputAvailable.Text = book.IsBorrowed ? "Wypożyczona" : "Dostępna";
            outputTitle.Text = book.Title;
            if (book.Authors != null)
            {
                foreach (string a in book.Authors)
                {
                    o.Text += a;
                    if (a != book.Authors.Last())
                    {
                        o.Text += ", ";
                    }
                }
            }
            outputField.Text = book.Field;
            if (book.Categories != null)
            {
                if (book.Categories.Length <= 1 && string.IsNullOrEmpty(book.GetCategoriesAsString()))
                {
                    outputCategory.Text = "Inne";
                }
                else
                {
                    foreach (string c in book.Categories)
                    {
                        outputCategory.Text += c;
                        if (c != book.Categories.Last())
                        {
                            outputCategory.Text += ", ";
                        }
                    }
                }
            }
            outputPublisher.Text = book.Publisher;
            outputPublicationYear.Text = book.PublicationYearString;
            if (book.ISBNs != null)
            {
                foreach (string i in book.ISBNs)
                {
                    outputISBN.Text += i;
                    if (i != book.ISBNs.Last())
                    {
                        outputISBN.Text += ", ";
                    }
                }
            }
            outputLanguage.Text = book.Language;
            outputPages.Text = book.NumberOfPagesString;
            outputInventoryNumber.Text = book.InventoryNumber;
            outputDescription.Text = book.Details;

            if (Session.ActiveUserId == book.BorrowedBy && book.IsEbook)
            {
                buttonView.Visible = true;
            }

            if (Session.CanBorrowEbooksByself && book.IsEbook && !book.IsBorrowed)
            {
                buttonBorrowByself.Visible = true;
            }

            BookCatalog catalog = new BookCatalog();
            catalog.FindItems("books", nameof(book.Field), book.Field, book.Id);
            if(catalog.ItemControls.Length> 5) 
            {
                Random rnd = new Random();
                for (int i = 0; i < 5; i++) {
                    similarBooksList.AddItem(catalog.ItemControls[rnd.Next(0, catalog.ItemControls.Length)]);
                }
            }
            else
            {
                similarBooksList.AddItems(catalog.ItemControls);
            }
        }

        private void buttonView_Click(object sender, EventArgs e)
        {
            Stream stream = BookCRUD.GetEbookFile(Book.EbookId);
            EbookDisplayForm display = new EbookDisplayForm(stream, Book);
            display.ShowDialog();
        }

        private void buttonBorrowByself_Click(object sender, EventArgs e)
        {
            string result = BorrowingCRUD.BorrowBookToSelf(Book);
            if (result == null)
            {
                buttonBorrowByself.Visible = false;
                buttonView.Visible = true;
                MessageBox.Show("Książka została wypożyczona");
            }
            else
            {
                MessageBox.Show(result);
            }
        }
    }
}
