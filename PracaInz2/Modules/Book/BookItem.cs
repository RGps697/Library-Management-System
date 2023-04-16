using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterfaceLibrary
{
    [System.ComponentModel.ToolboxItem(false)]
    public partial class BookItem : UserControl, ICatalogItem
    {
        public ILibraryItem ContainedItem { get; set; }
        bool OpenCreator { get; set; }
        public Action<ISelectableItem> OnItemClick { get; set; }
        public bool IsSelected { get; set; } = false;
        public Action<ISelectableItem> onItemDoubleClick { get; set; }

        private BookItem()
        {
            InitializeComponent();

            ItemClickedEventWrapper(this);
            ItemClickedEventWrapper(icon);
            ItemClickedEventWrapper(bookDataPanel);
            ItemClickedEventWrapper(labelTitle);
            ItemClickedEventWrapper(labelAuthors);
            ItemClickedEventWrapper(labelCategories);
            ItemClickedEventWrapper(labelPages);
            ItemClickedEventWrapper(labelPublisher);
            ItemClickedEventWrapper(labelPublicationYear);
            ItemClickedEventWrapper(outputTitle);
            ItemClickedEventWrapper(outputAuthor);
            ItemClickedEventWrapper(outputCategory);
            ItemClickedEventWrapper(outputNumberOfPages);
            ItemClickedEventWrapper(outputPublisher);
            ItemClickedEventWrapper(outputPublicationYear);
        }

        public BookItem(Book book, bool openCreator = false) : this()
        {
            OpenCreator = openCreator;
            FillData(book);
        }

        private void ItemClickedEventWrapper(Control ctrl)
        {
            ctrl.Click += new EventHandler(ItemClicked);
            ctrl.MouseEnter += new EventHandler(OnHover);
            ctrl.MouseLeave += new EventHandler(OnLeave);
            ctrl.DoubleClick += new EventHandler(ItemDoubleClicked);
        }

        public void ItemClicked(object sender, EventArgs e)
        {
            if (OnItemClick != null)
            {
                OnItemClick(this);
            }
        }

        public void OnHover(object sender, EventArgs e)
        {
            if (!IsSelected)
                BackColor = UIColors.SelectableItemHoverColor;
        }

        public void OnLeave(object sender, EventArgs e)
        {
            if(!IsSelected)
                BackColor = UIColors.SelectableItemColor;
        }

        public void ItemDoubleClicked(object sender, EventArgs e)
        {
            Console.WriteLine($"openCreator: {OpenCreator}");
            if (OpenCreator && Session.CanEditBooks)
            {
                BookCreatorForm bookCreatorForm = new BookCreatorForm((Book)ContainedItem);
                DialogResult result = bookCreatorForm.ShowDialog();
                if(result == DialogResult.OK)
                {
                    ContainedItem = bookCreatorForm.Book;
                    FillData((Book)ContainedItem);
                }
            }
            else
            {
                BookViewerForm bookViewer = new BookViewerForm((Book)ContainedItem);
                bookViewer.ShowDialog();
            }
        }

        public void Selected()
        {
            BackColor = UIColors.SelectableItemSelectedColor;
        }

        public void Deselected()
        {
            BackColor = UIColors.SelectableItemColor;
        }

        private void FillData(Book book)
        {
            ContainedItem = book;
            if (book.CoverImage != null)
            {
                icon.Image = (new Bitmap(book.CoverImage, new Size(139,139)));
            }
            else if (book.IsEbook)
            {
                icon.Image = Icons.ebookIcon;
            }
            else
            {
                icon.Image = Icons.bookIcon;
            }
            outputTitle.Text = book.Title;
            if (book.Authors != null)
            {
                outputAuthor.Text = "";
                foreach (string a in book.Authors)
                {
                    outputAuthor.Text += a;
                    if (a != book.Authors.Last())
                    {
                        outputAuthor.Text += ", ";
                    }
                }
            }
            else
            {
                outputAuthor.Text = "Brak informacji";
            }
            if (book.Categories != null)
            {
                outputCategory.Text = "";
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
            else
            {
                outputCategory.Text = "Inne";
            }
            outputNumberOfPages.Text = book.NumberOfPagesString;
            if (!string.IsNullOrEmpty(book.Publisher))
            {
                outputPublisher.Text = book.Publisher;
            }
            else
            {
                outputPublisher.Text = "Brak informacji";
            }
            outputPublicationYear.Text = book.PublicationYearString;
        }

        private void bookDataPanel_Resize(object sender, EventArgs e)
        {
            outputTitle.MaximumSize= bookDataPanel.Size;
            outputAuthor.MaximumSize = bookDataPanel.Size;
            outputCategory.MaximumSize = bookDataPanel.Size;
            outputNumberOfPages.MaximumSize = bookDataPanel.Size;
        }
    }
}
