using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Book
    {
        public Book(int id, string title, string author, bool isAvailable)
        {
            Id = id;
            Title = title;
            Author = author;
            IsAvailable = isAvailable;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public bool IsAvailable { get; set; }
    }
}
