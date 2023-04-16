using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace LogicLibrary
{
    public class Book : ILibraryItem
    {
        [BsonId]
        public ObjectId Id { get; set; }
        [BsonIgnoreIfDefault]
        public bool IsDeleted { get; set; }
        public string Title { get; set; }
        public string[] Authors { get; set; } = Array.Empty<string>();
        public string Field { get; set; }
        public string[]? Categories { get; set; } = Array.Empty<string>();
        public string Publisher { get; set; }
        public int PublicationYear { get; set; }
        public string PublicationYearString
        {
            get
            {
                if (PublicationYear == 0)
                {
                    return "Brak informacji";
                }
                else
                {
                    return PublicationYear.ToString();
                }
            }
        }
        public string[]? ISBNs { get; set; } = Array.Empty<string>();
        public string? Language { get; set; }
        public int NumberOfPages { get; set; }
        public string NumberOfPagesString
        {
            get
            {
                if (NumberOfPages == 0)
                {
                    return "Brak informacji";
                }
                else
                {
                    return NumberOfPages.ToString();
                }
            }
        }
        public string? Details { get; set; }
        public bool IsEbook { get; set; }
        public ObjectId EbookId { get; set; }
        public ObjectId CoverId { get; set; }
        [BsonIgnore]
        public Image CoverImage { get; set; }
        public string InventoryNumber { get; set; }
        public bool IsBorrowed { get; set; }
        public ObjectId BorrowedBy { get; set;  }
        [BsonIgnoreIfDefault]
        public int LastPage { get; set; } = 0;

        public Book()
        {
            
        }

        public Book(Book book)
        {
            Id = book.Id;
            Title = book.Title;
            Authors = book.Authors;
            Field = book.Field;
            Categories = book.Categories;
            Publisher = book.Publisher;
            PublicationYear = book.PublicationYear;
            ISBNs = book.ISBNs;
            Language = book.Language;
            NumberOfPages = book.NumberOfPages;
            Details = book.Details;
            IsEbook = book.IsEbook;
            EbookId = book.EbookId;
            CoverId = book.CoverId;
            CoverImage = book.CoverImage;
            InventoryNumber = book.InventoryNumber;
            IsBorrowed= book.IsBorrowed;
            BorrowedBy= book.BorrowedBy;
            LastPage = book.LastPage;
        }

        public Book(Volume volume)
        {
            Title = volume.volumeInfo.title;
            Authors = volume.volumeInfo.authors;
            Categories = volume.volumeInfo.categories;
            Publisher = volume.volumeInfo.publisher;
            if (!string.IsNullOrEmpty(volume.volumeInfo.publishedDate))
            {
                PublicationYear = int.Parse(volume.volumeInfo.publishedDate.Substring(0, 4));
            }
            if (volume.volumeInfo.industryIdentifiers != null) {
                int identifierAmount = volume.volumeInfo.industryIdentifiers.Length;
                ISBNs = new string[identifierAmount];
                for(int i = 0; i < identifierAmount; i++)
                {
                    if(volume.volumeInfo.industryIdentifiers[i].type == "ISBN_13" || volume.volumeInfo.industryIdentifiers[i].type == "ISBN_10")
                    ISBNs[i] = volume.volumeInfo.industryIdentifiers[i].identifier;
                }
            }
            Language = volume.volumeInfo.language;
            NumberOfPages = (int)volume.volumeInfo.pageCount;
            Details = "";
        }

        public void SetAuthorsFromString(string input)
        {
            Authors = input.Split(';');
            for (int i = 0; i < Authors.Length; i++)
            {
                Authors[i] = Regex.Replace(Authors[i], @"\A\s*|\s*\z", "");
            }
        }

        public void SetCategoriesFromString(string input)
        {
            Categories = input.Split(';');
            for (int i = 0; i < Categories.Length; i++)
            {
                Categories[i] = Regex.Replace(Categories[i], @"\A\s|\s\z", "");
            }
        }

        public void SetISBNsFromString(string input)
        {
            ISBNs = input.Split(';');
            for (int i = 0; i < ISBNs.Length; i++)
            {
                ISBNs[i] = Regex.Replace(ISBNs[i], @"\A\s|\s\z", "");
            }
        }

        public string GetAuthorsAsString()
        {
            string output = "";
            if (Authors != null)
            {
                foreach (string author in Authors)
                {
                    output += author;
                    if (author != Authors.Last())
                    {
                        output += "; ";
                    }
                }
            }
            return output;
        }

        public string GetCategoriesAsString()
        {
            string output = "";
            if (Categories != null)
            {
                foreach (string category in Categories)
                {
                    output += category;
                    if (category != Categories.Last())
                    {
                        output += "; ";
                    }
                }
            }
            return output;
        }

        public string GetISBNsAsString()
        {
            string output = "";
            foreach (string ISBN in ISBNs)
            {
                output += ISBN;
                if (ISBN != ISBNs.Last())
                {
                    output += "; ";
                }
            }
            return output;
        }
    }
}

