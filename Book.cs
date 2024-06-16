using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HW_07_10_06_2024
{
    internal class Book
    {
        public string Name { get; set; }
        public string Author { get; set; } 
        public string Description { get; set; }
        public Book() { }   
        public Book (string name)
        { 
            Name = name;
        }
        public override string ToString()
        {
            return $"Name: {Name}\nAuthor {Author}\nDescription: {Description}";
        }
    }
}
