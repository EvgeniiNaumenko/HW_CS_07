using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2.Створити класс Library. Властивості: ім'я бібліотеки, адрес, список книжок (використовувати створений на
//практиці клас Book). Реалізувати ітератор. Тест: створити масив книжок, створити об'єкт бібліотекі та
//перебрати всі книжки, які там є. Використати оператор yield.
//Додаткове завдання: Спробувати написати свій клас-ітератор (Current, Reset, MoveNext)
namespace HW_07_10_06_2024
{
    internal class Library:// IEnumerable<Book>
    {
        public string LibraryName {  get; set; }
        public string Address { get; set; }
        public List<Book> _books;
        public Library (string name)
        {
            _books = new List<Book> ();
            LibraryName = name;
        }
        public void AddBook (Book book)
        {
            bool isIn = false;
            for (int i = 0; i <_books.Count; i++)
            {
                if (_books[i].Name == book.Name)
                {
                    isIn = true;
                    break;
                }
            }
            if (!isIn)
            {
                _books.Add (book);
            }
        }
        public static Library operator+ (Library library, Book book)
        {
            if (!library.IsBookInLibrary(book.Name))
            {
                library.AddBook(book);
            }
            return library;
        }
        public static Library operator- (Library library, string bookName)
        {
            library._books.RemoveAll(book => book.Name == bookName);
            return library;
        }
        public bool IsBookInLibrary(string name)
        {
            foreach (var book in _books)
            {
                if (book.Name == name)
                {
                    return true;
                }
            }
            return false;
        }
        //public IEnumerator<Book> GetEnumerator()
        //{
        //    foreach (var book in _books)
        //    {
        //        yield return book;
        //    }
        //}

        //IEnumerator IEnumerable.GetEnumerator()
        //{
        //    throw new NotImplementedException();
        //}
        public override string ToString()
        {
            Console.WriteLine("Books in library:");
            foreach (Book book in _books)
            {
                Console.WriteLine(book);
            }
            Console.WriteLine("end!");

            return "";
        }
    }
}
