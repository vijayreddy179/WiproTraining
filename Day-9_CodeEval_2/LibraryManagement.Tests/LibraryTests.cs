namespace LibraryManagement.Tests
{
    public class LibraryTests
    {
        private Library library;
        private Book book;
        private Borrower borrower;

        [SetUp]
        public void Setup()
        {
            library = new Library();
            book = new Book("God of Small Things", "Arundhati Roy", "ISBN123");
            borrower = new Borrower("Vijay", "CARD001");
        }

        [Test]
        public void AddBook_BookIsAdded()
        {
            library.AddBook(book);
            Assert.AreEqual(1, library.Books.Count);
        }

        [Test]
        public void RegisterBorrower_BorrowerIsRegistered()
        {
            library.RegisterBorrower(borrower);
            Assert.AreEqual(1, library.Borrowers.Count);
        }

        [Test]
        public void BorrowBook_BookIsMarkedAsBorrowed()
        {
            library.AddBook(book);
            library.RegisterBorrower(borrower);

            library.BorrowBook("ISBN123", "CARD001");

            Assert.IsTrue(book.IsBorrowed);
            Assert.AreEqual(1, borrower.BorrowedBooks.Count);
        }

        [Test]
        public void ReturnBook_BookIsReturned()
        {
            library.AddBook(book);
            library.RegisterBorrower(borrower);
            library.BorrowBook("ISBN123", "CARD001");

            library.ReturnBook("ISBN123", "CARD001");

            Assert.IsFalse(book.IsBorrowed);
            Assert.AreEqual(0, borrower.BorrowedBooks.Count);
        }

        [Test]
        public void ViewBooks_ReturnsBooksList()
        {
            library.AddBook(book);
            Assert.AreEqual(1, library.ViewBooks().Count);
        }

        [Test]
        public void ViewBorrowers_ReturnsBorrowersList()
        {
            library.RegisterBorrower(borrower);
            Assert.AreEqual(1, library.ViewBorrowers().Count);
        }
    }
}