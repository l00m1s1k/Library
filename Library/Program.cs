using System;
using System.Collections.Generic;

namespace BibliographicSystem
{
    // Клас представляє книгу
    class Book
    {
        public string Title { get; set; }
        public List<Author> Authors { get; set; }
        public int Year { get; set; }

        public Book(string title, List<Author> authors, int year)
        {
            Title = title;
            Authors = authors;
            Year = year;
        }

        public override string ToString()
        {
            return $"{Title} ({Year}) by {string.Join(", ", Authors)}";
        }
    }

    // Клас представляє автора
    class Author
    {
        public string Name { get; set; }

        public Author(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    // Клас представляє бібліотеку
    class Library
    {
        public List<Book> Books { get; set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void DisplayBooks()
        {
            Console.WriteLine("Books in the library:");
            foreach (var book in Books)
            {
                Console.WriteLine(book);
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // Створення кількох авторів
            var author1 = new Author("John Doe");
            var author2 = new Author("Jane Smith");

            // Створення кількох книг
            var book1 = new Book("Introduction to C#", new List<Author> { author1, author2 }, 2022);
            var book2 = new Book("Advanced Programming", new List<Author> { author2 }, 2023);

            // Створення бібліотеки та додавання книг
            var library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);

            // Виведення інформації про книги в бібліотеці
            library.DisplayBooks();
        }
    }
}
