using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//2.Створити класс Library. Властивості: ім'я бібліотеки, адрес, список книжок (використовувати створений на
//практиці клас Book). Реалізувати ітератор. Тест: створити масив книжок, створити об'єкт бібліотекі та
//перебрати всі книжки, які там є. Використати оператор yield.
//Додаткове завдання: Спробувати написати свій клас-ітератор (Current, Reset, MoveNext)

namespace HW_07_10_06_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library lib = new Library("BookLib");
            Book book1 = new Book("BookName1");
            Book book2 = new Book("BookName2");
            Book book3 = new Book("BookName3");
            lib.AddBook(book1);
            lib.AddBook(book2);
            Console.WriteLine(lib);
            Console.WriteLine($"Есть ли книга Book2 в библиотеке? {lib.IsBookInLibrary("BookName2")}");
            Console.WriteLine($"Есть ли книга Book3 в библиотеке? {lib.IsBookInLibrary("BookName3")}");
            lib += book3; //Добавим книгу
            Console.WriteLine(lib);
            lib -= "BookName1"; //Удалим книгу
            Console.WriteLine(lib);
            foreach(Book book in lib)
            {
                book.Author = "Unknow";
            }
            Console.WriteLine(lib);
        }
    }
}
