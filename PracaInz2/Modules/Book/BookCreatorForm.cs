using MongoDB.Bson;
using SharpCompress.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLibrary
{
    public partial class BookCreatorForm : Form
    {
        public Book Book { get; set; } 
        private bool UpdateBook { get; set; } = false;
        private bool EbookFileRemoved { get; set; } = false;
        private bool BookCoverRemoved { get; set; } = false;
        Image BookCoverImage { get; set; }

        public BookCreatorForm()
        {
            if (!Session.CanAddBooks) throw new UnauthorizedAccessException("Missing privilege to add books");
            InitializeComponent();
            Book = new Book();
        }

        public BookCreatorForm(Book book, bool update = true)
        {
            if (!Session.CanEditBooks && update || (!Session.CanAddBooks && !update)) throw new UnauthorizedAccessException("Missing privilege to edit books");
            InitializeComponent();
            UpdateBook = update;
            Book = new Book(book);
            FillFormFields(book);
        }

        private void FillFormFields(Book book)
        {
            inputTitle.Text = book.Title;
            inputAuthors.Text = book.GetAuthorsAsString();
            inputField.Text = book.Field;
            inputCategories.Text = book.GetCategoriesAsString();
            inputPublisher.Text = book.Publisher;
            inputPubYear.Text = book.PublicationYear.ToString();
            inputISBN.Text = book.GetISBNsAsString();
            inputLanguage.Text = book.Language;
            inputPageAmount.Text = book.NumberOfPages.ToString();
            inputDetails.Text = book.Details;
            cbEbook.Checked = book.IsEbook;
            if (book.EbookId != ObjectId.Empty)
            {
                buttonDeleteEbook.Visible = true;
                cbEbook.Enabled = false;
                buttonAddEbookFile.Enabled = false;
            }
            inputInventoryNumber.Text = book.InventoryNumber;
            if (book.CoverId != BsonObjectId.Empty)
            {
                pictureBoxCover.Image = book.CoverImage;
            }
        }

        protected Book InsertDataToBook(Book book)
        {
            book.Title = inputTitle.Text;
            book.SetAuthorsFromString(inputAuthors.Text);
            book.Field = inputField.Text;
            book.SetCategoriesFromString(inputCategories.Text);
            book.Publisher = inputPublisher.Text;
            if (!string.IsNullOrEmpty(inputPubYear.Text))
            {
                int year;
                bool yearResult = int.TryParse(inputPubYear.Text, out year);
                if (yearResult)
                {
                    book.PublicationYear = year;
                }
                else
                {
                    book.PublicationYear = -1;
                }
            }
            book.SetISBNsFromString(inputISBN.Text);
            book.Language = inputLanguage.Text;
            if (!string.IsNullOrEmpty(inputPageAmount.Text)) {
                int pages;
                bool pageResult = int.TryParse(inputPageAmount.Text, out pages);
                book.NumberOfPages = pages;
                if (pageResult)
                {
                    book.NumberOfPages = pages;
                }
                else
                {
                    book.NumberOfPages = -1;
                }
            }
            book.Details = inputDetails.Text;

            book.IsEbook = cbEbook.Checked;
            book.InventoryNumber = inputInventoryNumber.Text;

            return book;
        }

        protected void buttonAdd_Click(object sender, EventArgs e)
        {
            Book = InsertDataToBook(Book);
            BookValidator validator = new BookValidator();
            var results = validator.Validate(Book);
            if (results.IsValid == false)
            {
                string errorMessage = "";
                foreach (var error in results.Errors)
                {
                    errorMessage += error.ErrorMessage + "\n";
                }
                MessageBox.Show(errorMessage);
            }
            else
            {
                string result;
                if (UpdateBook)
                {
                    result = BookCRUD.UpdateBook(Book, openFileDialogEbook.FileName, EbookFileRemoved, BookCoverImage, BookCoverRemoved);
                }
                else
                {
                    result = BookCRUD.InsertBook(Book, openFileDialogEbook.FileName, BookCoverImage);
                }

                if (result == null)
                {
                    MessageBox.Show("Książka została zapisana.");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(result);
                }
            }
        }

        private void cbEbook_CheckedChanged(object sender, EventArgs e)
        {
            buttonAddEbookFile.Enabled = cbEbook.Checked;
            if (!cbEbook.Checked)
            {
                labelFilePath.Text = null;
                openFileDialogEbook.FileName = null;
            }
        }

        private void buttonAddEbookFile_Click(object sender, EventArgs e)
        {
            if (openFileDialogEbook.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialogEbook.FileName))
                {
                    labelFilePath.Text = openFileDialogEbook.FileName;
                }
                else
                {
                    MessageBox.Show("Plik nie istnieje we wskazanym miejscu.");
                    openFileDialogEbook.FileName = null;
                }
            }
        }

        private void removeEbook_Click(object sender, EventArgs e)
        {
            EbookFileRemoved = true;
            buttonDeleteEbook.Visible = false;
            cbEbook.Enabled = true;
            cbEbook.Checked = false;
        }

        private void buttonAddCover_Click(object sender, EventArgs e)
        {
            if (openFileDialogCover.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialogCover.FileName))
                {
                    Debug.WriteLine($"creatoform: adding file");
                    BookCoverImage = ResizeImage(new Bitmap(openFileDialogCover.FileName));
                    pictureBoxCover.Image = BookCoverImage;

                    if(Book.CoverId != BsonObjectId.Empty)
                    {
                        BookCoverRemoved = true;
                    }
                }
                else 
                {
                    MessageBox.Show("Plik nie istnieje we wskazanym miejscu.");
                    openFileDialogEbook.FileName = null;
                }
            }
        }

        private void buttonRestoreDefault_Click(object sender, EventArgs e)
        {
            BookCoverRemoved = true;
            pictureBoxCover.Image = null;
            pictureBoxCover.Update();
        }


        private Bitmap ResizeImage(Bitmap file, float width = 300, float height = 350)
        {
            var brush = new SolidBrush(Color.Black);
            var image = new Bitmap(file);

            float scale = Math.Min(width / image.Width, height / image.Height);

            var bmp = new Bitmap((int)width, (int)height);
            var graph = Graphics.FromImage(bmp);

            graph.InterpolationMode = InterpolationMode.High;
            graph.CompositingQuality = CompositingQuality.HighQuality;
            graph.SmoothingMode = SmoothingMode.AntiAlias;

            var scaleWidth = (int)(image.Width * scale);
            var scaleHeight = (int)(image.Height * scale);

            graph.FillRectangle(brush, new RectangleF(0, 0, width, height));
            graph.DrawImage(image, ((int)width - scaleWidth) / 2, ((int)height - scaleHeight) / 2, scaleWidth, scaleHeight);

            return bmp;
        }
    }
}
