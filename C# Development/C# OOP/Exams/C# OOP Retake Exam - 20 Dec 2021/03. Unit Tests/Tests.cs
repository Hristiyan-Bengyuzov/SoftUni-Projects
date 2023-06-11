namespace Book.Tests
{
    using System;

    using NUnit.Framework;

    public class Tests
    {
        private Book book;
        private string bookName = "Pod igoto";
        private string author = "Ivan Vazov";

        [SetUp]
        public void SetUp()
        {
            book = new Book(bookName, author);
        }

        [Test]
        public void Test_ConstructorShouldWorkProperly()
        {
            Assert.AreEqual(author, book.Author);
            Assert.AreEqual(bookName, book.BookName);
            Assert.AreEqual(0, book.FootnoteCount);
        }

        [Test]
        [TestCase(null, "Ivan Vazov")]
        [TestCase("", "Ivan Vazov")]
        [TestCase("Pod igoto", null)]
        [TestCase("Pod igoto", "")]
        public void Test_ConstructorShouldThrowForInvalidInput(string bookName, string author)
        {
            Assert.Throws<ArgumentException>(() => new Book(bookName, author));
        }

        [Test]
        public void Test_AddFootNoteShouldWorkProperly()
        {
            book.AddFootnote(1, "test");
            Assert.AreEqual(1, book.FootnoteCount);
        }

        [Test]
        public void Test_AddFootNoteShouldThrow()
        {
            book.AddFootnote(1, "test");
            Assert.Throws<InvalidOperationException>(() => book.AddFootnote(1, "test2"));
        }

        [Test]
        public void Test_FindFootNoteShouldThrow()
        {
            Assert.Throws<InvalidOperationException>(() => book.FindFootnote(-10));
        }

        [Test]
        public void Test_FindFootNoteShouldWorkProperly()
        {
            int footNoteNumber = 1;
            string text = "test";
            book.AddFootnote(footNoteNumber, text);
            string expectedText = $"Footnote #{footNoteNumber}: {text}";
            Assert.AreEqual(expectedText, book.FindFootnote(footNoteNumber));
        }

        [Test]
        public void Test_AlterFootNoteShouldThrow()
        {
            Assert.Throws<InvalidOperationException>(() => book.AlterFootnote(-10, "test"));
        }

        [Test]
        public void Test_AlterFootNoteShouldWorkProperly()
        {
            int footNoteNumber = 1;
            string text = "test";
            book.AddFootnote(footNoteNumber, text);
            string newText = "test2";
            book.AlterFootnote(footNoteNumber, newText);
            string expectedText = $"Footnote #{footNoteNumber}: {newText}";
            Assert.AreEqual(expectedText, book.FindFootnote(footNoteNumber));
        }
    }
}