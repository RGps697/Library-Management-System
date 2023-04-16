
namespace AutomatedTests
{
    public class BookTests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void BookSetTitle()
        {
            Book book = new Book();
            string testTitle = "Test Title";
            book.Title = testTitle;
            Assert.That(book.Title, Is.EqualTo(testTitle));
        }

        [Test]
        public void BookSetAuthorsFromString()
        {
            Book book = new Book();
            string testAuthor = "author1 name; author2 name";
            book.SetAuthorsFromString(testAuthor);
            string result = book.GetAuthorsAsString();
            Assert.That(result, Is.EqualTo(testAuthor));
        }

        [Test]
        public void BookSetCategoryFromString()
        {
            Book book = new Book();
            string testCategory = "category1; category2; category3";
            book.SetCategoriesFromString(testCategory);
            string result = book.GetCategoriesAsString();
            Assert.That(result, Is.EqualTo(testCategory));
        }


        [Test]
        public void BookSetPublisher()
        {
            Book book = new Book();
            string testPublisher = "Test Publisher";
            book.Publisher = testPublisher;
            Assert.That(book.Publisher, Is.EqualTo(testPublisher));
        }

        [Test]
        public void BookSetPublicationYear()
        {
            Book book = new Book();
            string testPublicationYear = "2017";
            book.PublicationYear = testPublicationYear;
            Assert.That(book.PublicationYear, Is.EqualTo(testPublicationYear));
        }

        [Test]
        public void BookSetISBNFromString()
        {
            Book book = new Book();
            string testISBN = "9998887777; 6665554444";
            book.SetISBNsFromString(testISBN);
            string result = book.GetISBNsAsString();
            Assert.That(result, Is.EqualTo(testISBN));
        }

        [Test]
        public void BookSetLanguage()
        {
            Book book = new Book();
            string testLanguage = "Polish";
            book.Language = testLanguage;
            Assert.That(book.Language, Is.EqualTo(testLanguage));
        }

        [Test]
        public void BookSetPageAmount()
        {
            Book book = new Book();
            uint testPages = 4000;
            book.NumberOfPages = testPages;
            Assert.That(book.NumberOfPages, Is.EqualTo(testPages));
        }

        [Test]
        public void BookSetDetails()
        {
            Book book = new Book();
            string testDetails = "This is test description";
            book.Details = testDetails;
            Assert.That(book.Details, Is.EqualTo(testDetails));
        }

        [Test]
        public void BookSetInventoryNumber()
        {
            Book book = new Book();
            string testInventoryNumber = "ABC/2074-14";
            book.InventoryNumber = testInventoryNumber;
            Assert.That(book.InventoryNumber, Is.EqualTo(testInventoryNumber));
        }


    }
}